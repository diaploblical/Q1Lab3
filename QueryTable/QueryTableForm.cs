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
            var authorsAndTitles = from book in db.Titles
                                  from author in book.Authors
                                  select new { author.FirstName, author.LastName, book.Title };

            outputTxt.AppendText("Authors and Titles:");

            foreach (var element in authorsAndTitles)
            {
                outputTxt.AppendText(String.Format("\r\n\t{0,-10} {1,-10} {2}",
                  element.FirstName, element.LastName, element.Title));
            }
        }

        private void QueryCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (queryCmb.SelectedIndex)
            {               
                case 0:
                    outputTxt.Text = String.Empty;
                    BooksEntities db = new BooksEntities();
                    var sortByTitle = from book in db.Titles
                                           from author in book.Authors
                                           orderby book.Title
                                           select new { author.FirstName, author.LastName, book.Title };

                    outputTxt.AppendText("Authors and Titles:");

                    foreach (var element in sortByTitle)
                    {
                        outputTxt.AppendText(String.Format("\r\n\t{0,-10} {1,-10} {2}",
                          element.FirstName, element.LastName, element.Title));
                    }
                    break;
                case 1:
                    outputTxt.Text = String.Empty;
                    db = new BooksEntities();
                    var sortByTitleAndName = from book in db.Titles
                                       from author in book.Authors
                                       orderby book.Title, author.LastName, author.FirstName
                                       select new { author.FirstName, author.LastName, book.Title };

                    outputTxt.AppendText("Authors and Titles:");

                    foreach (var element in sortByTitleAndName)
                    {
                        outputTxt.AppendText(String.Format("\r\n\t{0,-10} {1,-10} {2}",
                          element.FirstName, element.LastName, element.Title));
                    }
                    break;
                case 2:
                    outputTxt.Text = String.Empty;
                    db = new BooksEntities();
                    var groupByTitle = from book in db.Titles
                                       orderby book.Title
                                       select new
                                       {
                                           Titles = book.Title, 
                                           Names = from author in book.Authors 
                                                   orderby author.LastName, author.FirstName
                                                   select author.LastName + author.FirstName
                                       };

                    outputTxt.AppendText("Authors grouped by title:");

                    foreach (var title in groupByTitle)
                    {
                        outputTxt.AppendText(String.Format("\r\n\t{0,-10}",
                            title.Titles
                          ));
                        foreach (var name in groupByTitle)
                        {
                            outputTxt.AppendText(String.Format("\r\n\t{0,-10}",
                            name.Names
                          ));
                        }
                    }
                    break;
            } 
        }
    }
}
