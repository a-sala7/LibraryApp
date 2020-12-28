using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryApp.Services
{
    public static class GuiHelpers
    {
        public static ListViewItem GetBookAsListViewItem(Book book)
        {
            var i = new ListViewItem(book.Id.ToString());
            i.SubItems.Add(book.Title);
            i.SubItems.Add(book.Author);
            i.SubItems.Add(book.Price.ToString());
            return i;
        }
        public static void RefreshBooksPanel(List<Book> books, ListView listView)
        {
            listView.Items.Clear();
            foreach(var book in books)
            {
                listView.Items.Add(GetBookAsListViewItem(book));
            }
        }
        public static ListViewItem GetOrderAsListViewItem(Order order)
        {
            var i = new ListViewItem(order.Id.ToString());
            i.SubItems.Add(order.Username);
            i.SubItems.Add(order.Total.ToString());
            return i;
        }
        public static void RefreshOrdersPanel(List<Order> orders, ListView listView)
        {
            listView.Items.Clear();
            foreach (var order in orders)
            {
                listView.Items.Add(GetOrderAsListViewItem(order));
            }
        }
        public static ListViewItem GetRequestAsListViewItem(Request request)
        {
            var i = new ListViewItem(request.Id.ToString());
            i.SubItems.Add(request.Title);
            i.SubItems.Add(request.Author);
            return i;
        }
        public static void RefreshRequestsPanel(List<Request> requests, ListView listView)
        {
            listView.Items.Clear();
            foreach (var request in requests)
            {
                listView.Items.Add(GetRequestAsListViewItem(request));
            }
        }
        public static void MakeBtnActive(Button activeButton, params Button[] others)
        {
            activeButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            foreach(var otherBtn in others)
            {
                otherBtn.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        public static void MakePanelActive(Panel activePanel, params Panel[] others)
        {
            activePanel.Show();
            foreach(var other in others)
            {
                other.Hide();
            }
        }
    }
}
