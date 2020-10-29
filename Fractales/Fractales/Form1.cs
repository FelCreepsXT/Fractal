using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractales
{
    /*
          Sin                     Y
          0 = 0              = 0   
          90 = Pi/2          = 1   => Cambia
          180 = Pi           = 0
          270 = 3PI/2        = -1  => Cambia

          Cos                     X
          0 = 0              = 1    => Cambia
          90 = Pi/2          = 0
          180 = Pi           = -1   => Cambia
          270 = 3PI/2        = 0
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Tree tree = new Tree();
        bool firstIteration = true;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {            
        }


        private void BtnCreateBranch_Click(object sender, EventArgs e)
        {
            Graphics graphics;            
            graphics = PanelPaint.CreateGraphics();

            if(TxtLongitude.Text == "" || TxtAngle.Text == "")
            {
                MessageBox.Show("You didn't insert value in Longitude");
            }
            else if(TxtAngle.Text == "")
            {
                MessageBox.Show("You didn't insert value in Angle");
            }
            else if (int.Parse(TxtLongitude.Text) >= 100 && int.Parse(TxtLongitude.Text) <= 160)
            {
                if(int.Parse(TxtAngle.Text) >= 0 && int.Parse(TxtAngle.Text) <= 90)
                {
                    if (firstIteration == true)
                    {
                        firstIteration = false;
                        TxtLongitude.Visible = false;
                        label2.Visible = false;
                        tree.longitude = int.Parse(TxtLongitude.Text);
                        tree.DrawPrincipalBranch(graphics, PanelPaint.Bounds.Width, PanelPaint.Bounds.Height);
                    }
                    else
                    {
                        tree.DrawBranchesForClick(graphics, int.Parse(TxtAngle.Text));
                    }
                }
                else
                {
                    MessageBox.Show("Not is valid: " + TxtAngle.Text);
                }
            }
            else
            {
                MessageBox.Show("Not is valid: " + TxtLongitude.Text);
            }
        }

        

        
    }


}
