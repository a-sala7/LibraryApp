using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Services
{
    public static class RandomOrderGenerator
    {
        public static void GenerateOrders(int numOrders, IDatabase database)
        {
            var users = database.GetUsers();
            var books = database.GetBooks();

            User user;
            List<int> bookIds = new List<int>();

            Random r = new Random();

            for (int i = 0; i < numOrders; i++)
            {
                double total = 0;
                bookIds.Clear();
                
                user = users[r.Next(users.Count-1)];
                int numBooks = r.Next(1,5);

                for(int j = 0; j < numBooks; j++)
                {
                    var bookObj = books[r.Next(books.Count-1)];
                    bookIds.Add(bookObj.Id);
                    total += bookObj.Price;
                }
                database.OrderBooks(user, bookIds, total);
            }
        }
    }
}
