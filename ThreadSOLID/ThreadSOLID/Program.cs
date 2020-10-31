using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadSOLID
{
    class Program
    {
        #region Custom delegates
        public delegate bool CustomPredicate<T>(T val);
        public delegate void CustomAction<T, U>(T v1, U v2);
        public delegate R CustomFunc<T, U, R>(T v1, U v2, out R r);
        #endregion

        static void Main(string[] args)
        {
            #region Thread
            //Thread first = new Thread(new ThreadStart(First));
            //Thread second = new Thread(Second);
            //first.Start();
            //second.Start();
            ////first.Join();

            ////First();
            ////Second();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Main {Thread.CurrentThread.ManagedThreadId}");
            //}
            #endregion

            #region SOLID
            #region Single Responsibility

            #endregion

            #region Open/Close

            #endregion

            #region Liskov substitution
            //Apple fruit = new Orange();
            Fruit apple = new Apple();
            Fruit orange = new Orange();
            #endregion

            #region Dependency Inversion
            //Customer customer = new Customer();
            //Product product = new Product();
            Service service = new Service();
            service.customer.GetCustomerData();
            service.product.GetProductData();
            #endregion
            #endregion
        }

        #region SOLID
        #region Single Responsibility
        class Student
        {
            public string Fullname { get; set; }
            public void GetInfo()
            {
                Console.WriteLine(Fullname);
            }

            
        }

        class Group
        {
            public string Groupname { get; set; }
            public int MaxGroupCount { get; set; }
            public void GetGroupInfo()
            {
                Console.WriteLine($"{Groupname} {MaxGroupCount}");
            }
        }
        #endregion

        #region Open/Close
        class Invoice
        {
            public virtual void GetAmuont()
            {
                Console.WriteLine("30% discount");
            }
        }

        class FinalIvaice: Invoice
        {
            public override void GetAmuont()
            {
                Console.WriteLine("50% discount");
            }
        }

        class ChangedInvoice:Invoice
        {
            public override void GetAmuont()
            {
                Console.WriteLine("40% discount");
            }
        }
        #endregion

        #region Liskov substitution
        abstract class Fruit
        {
            public abstract void Tasty();
        }
        class Apple: Fruit
        {

            public override void Tasty()
            {
                Console.WriteLine("as Apple");
            }
        }

        class Orange : Fruit
        {
            public override void Tasty()
            {
                Console.WriteLine("as Orange");
            }
        }
        #endregion

        #region Interface segregation
        interface ISum
        {
            void Sum(int n1, int n2);
            
        }

        interface IDifference
        {
            void Difference(int n1, int n2);
        }

        interface ICompare
        {
            void Compare(int n1, int n2);
        }

        class Calculate : ISum,ICompare,IDifference
        {
            public void Compare(int n1, int n2)
            {
                Console.WriteLine(n1>n2);
            }

            public void Difference(int n1, int n2)
            {
                Console.WriteLine(n1-n2);
            }

            public void Sum(int n1, int n2)
            {
                Console.WriteLine(n1+n2);
            }
        }

        class Test : ISum
        {
            public void Sum(int n1, int n2)
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Dependency Inversion
        interface IDatabase
        {
            void GetData(string str);
        }
        class Database : IDatabase
        {
            public void GetData(string str)
            {
                Console.WriteLine(str);
            }
        }

        class Customer
        {
            private readonly IDatabase _db;
            public Customer(IDatabase db)
            {
                _db = db;
            }

            public void GetCustomerData()
            {
                _db.GetData("Customer data");
            }
        }

        class Product
        {
            private readonly IDatabase _db;
            public Product(IDatabase db)
            {
                _db = db;
            }

            public void GetProductData()
            {
                _db.GetData("Product data");
            }
        }

        class Service
        {
            public readonly Customer customer;
            public readonly Product product;
            public Service()
            {
                Database db = new Database();
                customer = new Customer(db);
                product = new Product(db);

            }
        }

        #endregion
        #endregion

        #region MyRegion
        //static void First()
        //{
        //    for (int i = 0; i < 20; i++)
        //    {
        //        Thread.Sleep(500);
        //        Console.WriteLine($"First {i} Thread {Thread.CurrentThread.ManagedThreadId}");
        //    }
        //}

        //static void Second()
        //{
        //    for (int i = 0; i < 20; i++)
        //    {
        //        Thread.Sleep(1000);
        //        Console.WriteLine($"Second {i} Thread {Thread.CurrentThread.ManagedThreadId}");
        //    }
        //}
        #endregion

    }
}
