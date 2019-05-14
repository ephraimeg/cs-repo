using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace GTL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region ArrayList List
            ////Application.EnableVisualStyles();
            ////Application.SetCompatibleTextRenderingDefault(false);

            ////FormView view = new FormView();
            ////IList list = new ArrayList();
            ////FormController controller = new FormController(view, list);
            ////Application.Run(view);

            //ArrayList _list = new ArrayList();
            //_list.Add(new Student("Yeji", "Hwang", new DateTime(2000,5,26)));
            //_list.Add(new Person("Jisu", "Choi", new DateTime(2000,7,21)));
            //_list.Add(new Student("Ryujin", "Shin", new DateTime(2001,4,17)));
            //_list.Add(new Person("Chaeryeong", "Lee", new DateTime(2001, 6, 5)));
            //_list.Add(new Person("Yuna", "Shin", new DateTime(2003, 12, 9)));

            //foreach (Person p in _list)
            //{
            //    Console.WriteLine($"{p.ToString()}\n");
            //}

            //List<Person> _plist = new List<Person>();
            //_plist.Add(new Employee(new Person("Karl", "Noval", new DateTime(1993, 6, 6)), "Ateneo de Cebu", new DateTime(2019, 4, 22)));
            //_plist.Add(new Employee(new Person("Lea", "Mijares", new DateTime(1998, 10, 21)), "Ateneo de Cebu", new DateTime(2019, 4, 22)));
            //_plist.Add(new Person("Donna", "Yue", new DateTime(1990, 1, 30)));
            //_plist.Add(new Student("Ram", "Alarcon", new DateTime(2003, 12, 5)));

            //foreach (Person p in _plist)
            //{
            //    Console.WriteLine($"{p.ToString()}\n");
            //}

            //Console.WriteLine(_list.IsReadOnly);

            //// initializing a read only arraylist
            //ArrayList _mlist = ArrayList.ReadOnly(_list);

            //// initializing a read only List (any read only Generic)
            //ReadOnlyCollection<Person> _xlist = _plist.AsReadOnly();

            //foreach(Person p in _mlist)
            //{
            //    if (p is Student)
            //    {
            //        try
            //        {
            //            _mlist.Remove(p);
            //        }catch(Exception e)
            //        {
            //            Console.WriteLine(e.Message);
            //        }
            //    }else
            //    {
            //        Console.WriteLine($"{p.ToString()}\n");
            //    }
            //}

            //Console.WriteLine($"{_mlist.Count}\n");

            #endregion

            #region LINQ

            //int[] scores = new int[] { 97, 92, 82, 60 };

            //IEnumerable<int> scoreQuery = from score in scores where score > 80 select score;

            //foreach(int i in scoreQuery)
            //{
            //    Console.Write(i + " ");
            //}

            #endregion

            DataSet customerOrders = new DataSet("CustomerOrders");

            DataTable customersTable = customerOrders.Tables.Add("Customers");
            DataTable productsTable = customerOrders.Tables.Add("Products");
            DataTable ordersTable = customerOrders.Tables.Add("Orders");
            DataTable orderDetailsTable = customerOrders.Tables.Add("OrderDetails");

            DataColumn pkCustID = customersTable.Columns.Add("CustomerID", typeof(string));
            customersTable.PrimaryKey = new DataColumn[] { pkCustID };

            DataColumn pkProdID = productsTable.Columns.Add("ProductID", typeof(Int32));
            productsTable.Columns.Add("ProductName", typeof(string));
            productsTable.PrimaryKey = new DataColumn[] { pkProdID };

            DataColumn pkOrderID = ordersTable.Columns.Add("OrderID", typeof(Int32));
            ordersTable.Columns.Add("CompanyName", typeof(string));
            ordersTable.Columns.Add("CustomerID", typeof(string));
            ordersTable.Columns.Add("OrderDate", typeof(DateTime));
            ordersTable.PrimaryKey = new DataColumn[] { pkOrderID };

            DataColumn pkOrderDetails = orderDetailsTable.Columns.Add("OrderID", typeof(Int32));
            DataColumn fkOrderDetails = orderDetailsTable.Columns.Add("ProductID", typeof(Int32));
            orderDetailsTable.Columns.Add("OrderQuantity", typeof(Int32));
            orderDetailsTable.PrimaryKey = new DataColumn[] { pkOrderDetails, fkOrderDetails };

            DataRelation customerOrdersRelation = 
                customerOrders.Relations.Add("CustOrders",
                customerOrders.Tables["Customers"].Columns["CustomerID"],
                customerOrders.Tables["Orders"].Columns["CustomerID"]);

            DataRelation orderDetailRelation =
                customerOrders.Relations.Add("OrderDetail",
                customerOrders.Tables["Orders"].Columns["OrderID"],
                customerOrders.Tables["OrderDetails"].Columns["OrderID"], false);

            DataRelation orderProductRelation =
                customerOrders.Relations.Add("OrderProducts",
                customerOrders.Tables["Products"].Columns["ProductID"],
                customerOrders.Tables["OrderDetails"].Columns["ProductID"]);

            customersTable.Rows.Add("NORTS");
            productsTable.Rows.Add(1, "Filo Mix");
            productsTable.Rows.Add(2, "Outback Lager");
            productsTable.Rows.Add(3, "Raclette Courdavau");
            ordersTable.Rows.Add(10517, "Acme", "NORTS", new DateTime(1997, 4, 24));
            ordersTable.Rows.Add(11057, "Acme", "NORTS", new DateTime(1997, 4, 29));
            orderDetailsTable.Rows.Add(10517, 1, 6);
            orderDetailsTable.Rows.Add(10517, 3, 4);
            orderDetailsTable.Rows.Add(10517, 2, 6);
            orderDetailsTable.Rows.Add(11057, 2, 3);

            foreach (DataRow custRow in customerOrders.Tables["Customers"].Rows)
            {
                //Console.WriteLine(custRow["CustomerID"].ToString());
                Console.WriteLine($"Customer ID: {custRow["CustomerID"]}");
                foreach (DataRow orderRow in custRow.GetChildRows(customerOrdersRelation))
                {
                    //Console.WriteLine(orderRow["OrderID"].ToString());
                    Console.WriteLine($"   Order ID: {orderRow["OrderID"]}");
                    Console.WriteLine($"   Order Date: {orderRow["OrderDate"]}");
                    foreach(DataRow detailRow in orderRow.GetChildRows(customerOrders.Relations["OrderDetail"]))
                    {
                        Console.WriteLine($"     Product: {detailRow.GetParentRow(orderProductRelation)["ProductName"]}");
                        Console.WriteLine($"     Quantity: {detailRow["OrderQuantity"]}");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
