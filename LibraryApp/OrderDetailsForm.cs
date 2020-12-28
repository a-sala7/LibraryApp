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
    public partial class OrderDetailsForm : Form
    {
        private readonly List<Book> _books;
        public OrderDetailsForm(List<Book> books)
        {
            InitializeComponent();
            _books = books;

            GuiHelpers.RefreshBooksPanel(_books, listView1);
            double total = books.Sum(b => b.Price);
            orderTotalLabel.Text = "Order Total: " + total.ToString();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
