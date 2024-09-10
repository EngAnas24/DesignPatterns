using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    using System;
    using System.Collections.Generic;

    // Subject
    public class Product
    {
        private List<IObserver> _observers = new List<IObserver>();
        private decimal _price;

        public decimal Price
        {
            get { return _price; }
            set
            {
                _price = value;
                NotifyObservers();  // Notify observers whenever the price changes
            }
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_price);  // Notify each observer about the price change
            }
        }
    }

    // Observer Interface
    public interface IObserver
    {
        void Update(decimal price);
    }

    // Concrete Observer
    public class Customer : IObserver
    {
        private string _name;

        public Customer(string name)
        {
            _name = name;
        }

        public void Update(decimal price)
        {
            Console.WriteLine($"{_name} has been notified of new price: {price:C}");
        }
    }

    // Client Code
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product();

            var customer1 = new Customer("Alice");
            var customer2 = new Customer("Bob");

            // Attach observers
            product.Attach(customer1);
            product.Attach(customer2);

            // Change product price, which will notify all observers
            product.Price = 19.99m;  // سيطبع إشعارات للعملاء

            // Detach an observer
            product.Detach(customer1);

            // Change product price again, which will notify remaining observers
            product.Price = 29.99m;  // سيطبع إشعارًا للعميل المتبقي فقط

            Console.ReadKey ();
        }
    }

}
