/**
 * Name: Camisha Pruden
 * Teacher: Mr. Hardman
 * Assignment: Number 2, Program number 1
 * Date last modified: 11, 16, 2016
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class HelloUser : Form
    {
        public HelloUser()
        {
            InitializeComponent();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            //I am getting input from the user
            String Name = txtName.Text;
            int Age = Convert.ToInt32(txtAge.Text);

            //I am displaying the result to the user
            lblResult.Text = " Hello " + Name + ". You are " + (Age - 15) + " years older then me. ";
        }
    }
}
