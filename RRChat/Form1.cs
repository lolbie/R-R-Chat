using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRChat
{
    public partial class Form1 : Form
    {
        bool LoggedIn = false;
        public Form1()
        {
            InitializeComponent();
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (LoggedIn == false)
            {
                myAccountMenu.Visible = false;
            }
        }

    }
}
