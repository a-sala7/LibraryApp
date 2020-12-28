using LibraryApp.Models;
using System.Collections.Generic;

namespace LibraryApp.Services
{
    public interface IDatabase
    {
        User GetUser(string username);
        List<User> GetUsers();
        void RegisterUser(User user);
        List<Book> GetBooks();
        Book GetBook(int id);
        void AddBook(Book book);
        bool OrderBooks(User user, List<int> ids, double total);
        List<Order> GetOrders();
        List<Order> GetOrdersByUsername(string username);
        List<Book> GetOrderDetails(int orderId);
        void AddRequest(Request request);
        void DeleteRequest(int id);
        List<Request> GetRequests();
    }
}
