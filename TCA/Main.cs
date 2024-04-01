using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCA
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            MoveableForm.Class1.AddDrag(this);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
  

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                richTextBox1.Hide();
            }
            else
            {
                richTextBox1.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Assuming you have two RichTextBox controls named richTextBox1 and richTextBox2

            // Get the text from richTextBox2
            string textToAppend = richTextBox2.Text;

            // Set the selection start of richTextBox1 to the end
            richTextBox1.SelectionStart = richTextBox1.TextLength;

            // Append the text to richTextBox1
            richTextBox1.AppendText(textToAppend);

        }
    }
}
