/* Vasudev Vijayaraman 
 * C# Programming - 11/13/2018
 * Dr. Catherine Stringfellow
 * This program is to implement graphics and animation on a form using functions such as 
 * Draw, fill and paint. */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Graphics_HW6
{
    public partial class GraphicsForm : Form
    {
        // Declaring all the positions such as the coordinates
        int xpos = 300;
        int ypos = 130;

        public GraphicsForm()
        {
            InitializeComponent();

        }

        // Bool used here so cases can be switched from false to true
        private bool ButtonWasClicked = false;


        /* This method is a default paint event and this is where the drawing takes place on the panel
         * It takes in sender and e and arguments and returns nothing */

        private void Panel_OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            this.Invalidate();
            if (ButtonWasClicked == false) // Until the button has been clicked
            {
                Pen myPen = new Pen(Brushes.Red, 7);

                Pen circlePen = new Pen(Brushes.Black, 9);
                Pen RectanglePen = new Pen(Brushes.Black, 5);

                Font myFont = new Font("Arial", 43, FontStyle.Regular);
                g.DrawString("I am very cute, I know. Thanks!", myFont, Brushes.Black, 180, 8);
               


                g.DrawRectangle(RectanglePen, 300, 385, 250, 250);
                g.FillRectangle(Brushes.BlueViolet, 300, 385, 250, 250);
                g.FillEllipse(Brushes.Pink, xpos, ypos, 250, 250);
                g.DrawEllipse(circlePen, xpos + 65, ypos - 130 + 200, 20, 35);
                g.FillEllipse(Brushes.Black, 415, 420, 20, 20);
                g.DrawEllipse(circlePen, 415, 420, 20, 20);
                g.DrawEllipse(circlePen, xpos, ypos, 250, 250);
                g.DrawEllipse(circlePen, 415, 490, 20, 20);
                g.DrawEllipse(circlePen, 415, 560, 20, 20);

                g.FillEllipse(Brushes.Black, 415, 420, 20, 20);
                g.FillEllipse(Brushes.Black, 415, 490, 20, 20);
                g.FillEllipse(Brushes.Black, 415, 560, 20, 20);
                g.FillEllipse(Brushes.Black, xpos + 65, ypos - 130 + 200, 20, 35);
                g.DrawEllipse(circlePen, xpos + 160, ypos - 130 + 200, 20, 35);
                g.FillEllipse(Brushes.Black, xpos + 160, ypos - 130 + 200, 20, 35);
                g.DrawArc(circlePen, xpos + 60, ypos - 130 + 215, 130, 120, 35, 115);
            }

            if (ButtonWasClicked == true) // Once Button is clicked
            {

                Pen myPen = new Pen(Brushes.Red, 7);

                Pen circlePen = new Pen(Brushes.Black, 9);
                Pen RectanglePen = new Pen(Brushes.Black, 5);

                Font myFont = new Font("Times New Roman", 43);
                g.DrawString("I just changed my outfit and I am still cute !", myFont, Brushes.Black, 180, 10);


                g.DrawRectangle(RectanglePen, 800, 385, 250, 250);
                g.FillRectangle(Brushes.PaleVioletRed, 800, 385, 250, 250); // Fill the rectangle
                g.FillEllipse(Brushes.LightYellow, xpos + 500, ypos, 250, 250);
                g.DrawEllipse(circlePen, xpos + 550, ypos - 130 + 200, 20, 35);
                g.DrawEllipse(circlePen, 915, 420, 20, 20);
                g.DrawEllipse(circlePen, xpos + 500, ypos, 250, 250);


                g.DrawEllipse(circlePen, 915, 490, 20, 20);
                g.DrawEllipse(circlePen, 915, 560, 20, 20);

                g.FillEllipse(Brushes.Black, 915, 420, 20, 20); // Fills the ellipse with black color
                g.FillEllipse(Brushes.Black, 915, 490, 20, 20);
                g.FillEllipse(Brushes.Black, 915, 560, 20, 20);
                g.FillEllipse(Brushes.Black, xpos + 650, ypos - 130 + 200, 20, 35);
                g.DrawEllipse(circlePen, xpos + 650, ypos - 130 + 200, 20, 35);
                g.FillEllipse(Brushes.Black, xpos + 550, ypos - 130 + 200, 20, 35);
                g.DrawArc(circlePen, xpos + 550, ypos - 130 + 215, 130, 120, 35, 115); // Draws the arc which is the smiley

            }
        }

        /* This method takes place once the button is clicked so the images moves from left to right.
         * It takes in sender and as arguments and returns nothing */

        private void Surprise_Button_Click(object sender, EventArgs e)
        {
            listBox1_SelectedIndexChanged(sender, e);
            comboBox1_SelectedIndexChanged(sender, e);
            ButtonWasClicked = true; // Setting the bool to true;

            this.BackColor = Color.FromArgb(178, 198, 125); // Changes the background color
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> myList = new List<string>();
            myList.Add("FUCK");
            myList.Add("123");
            myList.Add("Screw");
          
            listBox1.DataSource = myList;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> myList1 = new List<string>();
            myList1.Add("FUCK");
            myList1.Add("123");
            myList1.Add("Screw");

            comboBox1.DataSource = myList1;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fuckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK babe", "ALRIGHT NIGGA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}




