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
    public partial class FON : Form
    {
        Boolean net1;
        int net_size1;
        Boolean period_net_exist1;
        int period_net1;
        int period_net_size1;
        Color background_color1;
        Color net_color1;
        Boolean gradient1;
        Color gradient1_1;
        Color gradient2_1;
        Color axis_pen1;
        public FON(Boolean net1, int net_size1, Boolean period_net_exist1, int period_net1, int period_net_size1, Color background_color1, Color axis_pen1, Color net_color1, Boolean gradient1, Color gradient1_1, Color gradient2_1)
        { 
            InitializeComponent();
            this.net1 = net1;
            this.net_size1 = net_size1;
            this.period_net1 = period_net1;
            this.period_net_size1 = period_net_size1;
            this.period_net_exist1 = period_net_exist1;
            this.background_color1 = background_color1;
            this.net_color1 = net_color1;
            this.gradient1 = gradient1;
            this.gradient1_1 = gradient1_1;
            this.gradient2_1 = gradient2_1;
            this.axis_pen1 = axis_pen1;
            if (net1)
            {
                net_chec.Checked = true;
            }
            else
            {
                net_chec.Checked = false;
                trackBar_Net.Enabled = false;
            }
            label_axis.BackColor = axis_pen1;
            trackBar_Net.Value = net_size1;
            if (period_net_exist1)
            {
                period_net_exist_chec.Checked = true;
            }
            else
            {
                period_net_exist_chec.Checked = false;
                period_net_trackBar.Enabled = false;
                period_net_numericUpDown.Enabled = false;
            }
            label_fon.BackColor = background_color1;
            label_net.BackColor = net_color1;
            period_net_trackBar.Value = period_net_size1;
            period_net_numericUpDown.Value = period_net1;
            if (gradient1)
            {
                chec_gradient.Checked = true;
            }
            else
            {
                chec_gradient.Checked = false;
                bgradient1.Enabled = false;
                bgradient2.Enabled = false;
            }
            label_gradient1.BackColor = gradient1_1;
            label_gradient2.BackColor = gradient2_1;
            if(net1 == true || period_net_exist1 == true)
            {
                button4.Enabled = true;
            }
            else if((net1 == false) && (period_net_exist1 == false))
            {
                button4.Enabled = false;
            }
            label6.Text = trackBar_Net.Value.ToString();
            label7.Text = period_net_trackBar.Value.ToString();
            Yes.Enabled = false;
        }
        Boolean check = true;
        Boolean check2 = true;
        private void net_chec_CheckedChanged(object sender, EventArgs e)
        {
            if (net_chec.Checked)
            {
                trackBar_Net.Enabled = true;
                trackBar_Net.Value = 1;
                label6.Text = trackBar_Net.Value.ToString();
                check = true;
                button4.Enabled = true;                
            }
            else
            {
                trackBar_Net.Enabled = false;
                check = false;
                if (check2 == false)
                {
                    button4.Enabled = false;
                }
            }
            chekkk();

        }

        private void period_net_exist_chec_CheckedChanged(object sender, EventArgs e)
        {
            if (period_net_exist_chec.Checked)
            {
                period_net_trackBar.Enabled = true;
                period_net_trackBar.Value = 2;
                label7.Text = period_net_trackBar.Value.ToString();
                period_net_numericUpDown.Enabled = true;
                check2 = true;
                button4.Enabled = true;               
            }
            else
            {
                period_net_trackBar.Enabled = false;
                period_net_numericUpDown.Enabled = false;
                check2 = false;
                if(check == false)
                {
                    button4.Enabled = false;
                }
            }
            chekkk();
        }

        private void chec_gradient_CheckedChanged(object sender, EventArgs e)
        {
            if (chec_gradient.Checked)
            {
                bgradient1.Enabled = true;
                bgradient2.Enabled = true;
            }
            else
            {
                bgradient1.Enabled = false;
                bgradient2.Enabled = false;
            }
            chekkk();
        }

        private void bgradient1_Click(object sender, EventArgs e)
        {
            ColorDialog FunColor2 = new ColorDialog();
            FunColor2.AllowFullOpen = true;
            FunColor2.ShowHelp = true;
            FunColor2.Color = label_gradient1.BackColor;
            if (FunColor2.ShowDialog() == DialogResult.OK)
            {
                label_gradient1.BackColor = FunColor2.Color;
            }
            chekkk();
        }

        private void bgradient2_Click(object sender, EventArgs e)
        {
            ColorDialog FunColor3 = new ColorDialog();
            FunColor3.AllowFullOpen = true;
            FunColor3.ShowHelp = true;
            FunColor3.Color = label_gradient2.BackColor;
            if (FunColor3.ShowDialog() == DialogResult.OK)
            {
                label_gradient2.BackColor = FunColor3.Color;
            }
            chekkk();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog FunColor4 = new ColorDialog();
            FunColor4.AllowFullOpen = true;
            FunColor4.ShowHelp = true;
            FunColor4.Color = label_fon.BackColor;
            if (FunColor4.ShowDialog() == DialogResult.OK)
            {
                label_fon.BackColor = FunColor4.Color;
            }
            chekkk();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog FunColor5 = new ColorDialog();
            FunColor5.AllowFullOpen = true;
            FunColor5.ShowHelp = true;
            FunColor5.Color = label_net.BackColor;
            if (FunColor5.ShowDialog() == DialogResult.OK)
            {
                label_net.BackColor = FunColor5.Color;
            }
            chekkk();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog FunColor6 = new ColorDialog();
            FunColor6.AllowFullOpen = true;
            FunColor6.ShowHelp = true;
            FunColor6.Color = label_axis.BackColor;
            if (FunColor6.ShowDialog() == DialogResult.OK)
            {
                label_axis.BackColor = FunColor6.Color;
            }
            chekkk();
        }
        private void trackBar_Net_Scroll(object sender, EventArgs e)
        {
            chekkk();
            label6.Text = trackBar_Net.Value.ToString();
        }

        private void period_net_trackBar_Scroll(object sender, EventArgs e)
        {
            chekkk();
            label7.Text = period_net_trackBar.Value.ToString();
        }

        private void period_net_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            chekkk();
        }
        public void chekkk()
        {
            if (net1 != net_chec.Checked ||
            net_size1 != trackBar_Net.Value ||
            period_net_exist1 != period_net_exist_chec.Checked ||
            period_net1 != (int)period_net_numericUpDown.Value ||
            period_net_size1 != period_net_trackBar.Value ||
            background_color1 != label_fon.BackColor ||
            net_color1 != label_net.BackColor ||
            gradient1 != chec_gradient.Checked ||
            gradient1_1 != label_gradient1.BackColor ||
            gradient2_1 != label_gradient2.BackColor ||
            axis_pen1 != label_axis.BackColor )
            {
                Yes.Enabled = true;
            }
            else
            {
                Yes.Enabled = false;
            }
        }
        public Boolean get_net1()
        {
            return net_chec.Checked;
        }
        public int get_size_net1()
        {
            return trackBar_Net.Value;
        }
        public Boolean get_period_net_exist1()
        {
            return period_net_exist_chec.Checked;
        }
        public int get_period_net1()
        {
            return (int)period_net_numericUpDown.Value;
        }
        public int get_period_net_size1()
        {
            return period_net_trackBar.Value;
        }
        public Color get_net_color1()
        {
            return label_net.BackColor;
        }
        public Color get_axis_color1()
        {
            return label_axis.BackColor;
        }
        public Color get_background_color1()
        {
            return label_fon.BackColor;
        }
        public Boolean get_gradient1()
        {
            return chec_gradient.Checked;
        }
        public Color get_gradient1_color1()
        {
            return label_gradient1.BackColor;
        }
        public Color get_gradient2_color1()
        {
            return label_gradient2.BackColor;
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FON_Load(object sender, EventArgs e)
        {

        }
    }
}
