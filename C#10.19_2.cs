using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore_Reader
{
    enum Domain { Computer, Economics, Literature, Sport }
    delegate void BookHandler(BookStore sender, Domain dom, String book);

    class BookStore
    {
        private string _name;
        //private List<Customer> cl = new List<Customer>();
        public   BookHandler OnNewBook;

        public string Name
        {
            get { return _name; }
        }
        /*
        public List<Customer> GetCustomerList()
        {
            return cl;
        }*/
        public BookStore(string name)
        {
            _name = name;

        } 
        //通知函数
        public void NewBook(Domain dom, string book)
        {
            /*
           foreach(Customer ct in this.cl)
           {
               ct.store_OnNewBook(this, dom, book);
           }*/
            OnNewBook(this, dom, book);
      
        }
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
        private void store_OnNewBook(BookStore store, Domain dom, string book)
        {
            if (dom == _dom)
            {
                Console.WriteLine("{0}知道{1}书店新到《{2}》", _name, store.Name, book);
                Console.WriteLine();
            }
        }
        //客户注册
        public void Register(BookStore store)
        {
            /*
            List<Customer> cl = store.GetCustomerList();
            cl.Add(this);
             * */
            store.OnNewBook += this.store_OnNewBook;
        } 
        //取消客户注册
        public void Unregister(BookStore store)      
        {
            //待写
            store.OnNewBook -= this.store_OnNewBook;
        }
        class Program
        {
            static void Main(string[] args)
            {
                BookStore store1 = new BookStore("中关村");
                BookStore store2 = new BookStore("中山路");
                Customer[] cs = new Customer[] {
                    　　　　　　　　　　　　　　new Customer("王晓明", Domain.Computer),
                    　　　　　　　　　　　　　　new Customer("赵丽", Domain.Computer), 
                                  　　　　　　　new Customer("张珊", Domain.Literature) 
               　　　　　　　　　　　　　　　};
                 　
                foreach (Customer c in cs)
                {
                    c.Register(store1);
                    c.Register(store2);
                }
                store1.NewBook(Domain.Computer, "C#程序设计");
                store2.NewBook(Domain.Literature, "唐诗三百首");
                Console.WriteLine("**************************************");
                cs[0].Unregister(store2);
                store2.NewBook(Domain.Computer, "数据结构与算法");

                Console.ReadKey();
            }
        }
    }
}
