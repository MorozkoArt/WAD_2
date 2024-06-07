using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABA2
{
    public partial class FON_2 : Form
    {
        Boolean net;
        int net_size;
        Boolean period_net_exist;
        int period_net;
        int period_net_size;
        Color background_color; 
        Color net_color; 
        Boolean gradient;
        Color gradient1;
        Color gradient2;
        Color axis_pen;
        public FON_2(Boolean net, int net_size, Boolean period_net_exist, int period_net, int period_net_size, Color background_color, Color axis_pen, Color net_color, Boolean gradient, Color gradient1, Color gradient2)
        {
             
            InitializeComponent();
            this.net = net;
            this.net_size = net_size;
            this.period_net = period_net;
            this.period_net_size = period_net_size;
            this.period_net_exist = period_net_exist;
            this.background_color = background_color;
            this.net_color = net_color;
            this.gradient = gradient;
            this.gradient1 = gradient1;
            this.gradient2 = gradient2;      
            this.axis_pen = axis_pen;
            OK.Enabled = false;
        }    

        private void button1_Click(object sender, EventArgs e)
        {
            background_color = Color.Coral;
            net_color = Color.OrangeRed;
            axis_pen = Color.OrangeRed;
            period_net_exist = false;
            gradient = true;
            gradient1 = Color.Coral;
            gradient2 = Color.LightYellow;
            net = false;
            OK.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            background_color = Color.Gold;
            net_color = Color.DarkGoldenrod;
            axis_pen = Color.DarkGoldenrod;
            period_net_exist = true;
            period_net = 4;
            period_net_size = 3;
            gradient = false;  
            net = true;
            net_size = 2;
            OK.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            background_color = Color.Pink;
            net_color = Color.HotPink;
            axis_pen = Color.HotPink;
            period_net_exist = false;            
            gradient = true;
            gradient1 = Color.Pink;
            gradient2 = Color.Aquamarine;
            net = true;
            net_size = 2;
            OK.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            background_color = Color.MediumPurple;
            net_color = Color.Purple;
            axis_pen = Color.Purple;
            period_net_exist = true;
            period_net = 3;
            period_net_size = 3;
            gradient = false;           
            net = false;
            OK.Enabled = true;
        }
   
        public Boolean get_net()
        {
            return net;
        }
        public int get_net_size()
        {
            return net_size;
        }
        public Boolean get_period_net_exist()
        {
            return period_net_exist;
        }
        public int get_period_net()
        {
            return period_net;
        }
        public int get_period_net_size()
        {
            return period_net_size;
        }
        public Color get_background_color()
        {
            return background_color;
        }
        public Color get_net_color()
        {
            return net_color;
        }
        public Boolean get_gradient()
        {
            return gradient;
        }
        public Color get_gradient1()
        {
            return gradient1;
        }
        public Color get_gradient2()
        {
            return gradient2;
        }
        public Color get_axis_color()
        {
            return axis_pen;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void NO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FON_2_Load(object sender, EventArgs e)
        {

        }
    }
}
