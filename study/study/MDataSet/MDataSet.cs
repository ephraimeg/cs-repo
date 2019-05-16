using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTL.MDataSet
{
    public class MDataSet
    {
        public void Main()
        {
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
                    foreach (DataRow detailRow in orderRow.GetChildRows(customerOrders.Relations["OrderDetail"]))
                    {
                        Console.WriteLine($"     Product: {detailRow.GetParentRow(orderProductRelation)["ProductName"]}");
                        Console.WriteLine($"     Quantity: {detailRow["OrderQuantity"]}");
                    }
                }
            }

            DataTable dataTable = new DataTable("MyDataTable");
            dataTable.Columns.Add("Column1", typeof(string));

            DataRow dataRow = dataTable.NewRow();
            dataRow["Column1"] = "Takoyaki";
            dataTable.Rows.Add(dataRow);

            dataRow.BeginEdit();
            // Edit data but keep the same value.
            dataRow[0] = "Takoyaki";
            // Uncomment the following line to add a new value.
            // dataRow[0] = "Mochi";
            Console.WriteLine(string.Format("\nFood {0}\n", dataRow[0]));

            // Compare the proposed version with the current.
            if (dataRow.HasVersion(DataRowVersion.Proposed))
            {
                if (object.ReferenceEquals(dataRow[0, DataRowVersion.Current], dataRow[0, DataRowVersion.Proposed]))
                {
                    Console.WriteLine("The original and the proposed are the same.");
                    dataRow.CancelEdit();
                }
                else
                {
                    dataRow.AcceptChanges();
                    Console.WriteLine("The original and the proposed are different.");
                }
            }

            Console.ReadKey();
        }
    }
}
