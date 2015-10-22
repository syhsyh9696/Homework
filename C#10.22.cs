using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BookStore store1 = new BookStore("中关村");
            BookStore store2 = new BookStore("中山路");

            Customer[] cs = new Customer[] { new Customer("王晓明", Domain.Computer), new Customer("赵丽", Domain.Computer), new Customer("张珊", Domain.Literature) };
            foreach (Customer c in cs)
            {
                c.Register(store1);
                c.Register(store2);
            }
            store1.NewBook(Domain.Computer, "C#程序设计");
            store2.NewBook(Domain.Literature, "唐诗三百首");
            Console.WriteLine("************");
            cs[0].Unregister(store2);
            store2.NewBook(Domain.Computer, "数据结构与算法");
        }
     }
    
    enum Domain { Computer, Economics, Literature, Sport }

    class BookStore
    {   
        private string _name;
        public event EventHandler OnNewBook;  //定义事件成员

        public string Name
        {
            get { return _name; }
        }

        public BookStore(string name)
        {
            _name = name;
        }

        public void NewBook(Domain dom, string book)  //引发事件的方法成员
        {
            OnNewBook(this, new BookEventArgs() { Dom = dom, Book = book});
        }
    }
    class BookEventArgs : EventArgs
    {
        internal Domain Dom { get; set; }
        internal string Book { get; set; }
    }
    class Customer
    {
        private string _name;
        private Domain _dom;
        
        public Customer(string name, Domain dom)
        {
            _name = name;
            _dom = dom;
        }
        void store_OnNewBook(object sender, EventArgs e)//时间处理方法
        {
            BookStore store = sender as BookStore;
            BookEventArgs be = e as BookEventArgs;
            if(store != null && be != null && be.Dom == _dom)           
                Console.WriteLine("{0}您好：{1}店新到图书《{2}》", _name, store.Name, be.Book);
        }
        public void Register(BookStore store)
        {
            store.OnNewBook += store_OnNewBook;  //订阅事件
        }
        public void Unregister(BookStore store)                  //取消订阅事件
        {
            store.OnNewBook -= new EventHandler(store_OnNewBook);
        }     
    }
}
