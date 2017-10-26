using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TriangleMath;

namespace TriangleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double edgeOne = int.Parse(textBox1.Text);
                double edgeTwo = int.Parse(textBox2.Text);
                double edgeThree = int.Parse(textBox3.Text);
                Triangle T = new Triangle(edgeOne, edgeTwo, edgeThree);
                double area = T.TriangleArea();
                double perimeter = T.TrianglePerimeter();
                label6.Text = perimeter.ToString();
                label7.Text = area.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
