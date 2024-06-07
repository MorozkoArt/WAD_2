using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LABA2
{

    public partial class Grafik : Form
    {
        public Grafik()
        {
            InitializeComponent();
            functions.Add(new Sin());
            functions.Add(new x_x());
            functions.Add(new x_x_x());
            functions.Add(new tg());
            functions.Add(new _2x_5());
            groupBox1.Controls.Add(Change_Color);
            groupBox1.Controls.Add(Random_Function);
            groupBox1.Controls.Add(Choice_Background);
            groupBox1.Controls.Add(Save);
            groupBox1.Controls.Add(Color_See);
            groupBox1.Controls.Add(Fon_Start);
            groupBox1.Controls.Add(listBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(delete);
            this.Panel_P.MouseWheel += new MouseEventHandler(this.Panel_MouseWheel);
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
            | BindingFlags.Instance | BindingFlags.NonPublic, null,
            Panel_P, new object[] { true });
            axis_pen.CustomEndCap = new AdjustableArrowCap(4, 4);
            Fon_Start.Enabled = false;
            delete.Enabled = false;
        }
        List<IFunction> functions = new List<IFunction>();
        private double k = 1; // коэффициент масштаба
        int a = 0;// перемещение по оси x
        int b = 0;// перемещение по оси y
        int one = 50;
        int fun = -1;
        double cos = 0;
        double cos1 = 0;
        Pen function_pen = new Pen(Color.Black, 3); // ручка графика
        Pen net_pen = new Pen(Color.Gray, 2); // ручка сетки
        Pen period_net_pen = new Pen(Color.Gray, 2); // ручка для более жирных линий сетки
        Pen axis_pen = new Pen(Color.Black, 3); // ручка для осей
        Boolean net = true; // флаг для рисования сетки
        Boolean period_net_exist = true;
        Boolean gradient = false;
        int period_net = 3; // с каким периодом нужно рисовать линии сетки более жирными
        Color gradient1 = Color.White;
        Color gradient2 = Color.White;
        Color drawBrush_color = Color.Black;
        List <double> Ugol = new List<double>();
        public void UpdateListBox() //Функция для обновления списка клиентов
        {
            listBox.Items.Clear();
            for (int i = 0; i < Ugol.Count; i++)
            {
                listBox.Items.Add(i+1 + ": "+ Math.Round(Ugol[i],1) + "°" );
            }
            if (Ugol.Count() != 0)
            {
                delete.Enabled = true;
            }
            else
            {
                delete.Enabled = false;
            }
        }
        private void Change_Color_Click(object sender, EventArgs e)
        {
            ColorDialog FunColor = new ColorDialog();
            FunColor.AllowFullOpen = true;
            FunColor.ShowHelp = true;
            FunColor.Color = Color_See.BackColor;
            if (FunColor.ShowDialog() == DialogResult.OK)
            {
                if(FunColor.Color != Color_See.BackColor) Fon_Start.Enabled = true;
                Color_See.BackColor = FunColor.Color;
                function_pen.Color = FunColor.Color;
                Panel_P.Invalidate();               
            }
        }

        private void Random_Function_Click(object sender, EventArgs e)
        {
            int fun1 = fun;
            while (fun1 == fun)
            {
                Random rnd = new Random();
                fun = rnd.Next(5);
            }
            double k1 = k;
            k = 1;
            a = 0;
            b = 0;
            cos = 0;
            cos1 = 0;
            one = (int)Math.Round(one * k / k1);
            Panel_P.Invalidate();
            Ugol.Clear();
            UpdateListBox();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg";
            saveFileDialog1.Title = "Сохранить изображеник графика";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                Bitmap bmp = new Bitmap(Panel_P.Width, Panel_P.Height);
                Panel_P.DrawToBitmap(bmp, new Rectangle(0, 0, Panel_P.Width, Panel_P.Height));                
                bmp.Save(fs,System.Drawing.Imaging.ImageFormat.Jpeg);        
                fs.Close();
            }
        }
        /// todo(Крупный доп)        
        /*  (Крупный доп) сделать поворот графика, сохранять поворот в гроупбоксе(градусы и индекс поворота) 
                      закрашивать область единичной окружности в зависимости от поворота 
        предусмотрена функция удаления угла(положения графика меняется в зависимости от удаленного угла)
        */
        private void Panel_P_Paint(object sender, PaintEventArgs e)
        {
            Font drawFont = new Font("Arial", 12);
            Font drawFont2 = new Font("Arial", 10);
            SolidBrush drawBrush = new SolidBrush(drawBrush_color);
            SolidBrush drawBrush2 = new SolidBrush(Color.Gray);
            int pwight = Panel_P.Width; //ширина экрана
            int pheight = Panel_P.Height;// высота экрана
            int x0 = pwight / 2 + a; // x координата центра
            int y0 = pheight / 2 + b; // y координата центра
            Graphics graphics = e.Graphics;
            if (gradient)
            {
                LinearGradientBrush linGrBrush = new LinearGradientBrush(
                    new Point(0, 0),
                    new Point(pwight, pheight),
                    gradient1,
                    gradient2);
                graphics.FillRectangle(linGrBrush, 0, 0, pwight, pheight);
            }
            if (net) 
            {
                for (int i = 0; i <= pwight / one; i++)
                {
                    if ((period_net_exist == false) || ((i * one + x0 % one - x0) % (one * period_net) != 0))
                        graphics.DrawLine(net_pen, i * one + x0 % one, 0, i * one + x0 % one, pheight);
                }
                for (int i = 0; i <= pheight / one; i++)
                {
                    if ((period_net_exist == false) || ((i * one + y0 % one - y0) % (one * period_net) != 0))
                        graphics.DrawLine(net_pen, 0, i * one + y0 % one, pwight, i * one + y0 % one);
                }
                /*
                int g = 0;               
                for (int i = -pheight; i <= pheight; i++)
                {
                    for(int q=-pwight; q <= pwight; q++)
                    {
                        if ((g % 2 == 0))
                        {
                            graphics.FillRectangle(drawBrush2, new Rectangle(q * one + (x0 % one), i*one-2+b, one, one));
                        }
                        g++;
                    }                                
                }*/
            
            }
            if (period_net_exist)
            {
                for (int i = 0; i <= pwight / one; i++)
                {
                    if (((i * one + x0 % one - x0) % (one * period_net) == 0))
                        graphics.DrawLine(period_net_pen, i * one + x0 % one, 0, i * one + x0 % one, pheight);
                }
                for (int i = 0; i <= pheight / one; i++)
                {
                    if (((i * one + y0 % one - y0) % (one * period_net) == 0))
                        graphics.DrawLine(period_net_pen, 0, i * one + y0 % one, pwight, i * one + y0 % one);
                }
            }
            SolidBrush drawBrush4 = new SolidBrush(Color.Gold);
            graphics.FillEllipse(drawBrush4, x0 - one, y0 - one, 2 * one, 2 * one);
            if (cos != 0)
            {               
                SolidBrush drawBrush3 = new SolidBrush(Color.LimeGreen);
                Rectangle TT = new Rectangle(x0 - one, y0 - one, 2 * one, 2 * one);               
                graphics.FillPie(drawBrush3, TT, (float)(cos1 * 180 / Math.PI), ((float)(cos * 180 / Math.PI) - (float)(cos1 * 180 / Math.PI)));
            }
            if ((x0 >= 0) && (x0 <= pwight))
            {
                graphics.DrawLine(axis_pen, x0, pheight, x0, 0); // рисование оси Y
                graphics.DrawString("Y", drawFont, drawBrush, x0+10, 0);
            }
            if ((y0 >= 0) && (y0 <= pheight))
            {                
                graphics.DrawLine(axis_pen, 0, y0, pwight, y0);// рисование оси X
                graphics.DrawString("X", drawFont, drawBrush, pwight-20, y0+10);
            }               
            if (!((y0 + one < 0) || (y0 - one > pheight) || (x0 + one < 0) || (x0 - one > pwight)))//рисование еденичной окружности
            {
                Pen circle_pen = new Pen(axis_pen.Color, axis_pen.Width);
                circle_pen.DashStyle = DashStyle.Dash;
                graphics.DrawEllipse(circle_pen, x0 - one, y0 - one, 2 * one, 2 * one);
            }
            
            if (fun != -1)// рисование графиков
            {
                if ( cos > 2*Math.PI)
                {
                    cos1 = cos1 - 2*Math.PI;
                    cos = cos - 2*Math.PI;
                }
                else if (cos < -2*Math.PI)
                {
                    cos1 = cos1 + 2*Math.PI;
                    cos = cos + 2*Math.PI;
                }
                label1.Text = Math.Round((((cos-cos1)*180)/Math.PI), 1).ToString() + "°";
                label3.Text = Math.Round(((cos * 180) / Math.PI), 1).ToString() + "°";
                int f0 = -pwight;
                int f1 = 2*pwight; 
                if(fun != 2)
                {
                    f1 = f1 + (Math.Abs(a) + Math.Abs(b)) * 3;
                    f0 = f0 - (Math.Abs(a) + Math.Abs(b))* 3;
                }
                for (int i = f0; i < f1; i++)
                {                   
                    int y1 = y0 - (int)((functions[fun].calc((double)(i - x0) / one)) * one);
                    int y2 = y0 - (int)((functions[fun].calc((double)(i + 1 - x0) / one)) * one);
                    // повороT
                    int x1 = (int)Math.Round((i-x0) *Math.Cos(cos) - (y1-y0)*Math.Sin(cos)) + x0;
                    y1 = (int)Math.Round((i - x0) * Math.Sin(cos) + (y1 - y0) * Math.Cos(cos)) + y0;                    
                    int x2 = (int)Math.Round(((i+1)-x0) * Math.Cos(cos) - (y2-y0) * Math.Sin(cos))+ x0;                   
                    y2 = (int)Math.Round(((i+1)-x0) * Math.Sin(cos) + (y2 - y0) * Math.Cos(cos))+y0;
                    //
                    //    ЛЮБИМЫЙ ТАНГЕНС!!!            
                    if ((fun == 3) && (((cos  >= 0) && (cos < Math.PI/2))
                        || ((cos  < -Math.PI*3/2) && (cos >= -2*Math.PI)))
                        && ((y2 - y1 > 50)||(x1 - x2 > 50)))
                    {
                        graphics.DrawLine(function_pen, x1, y1, x1+(int)Math.Round(Math.Tan(cos) * y1), 0);
                        graphics.DrawLine(function_pen, x2 - (int)Math.Round(Math.Tan(cos) * (pheight - y2)), pheight, x2, y2);
                    }
                    else if ((fun == 3) && (((cos>= Math.PI / 2) && (cos <  Math.PI))
                        || ((cos >= -Math.PI * 3 / 2) && (cos < -Math.PI)))
                       && ((y1 - y2 > 50) || (x1 - x2 > 50)))
                    {
                        graphics.DrawLine(function_pen, x1, y1, x1 - (int)Math.Round(Math.Tan(cos) * (pheight -y1)), pheight);
                        graphics.DrawLine(function_pen, x2 + (int)Math.Round(Math.Tan(cos) *y2), 0, x2, y2);                       
                    }
                    else if ((fun == 3) && (((cos >= -Math.PI) && (cos< -Math.PI / 2))
                        || ((cos >= Math.PI) && (cos < Math.PI * 3 / 2)))
                       &&((y1 - y2 > 50) || (x2 - x1 > 50)))
                    {
                        graphics.DrawLine(function_pen, x1, y1, x1 - (int)Math.Round(Math.Tan(cos) * (pheight - y1)), pheight);
                        graphics.DrawLine(function_pen, x2 + (int)Math.Round(Math.Tan(cos) * y2), 0, x2, y2);                    
                    }
                    else if ((fun == 3) && (((cos>= -Math.PI/ 2) && (cos < 0))
                        || ((cos>= Math.PI * 3 / 2) && (cos<= 2*Math.PI)))
                       && ((y2 - y1 > 50) || (x2 - x1 > 50))) 
                    {
                        graphics.DrawLine(function_pen, x1, y1, x1 + (int)Math.Round(Math.Tan(cos) * y1), 0);
                        graphics.DrawLine(function_pen, x2 - (int)Math.Round(Math.Tan(cos) * (pheight - y2)), pheight, x2, y2);                        
                    } 
                    else  graphics.DrawLine(function_pen, x1, y1, x2, y2);                    
                }
            } 
            if (k != 1)// отображение масштаба
            {
                String Scale = "X" + k.ToString();
                graphics.DrawString(Scale, drawFont2, drawBrush, Panel_P.Width - 30, 0);                                              
            }
            else graphics.DrawString("", drawFont2, drawBrush, Panel_P.Width - 20, 0);

        }
        int startx = 0;
        int starty = 0;
        int startx2 = 0;
        int starty2 = 0;
        Boolean flag = false;
        Boolean flag2 = false;

        private void Panel_P_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) > 0)
            {
                startx = e.X;
                starty = e.Y;
                Panel_P.Focus();
                flag = true;
                Panel_P.Invalidate();
            }
            if (((e.Button & MouseButtons.Right) > 0) && (fun != -1))
            {
                startx2 = e.X;
                starty2 = e.Y;
                Panel_P.Focus();
                flag2 = true;
                Panel_P.Invalidate();
            }
        }
        private int a1, b1, c1 = 0;
        private void Panel_P_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                a = a - startx + e.X;
                b = b - starty + e.Y;               
                startx = e.X;
                starty = e.Y;
                Panel_P.Invalidate();
            }
            if (flag2)
            {
                int znak = 1;
                int x0_0 = Panel_P.Width / 2 + a;
                if (starty2 > e.Y) znak = -1;
                if((startx2 > x0_0+5) || (startx2 < x0_0 - 5))
                {
                    a1 = (int)Math.Round(Math.Sqrt(Math.Pow((e.X - startx2), 2) + Math.Pow((e.Y - starty2), 2)));
                    b1 = (int)Math.Round(Math.Sqrt(Math.Pow((x0_0 - startx2), 2) + Math.Pow((starty2 - starty2), 2)));
                    c1 = (int)Math.Round(Math.Sqrt(Math.Pow((x0_0 - e.X), 2) + Math.Pow((starty2 - e.Y), 2)));                  
                    cos= cos1 + Math.Acos((Math.Pow(b1, 2) + Math.Pow(c1, 2) - Math.Pow(a1, 2)) / (2 * b1 * c1)) * znak;                 
                }             
                Panel_P.Invalidate();
            }
        }
        private void Panel_P_MouseUp(object sender, MouseEventArgs e)
        {
            if (((e.Button & MouseButtons.Left) > 0) && (flag == true))
            {       
                flag = false;
            }
            if (((e.Button & MouseButtons.Right) > 0) && (flag2 == true))
            {
                flag2 = false;
                Ugol.Add((((cos - cos1) * 180) / Math.PI));
                cos1 = cos;
                UpdateListBox();
                Panel_P.Invalidate();
            }
        }
        private void delete_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                if (MessageBox.Show("Удалить "  + listBox.SelectedIndices.Count + " Записи" ,
                                    "Удаление",
                                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for(int i = 0; i < listBox.SelectedIndices.Count; i++)
                    {
                        cos = cos - (Ugol[listBox.SelectedIndices[i]] * Math.PI / 180);                                                                                          
                    }
                    int q = 0;
                    for (int i = 0; i < listBox.SelectedIndices.Count; i++)
                    {
                        Ugol.RemoveAt(listBox.SelectedIndices[i]-q);
                        q++;
                    }
                    if (Ugol.Count == 0)
                    {
                        cos = 0;
                    }
                    cos1 = cos;
                    UpdateListBox();
                    Panel_P.Invalidate();
                }
            }
        }
        private void Panel_MouseWheel(object sender, MouseEventArgs e) // Маштабирование
        {
            double k1 = k;
            if (e.Delta > 0) 
                k = Math.Round(k + 0.2, 1);
            else if (k > 0.2)
                k = Math.Round(k - 0.2, 1);
            one = (int)Math.Round(one * k / k1);
            a = (int)Math.Round(a * k / k1);
            b = (int)Math.Round(b * k / k1);
            if (k >= 0.2)  
                Panel_P.Invalidate();
        }

        private void Grafik_SizeChanged(object sender, EventArgs e)
        {
            Panel_P.Invalidate();
        }

        ///todo сделать, чтобы сетка закрашывалась в шахматном порядке.     
        private void Choice_Background_Click(object sender, EventArgs e)
        {           
            if (MessageBox.Show("Вы желаете изменить интерфейс самостоятельно? " +
                "(ДА - самостоятельно, НЕТ - выбрать предложенные варианты)",
                "Изменение интерфейса",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FON Fon = new FON(net, (int)net_pen.Width, period_net_exist, period_net, (int)period_net_pen.Width, Panel_P.BackColor, axis_pen.Color, net_pen.Color, gradient, gradient1, gradient2);
                if (Fon.ShowDialog() == DialogResult.OK)
                {
                    net = Fon.get_net1();
                    net_pen.Color = Fon.get_net_color1();
                    period_net_pen.Color = Fon.get_net_color1();
                    axis_pen.Color = Fon.get_axis_color1();
                    net_pen.Width = Fon.get_size_net1();
                    period_net_exist = Fon.get_period_net_exist1();
                    period_net = Fon.get_period_net1();
                    period_net_pen.Width = Fon.get_period_net_size1();
                    gradient = Fon.get_gradient1();
                    gradient1 = Fon.get_gradient1_color1();
                    gradient2 = Fon.get_gradient2_color1();
                    drawBrush_color = Fon.get_axis_color1();
                    Panel_P.BackColor = Fon.get_background_color1();
                    if ((net == true) && (period_net_exist == true)) axis_pen.Width = Math.Max(net_pen.Width, period_net_pen.Width) + 1;
                    else if (net == true) axis_pen.Width = net_pen.Width + 2;
                    else if (period_net_exist == true) axis_pen.Width = period_net_pen.Width + 2;
                    else axis_pen.Width = 3;
                    Panel_P.Invalidate();
                    Fon_Start.Enabled = true;
                }
            }
            else
            {               
                FON_2 Fon_2 = new FON_2(net, (int)net_pen.Width, period_net_exist, period_net, (int)period_net_pen.Width, Panel_P.BackColor, axis_pen.Color, net_pen.Color, gradient, gradient1, gradient2);
                if(Fon_2.ShowDialog() == DialogResult.OK)
                {
                    net = Fon_2.get_net();
                    net_pen.Color = Fon_2.get_net_color();
                    period_net_pen.Color = Fon_2.get_net_color();
                    axis_pen.Color = Fon_2.get_axis_color();
                    net_pen.Width = Fon_2.get_net_size();
                    period_net_exist = Fon_2.get_period_net_exist();
                    period_net = Fon_2.get_period_net();
                    period_net_pen.Width = Fon_2.get_period_net_size();
                    gradient = Fon_2.get_gradient();
                    gradient1 = Fon_2.get_gradient1();
                    gradient2 = Fon_2.get_gradient2();
                    drawBrush_color = Fon_2.get_axis_color();
                    Panel_P.BackColor = Fon_2.get_background_color();
                    if ((net == true) && (period_net_exist == true)) axis_pen.Width = Math.Max(net_pen.Width, period_net_pen.Width) + 1;
                    else if (net == true) axis_pen.Width = net_pen.Width + 2;
                    else if (period_net_exist == true) axis_pen.Width = period_net_pen.Width + 2;
                    else axis_pen.Width = 3;
                    Panel_P.Invalidate();
                    Fon_Start.Enabled = true;
                }               
            }
        }      
        private void Fon_Start_Click(object sender, EventArgs e)
        {
            period_net_exist = true;
            gradient = false;
            net = true;
            Panel_P.BackColor = Color.White;
            net_pen.Color = Color.Gray;
            axis_pen.Color = Color.Black;
            function_pen.Color = Color.Black;
            gradient1 = Color.White;
            gradient2 = Color.White;
            period_net_pen.Width = 2;
            net_pen.Width = 1;
            axis_pen.Width = 3;
            drawBrush_color = Color.Black;
            period_net = 3;
            period_net_pen.Color = Color.Gray;
            Color_See.BackColor = Color.Black;
            Panel_P.Invalidate();
            Fon_Start.Enabled = false;
        }

    }
}
