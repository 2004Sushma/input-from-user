using System;

class NewsAgency
{
    public delegate void NewsHandler(string news);
    public event NewsHandler PublishNews;

    public void Publish(string news)
    {
        PublishNews?.Invoke(news);
    }
}

class Reader
{
    public void ReceiveNews(string news)
    {
        Console.WriteLine("Received: " + news);
    }
}

class Program
{
    static void Main()
    {
        NewsAgency agency = new NewsAgency();
        Reader r1 = new Reader();
        Reader r2 = new Reader();

        agency.PublishNews += r1.ReceiveNews;
        agency.PublishNews += r2.ReceiveNews;

        agency.Publish("New update released!");
    }
}
