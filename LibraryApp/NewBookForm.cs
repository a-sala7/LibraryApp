using LibraryApp.Models;
using LibraryApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class NewBookForm : Form
    {
        private readonly IDatabase _database;
        private readonly MainForm _myParent;

        public NewBookForm(IDatabase database, MainForm myParent)
        {
            InitializeComponent();
            _database = database;
            _myParent = myParent;
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            var book = new Book();
            //input validation
            double p;
            if (!double.TryParse(priceTB.Text, out p))
            {
                MessageBox.Show("Price must be a positive real number.");
                return;
            }
            book.Price = p;
            if(p <= 0)
            {
                MessageBox.Show("Price must be a positive real number.");
                return;
            }
            if(titleTB.Text.Trim() == "" || authorTB.Text.Trim() == "")
            {
                MessageBox.Show("Author/title can't be empty.");
                return;
            }
            book.Title = titleTB.Text;
            book.Author = authorTB.Text;
            //submit
            _database.AddBook(book);
            _myParent.RefreshAllData();
            this.Close();
        }
    }
}
