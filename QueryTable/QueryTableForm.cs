using BooksLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueryTable
{
    public partial class QueryTableForm : Form
    {
        public QueryTableForm()
        {
            InitializeComponent();
        }

        private void QueryTableForm_Load(object sender, EventArgs e)
        {
            BooksEntities db = new BooksEntities();
            var authorsAndBooks = from book in db.Titles
                                  from author in book.Authors
                                  orderby author.LastName, author.FirstName, book.Title
                                  select new { author.FirstName, author.LastName, book.Title };

            outputTxt.AppendText("Authors and Books:");

            foreach (var element in authorsAndBooks)
            {
                outputTxt.AppendText(String.Format("\r\n\t{0,-10} {1,-10} {2}",
                  element.FirstName, element.LastName, element.Title));
            }
        }

        private void QueryCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
