using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_Tom
{
    public partial class Lab8Form : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }





        /// <summary>
        /// This is a constructor
        /// </summary>
        public Lab8Form()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the Event Handler for the SubmitButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = YourNameTextBox.Text;
            UserAge = float.Parse(AgeTextBox.Text);


            outputLabel.Text = YourNameTextBox.Text + " " + AgeTextBox.Text;

            YourNameTextBox.Text = string.Empty;
            AgeTextBox.Text = string.Empty;


        }



        private void Lab8Form_Load_1(object sender, EventArgs e)
        {
            SubmitButton.Enabled = false;
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = true;
        }
    }
}
