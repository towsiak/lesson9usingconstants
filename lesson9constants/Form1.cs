using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson9constants
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSideLength_TextChanged(object sender, EventArgs e)
        {
            //whenever the text is changed in the box,
            //the label next to the square is updated with that value
            lblSideLength.Text = txtSideLength.Text;
        }

        private void btnFindPerimeter_Click(object sender, EventArgs e)
        {
            //reads the value from the box and saves it, after conversion, to sideLength
            double sideLength = double.Parse(txtSideLength.Text);
            //every square has exactly 4 sides
            //const keyword indicates number of sides should not change
            const ushort numberOfSides = 4;
            //4*10=40 perimeter when each side is 10
            //4*20=80 perimeter when each side is 20
            double perimeter = numberOfSides * sideLength;
            //line below, at run time, will show the perimeter
            lblPerimeter.Text = $"Perimeter={perimeter}";
        }
    }
}
