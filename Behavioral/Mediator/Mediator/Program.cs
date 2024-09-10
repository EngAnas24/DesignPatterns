using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public interface  IChatroomMediator
    {
        void SendMessage(string message, User user);
        void RegisterUser(User user);

    }
    public class Chatroom : IChatroomMediator
    {
        public List<User> Users = new List<User>();
        public void RegisterUser(User user)
        {
            Users.Add(user);
        }

        public void SendMessage(string message, User user)
        {
         foreach(var u in Users)
            {
              if(user != u)
                {
                    u.Receive(message);
                }
            }
        }
    }

    public class User
    {
        public string Name;
        private  IChatroomMediator chatroom;

        public User(string name, IChatroomMediator chatroom)
        {
            Name = name;
            this.chatroom = chatroom;
        }
        public void Send(string message)
        {
            Console.WriteLine($"{Name} sends: {message}");
            chatroom.SendMessage(message, this);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"{Name} receives: {message}");
        }
    }

        internal class Program
    {
        static void Main(string[] args)
        {
            IChatroomMediator chatroom = new Chatroom();
            User user1 = new User("Anas",chatroom);
            User user2 = new User("Ahmed", chatroom);

            chatroom.RegisterUser(user1);
            chatroom.RegisterUser(user2);

            user1.Send("Hello, everyone!");
            user2.Send("Hi, Anas!");

            Console.ReadKey();

        }
    }
}
