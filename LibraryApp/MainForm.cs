using LibraryApp.Models;
using LibraryApp.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class MainForm : Form
    {
        public User CurrUser { get; set; }
        public List<Book> Books { get; set; }
        public List<Order> Orders { get; set; }
        public List<Request> Requests { get; set; }
        private readonly IDatabase _database;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(User currUser, IDatabase database)
        {
            InitializeComponent();
            CurrUser = currUser;
            _database = database;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            WindowMovingClass.MouseControl(this.Handle);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Books = _database.GetBooks();
            GuiHelpers.RefreshBooksPanel(Books, booksPanelListView);
            Requests = _database.GetRequests();
            GuiHelpers.RefreshRequestsPanel(Requests, requestsPanelListView);
            GuiHelpers.MakePanelActive(booksPanel, ordersPanel, requestsPanel);
            GuiHelpers.MakeBtnActive(booksPanelBtn, ordersPanelBtn, requestsPanelBtn);
            if (CurrUser.IsAdmin)
            {
                userInfoLabel.Text = "Welcome, Admin " + CurrUser.Username;
                addBookBtn.Visible = true;
                delRequestBtn.Visible = true;
                Orders = _database.GetOrders();
                GuiHelpers.RefreshOrdersPanel(Orders, ordersPanelListView);
                ordersPanelBtn.Text = "     All Orders";
            }
            else
            {
                userInfoLabel.Text = "Welcome, " + CurrUser.Username;
                Orders = _database.GetOrdersByUsername(CurrUser.Username);
                GuiHelpers.RefreshOrdersPanel(Orders, ordersPanelListView);
                ordersPanelListView.Columns[1].Width = 0;
                ordersPanelBtn.Text = "     My Orders";
            }
        }

        private void orderBooksBtn_Click(object sender, EventArgs e)
        {
            var ids = new List<int>();
            double total = 0;
            for (int i = 0; i < booksPanelListView.SelectedItems.Count; i++)
            {
                int id = int.Parse(booksPanelListView.SelectedItems[i].SubItems[0].Text);
                ids.Add(id);
                total += double.Parse(booksPanelListView.SelectedItems[i].SubItems[3].Text);
            }
            if(ids.Count == 0)
            {
                MessageBox.Show("No books selected");
                return;
            }
            if (_database.OrderBooks(CurrUser, ids, total))
            {
                MessageBox.Show("Order successful\n\nTotal cost: " + total.ToString() +
                    "\n\nPlease bring the printed receipt to the cashier.\nThank you.");
                RefreshAllData();
            }
            else
            {
                MessageBox.Show("Order failed. Please try again later.");
            }
        }

        private void booksPanelBtn_Click(object sender, EventArgs e)
        {
            GuiHelpers.MakeBtnActive(booksPanelBtn, ordersPanelBtn, requestsPanelBtn);
            GuiHelpers.MakePanelActive(booksPanel, ordersPanel, requestsPanel);
        }

        private void ordersPanelBtn_Click(object sender, EventArgs e)
        {
            GuiHelpers.MakeBtnActive(ordersPanelBtn, booksPanelBtn, requestsPanelBtn);
            GuiHelpers.MakePanelActive(ordersPanel, booksPanel, requestsPanel);
        }

        private void requestsPanelBtn_Click(object sender, EventArgs e)
        {
            GuiHelpers.MakeBtnActive(requestsPanelBtn, booksPanelBtn, ordersPanelBtn);
            GuiHelpers.MakePanelActive(requestsPanel, booksPanel, ordersPanel);
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            var nbf = new NewBookForm(_database, this);
            nbf.ShowDialog();
        }
        public void RefreshAllData()
        {
            if (CurrUser.IsAdmin)
            {
                Orders = _database.GetOrders();
                GuiHelpers.RefreshOrdersPanel(Orders, ordersPanelListView);
            }
            else
            {
                Orders = _database.GetOrdersByUsername(CurrUser.Username);
                GuiHelpers.RefreshOrdersPanel(Orders, ordersPanelListView);
            }
            Books = _database.GetBooks();
            GuiHelpers.RefreshBooksPanel(Books, booksPanelListView);
            Requests = _database.GetRequests();
            GuiHelpers.RefreshRequestsPanel(Requests, requestsPanelListView);
        }

        private void delRequestBtn_Click(object sender, EventArgs e)
        {
            var selectedItems = requestsPanelListView.SelectedItems;
            if (selectedItems.Count == 0)
            {
                MessageBox.Show("Please select some items.");
            }
            foreach(ListViewItem item in selectedItems)
            {
                int id = int.Parse(item.SubItems[0].Text);
                _database.DeleteRequest(id);
            }
            RefreshAllData();
        }

        private void requestBtn_Click(object sender, EventArgs e)
        {
            var nrf = new NewRequestForm(_database, this);
            nrf.ShowDialog();
        }

        private void viewOrderBtn_Click(object sender, EventArgs e)
        {
            if(ordersPanelListView.SelectedItems.Count > 1)
            {
                MessageBox.Show("Please select only one order to view the details of.");
                return;
            }
            if(ordersPanelListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an order.");
                return;
            }
            int id = int.Parse(ordersPanelListView.SelectedItems[0].SubItems[0].Text);
            List<Book> orderBooks = _database.GetOrderDetails(id);
            var odf = new OrderDetailsForm(orderBooks);
            odf.ShowDialog();
        }
    }
}
