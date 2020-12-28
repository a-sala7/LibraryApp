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
    public partial class NewRequestForm : Form
    {
        private readonly IDatabase _database;
        private readonly MainForm _parent;
        public NewRequestForm(IDatabase database, MainForm parent)
        {
            InitializeComponent();
            _database = database;
            _parent = parent;
        }

        private void submitRequestBtn_Click(object sender, EventArgs e)
        {
            if(titleTB.Text.Trim() == "" || authorTB.Text.Trim() == "")
            {
                MessageBox.Show("Text fields can't be empty");
                return;
            }

            var request = new Request();
            request.Title = titleTB.Text;
            request.Author = authorTB.Text;
            
            _database.AddRequest(request);

            _parent.RefreshAllData();

            this.Close();
        }
    }
}
