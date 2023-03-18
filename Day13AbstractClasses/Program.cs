using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13AbstractClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
    abstract class Book
    {

        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();


    }
    class MyBook : Book
    {

        public int price;
        public MyBook(String _title, String _author, int _price) : base(_title, _author)
        {

            this.price = _price;
        }

        public override void display()
        {
            Console.WriteLine("Title: {0}\nAuthor: {1}\nPrice: {2}", title, author, price);
        }
    }
}
