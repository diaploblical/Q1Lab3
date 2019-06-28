using BooksLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayQuery
{
    public partial class Form1 : Form
    {
        private BooksEntities db = new BooksEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.Titles.Load();
            queryCmb.SelectedIndex = 0;
            titlesBindingSource.DataSource = db.Titles.Local;
        }
    }
}
