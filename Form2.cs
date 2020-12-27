using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Books_Recommendation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            iconPictureBox3.IconColor = Color.FromArgb(0, 139, 139);
            textBox1.ForeColor = Color.FromArgb(0, 139, 139);
            panel2.BackColor = Color.FromArgb(0, 139, 139);


            iconPictureBox4.IconColor = Color.FromArgb(220, 220, 220);
            textBox3.ForeColor = Color.FromArgb(220, 220, 220);
            panel3.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            iconPictureBox4.IconColor = Color.FromArgb(0, 139, 139);
            textBox3.ForeColor = Color.FromArgb(0, 139, 139);
            panel3.BackColor = Color.FromArgb(0, 139, 139);
            textBox3.PasswordChar = '*';


            iconPictureBox3.IconColor = Color.FromArgb(220, 220, 220);
            textBox1.ForeColor = Color.FromArgb(220, 220, 220);
            panel2.BackColor = Color.FromArgb(220, 220, 220);
        }
    }
}
