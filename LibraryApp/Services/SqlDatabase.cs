using System;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using LibraryApp.Models;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Services
{
    public class SqlDatabase : IDatabase
    {
        private readonly string _conString;
        public SqlDatabase(string connectionString)
        {
            _conString = connectionString;
        }
        public void RegisterUser(User user)
        {
            using (SqlConnection con = new SqlConnection(_conString))
            {
                string query = "INSERT INTO Users VALUES(@u, @p, 0)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@u", user.Username);
                    cmd.Parameters.AddWithValue("@p", user.Password);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public User GetUser(string username)
        {
            using (SqlConnection con = new SqlConnection(_conString))
            {
                string query = "SELECT * FROM Users WHERE Username = @u";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return null;
                        try
                        {
                            var userInDb = new User(reader[0].ToString(), reader[1].ToString(), bool.Parse(reader[2].ToString()));
                            return userInDb;
                        }
                        catch (Exception e)
                        {
                            Debug.WriteLine(e);
                        }
                    }
                }
            }
            return null;
        }
        public List<User> GetUsers()
        {
            var usersInDb = new List<User>();
            try
            {
                using (SqlConnection con = new SqlConnection(_conString))
                {
                    string query = "SELECT * FROM Users";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var user = new User();
                                user.Username = reader[0].ToString();
                                user.Password = reader[1].ToString();
                                user.IsAdmin = bool.Parse(reader[2].ToString());
                                usersInDb.Add(user);
                            }
                        }
                    }
                }
                return usersInDb;
            }
            catch(Exception e)
            {
                Debug.WriteLine(e);
            }
            return usersInDb;
        }

        public List<Book> GetBooks()
        {
            var booksInDb = new List<Book>();
            using (SqlConnection con = new SqlConnection(_conString))
            {
                string query = "SELECT * FROM Books ORDER BY Title";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                var currBook = new Book();
                                currBook.Id = int.Parse(reader[0].ToString());
                                currBook.Title = reader[1].ToString();
                                currBook.Author = reader[2].ToString();
                                currBook.Price = double.Parse(reader[3].ToString());
                                booksInDb.Add(currBook);
                            }
                            return booksInDb;
                        }
                        catch (Exception e)
                        {
                            Debug.WriteLine(e);
                        }
                    }
                }
            }
            return null;
        }

        public Book GetBook(int id)
        {
            using (SqlConnection con = new SqlConnection(_conString))
            {
                string query = "SELECT * FROM Books WHERE Id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return null;
                        try
                        {
                            var bookInDb = new Book();
                            bookInDb.Id = int.Parse(reader[0].ToString());
                            bookInDb.Title = reader[1].ToString();
                            bookInDb.Author = reader[2].ToString();
                            bookInDb.Price = double.Parse(reader[3].ToString());
                            return bookInDb;
                        }
                        catch (Exception e)
                        {
                            Debug.WriteLine(e);
                        }
                    }
                }
            }
            return null;
        }
        public void AddBook(Book book)
        {
            using (SqlConnection con = new SqlConnection(_conString))
            {
                string query = "INSERT INTO Books VALUES(@t, @a, @p)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@t", book.Title);
                    cmd.Parameters.AddWithValue("@a", book.Author);
                    cmd.Parameters.AddWithValue("@p", book.Price);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool OrderBooks(User user, List<int> ids, double total)
        {
            if(ids.Count == 0)
            {
                throw new ArgumentException("Can't order 0 books");
            }
            bool  orderSuccess = true;
            //OMG AFTER 3 HOURS IT FINALLY WORKS
            using (SqlConnection con = new SqlConnection(_conString))
            {
                con.Open();
                var tran = con.BeginTransaction();
                var cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.Transaction = tran;
                try
                {
                    cmd.CommandText = "INSERT INTO Orders VALUES (@u, @t);"
                        + "SELECT CAST(scope_identity() AS int)";
                    cmd.Parameters.AddWithValue("@u", user.Username);
                    cmd.Parameters.AddWithValue("@t", total);
                    
                    int lastOrderId = (Int32) cmd.ExecuteScalar();

                    foreach(var id in ids)
                    {
                        cmd.CommandText = "INSERT INTO BooksOrders VALUES(@lastId, @bookId)";
                        cmd.Parameters.AddWithValue("@lastId", lastOrderId);
                        cmd.Parameters.AddWithValue("@bookId", id);
                        cmd.ExecuteNonQuery();
                        /*Must clear parameters after each BookOrders insertion, else it throws
                         an exception about the parameters already being declared before*/
                        cmd.Parameters.Clear();
                    }
                    tran.Commit();
                }
                catch(Exception ex)
                {
                    orderSuccess = false;
                    try
                    {
                        tran.Rollback();
                    }
                    catch(Exception ex2)
                    {
                        Debug.WriteLine(ex2);
                    }
                    Debug.WriteLine(ex);
                }
            }
            return orderSuccess;
        }

        public List<Order> GetOrders()
        {
            var ordersInDb = new List<Order>();
            using (SqlConnection con = new SqlConnection(_conString))
            {
                string query = "SELECT * FROM Orders";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                var currOrder = new Order();
                                currOrder.Id = int.Parse(reader[0].ToString());
                                currOrder.Username = reader[1].ToString();
                                currOrder.Total = double.Parse(reader[2].ToString());
                                ordersInDb.Add(currOrder);
                            }
                            return ordersInDb;
                        }
                        catch (Exception e)
                        {
                            Debug.WriteLine(e);
                        }
                    }
                }
            }
            return null;
        }
        public List<Order> GetOrdersByUsername(string username)
        {
            var ordersInDb = new List<Order>();
            using (SqlConnection con = new SqlConnection(_conString))
            {
                string query = "SELECT * FROM Orders WHERE Username = @u";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@u", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                var currOrder = new Order();
                                currOrder.Id = int.Parse(reader[0].ToString());
                                currOrder.Username = reader[1].ToString();
                                currOrder.Total = double.Parse(reader[2].ToString());
                                ordersInDb.Add(currOrder);
                            }
                            return ordersInDb;
                        }
                        catch (Exception e)
                        {
                            Debug.WriteLine(e);
                        }
                    }
                }
            }
            return null;
        }

        public List<Book> GetOrderDetails(int orderId)
        {
            var booksInDb = new List<Book>();
            using (SqlConnection con = new SqlConnection(_conString))
            {
                string query = @"SELECT Books.Id, Title, Author, Price
                                FROM Books, BooksOrders
                                WHERE BooksOrders.OrderId = @orderId
                                AND Books.Id = BooksOrders.BookId
                                ORDER BY Price;";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("orderId", orderId);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                var currBook = new Book();
                                currBook.Id = int.Parse(reader[0].ToString());
                                currBook.Title = reader[1].ToString();
                                currBook.Author = reader[2].ToString();
                                currBook.Price = double.Parse(reader[3].ToString());
                                booksInDb.Add(currBook);
                            }
                            return booksInDb;
                        }
                        catch (Exception e)
                        {
                            Debug.WriteLine(e);
                        }
                    }
                }
            }
            return null;
        }

        public void AddRequest(Request request)
        {
            using (SqlConnection con = new SqlConnection(_conString))
            {
                string query = "INSERT INTO Requests VALUES(@t, @a)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@t", request.Title);
                    cmd.Parameters.AddWithValue("@a", request.Author);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteRequest(int id)
        {
            using (SqlConnection con = new SqlConnection(_conString))
            {
                string query = "DELETE FROM Requests WHERE Id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Request> GetRequests()
        {
            var requestsInDb = new List<Request>();
            using (SqlConnection con = new SqlConnection(_conString))
            {
                string query = "SELECT * FROM Requests ORDER BY Title";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                var currRequest = new Request();
                                currRequest.Id = int.Parse(reader[0].ToString());
                                currRequest.Title = reader[1].ToString();
                                currRequest.Author = reader[2].ToString();
                                requestsInDb.Add(currRequest);
                            }
                            return requestsInDb;
                        }
                        catch (Exception e)
                        {
                            Debug.WriteLine(e);
                        }
                    }
                }
            }
            return null;
        }
    }
}
