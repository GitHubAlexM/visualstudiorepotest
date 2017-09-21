using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;

namespace mouseSim
{
    class Form1 : Form
    {
        private Button button1 = new Button();
        private Button button2 = new Button();



        public Form1()
        {
            button1.Location = new Point(10, 10);
            button1.TabIndex = 0;
            button1.Text = "Button Test A";
            button1.AutoSize = true;
            button1.Click += new EventHandler(button1_Click);

            this.DoubleClick += new EventHandler(Form1_DoubleClick);
            this.Controls.Add(button1);

            button2.Location = new Point(10, 40);
            button2.TabIndex = 0;
            button2.Text = "Button Test B";
            button2.AutoSize = true;
            button2.Click += new EventHandler(button2_Click);

            //this.DoubleClick += new EventHandler(Form1_DoubleClick);
            this.Controls.Add(button2);
        }

        // 
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button has been double-clicked!");
        }

        // 
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Don't click this button");
        }

        // Send a key to the button when the user double-clicks anywhere 
        // on the form.
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            // Send the enter key to the button, which raises the click 
            // event for the button. This works because the tab stop of 
            // the button is 0.
            SendKeys.Send("{ENTER}");
        }
    }
}