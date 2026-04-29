using System;
using System.Collections.Generic;

namespace ECommerceApp
{
    public interface IObserver
    {
        void Update(string message);
    }

    public interface ISubject
    {
        void Attach(IObserver observer);
        void Notify(string message);
    }

    public class OrderNotifier : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify(string message)
        {
            foreach (var obs in observers)
            {
                obs.Update(message);
            }
        }
    }

    public class Customer : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Customer Notification: " + message);
        }
    }
}