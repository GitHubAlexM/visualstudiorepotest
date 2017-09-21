using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;

namespace SimulateKeyPress
{
    class Form1 : Form
    {
        private Button button1 = new Button();


        public Form1()
        {
            
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