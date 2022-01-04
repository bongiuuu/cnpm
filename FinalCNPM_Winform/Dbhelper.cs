using FinalCNPM_Winform.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCNPM_Winform
{
    class Dbhelper
    {
        private CnpmDb context = null;
        public Dbhelper()
        {
            context = new CnpmDb();
        }

        public List<Order> GetAllDeliveryAgents()
        {
            var response = context.Database.SqlQuery<Order>("GetAllAgentOrders").ToList();
            return response;
        }

        public List<OrderDetail> getProductsFromOrderNote(int orderNoteId)
        {
            object[] sqlParam =
             {
                new SqlParameter("@OrderNoteId", orderNoteId),
            };

            var response = context.Database.SqlQuery<OrderDetail>("SelectProductsFromOrderNotes @OrderNoteId", sqlParam).ToList();
            return response;
        }

        /*public List<DeliveryProduct> GetOrderDetails()
        {
            var response = context.Database.SqlQuery<DeliveryProduct>("GetOrderDetails").ToList();
            return response;
        }*/

        public void createDeliveryNote(DateTime createTime, string status, string paymentMethod, string paymentStatus, decimal totalPrice, int orderId)
        {
            object[] sqlParam =
            {
                new SqlParameter("@createTime", createTime),
                new SqlParameter("@totalPrice", totalPrice),
                new SqlParameter("@orderId", orderId)
            };
            var response = context.Database.ExecuteSqlCommandAsync("CreateDeliveryANote @createTime, @totalPrice, @orderId", sqlParam);
            response.Wait();
        }

        public void updateOrderStatus(int @orderId)
        {
            // Convert Cho xac nhan to Dang giao - OrderId UpdateOrderStatus
            object[] sqlParam =
          {
                new SqlParameter("@id", @orderId)
       
            };
            var response = context.Database.ExecuteSqlCommandAsync("UpdateOrderStatus @id", sqlParam);
            response.Wait();

        }
        
        public List<Product> getAllProducts()
        {
            var response = context.Database.SqlQuery<Product>("SelecAllProducts").ToList();
            return response;
        }

        public Product getProductFromId(int @productId)
        {

            object[] sqlParam =
      {
                new SqlParameter("@productId", @productId)

            };
            var response = context.Database.SqlQuery<Product>("SelecProductFromId @productId", sqlParam).SingleOrDefault();
            return response;
        }
        

             public void updateProductQuantity(int @productId, int @quantity)
        {

            object[] sqlParam =
      {
                new SqlParameter("@productId", @productId),
                new SqlParameter("@quantity", @quantity)

            };
            var response = context.Database.ExecuteSqlCommandAsync("UpdateProductQuantity @productId, @quantity", sqlParam);
            response.Wait();
          
        }

        public List<DeliveryNote> getDeliveryNoteFromMonth(DateTime @fromDate, DateTime @toDate)
        {

            object[] sqlParam =
      {
                new SqlParameter("@fromDate", @fromDate),
                new SqlParameter("@toDate", @toDate)

            };
            var response = context.Database.SqlQuery<DeliveryNote>("GETDELIVERYNOTEFROMMONTH @fromDate, @toDate", sqlParam).ToList();
            return response;
        }
    }
}
