using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        IMyContactRepository Repository;
        public Form1()
        {
            InitializeComponent();
            Repository = new MyContact();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgcontacts.DataSource = Repository.Selectall();
        }
    }
}
