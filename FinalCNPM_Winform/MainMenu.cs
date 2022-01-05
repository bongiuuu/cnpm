using FinalCNPM_Winform.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCNPM_Winform
{
    public partial class MainMenu : Form
    {

        List<Order> orderAgents = new List<Order>();
        List<OrderDetail> products = new List<OrderDetail>();
        List<Product> productsToUpdate = new List<Product>();
        int orderId2 = 0;
        int totalPrice = 0;
        int currentPosition = 0;
        int currentProductIdToUpdate = 0;
        string currentProductName = "";
        Product currentProduct = null;
        int currentMonth = 0;
        public MainMenu()
        {
            InitializeComponent();
            tabControl1.SelectedIndexChanged += new EventHandler(TabControl1_SelectedIndexChanged);
            listView1.MouseDown += new MouseEventHandler(listView_MouseDown);
            var dbHelper = new Dbhelper();
            orderAgents.Clear();
            listView1.Items.Clear();
            orderAgents = dbHelper.GetAllDeliveryAgents();
            setupHeader();

            getProducts();

      
        }

        private void setupHeader()
        {
            tbYear.Text = "2022";

            listView1.Columns.Add("Mã Đơn Hàng", 80);
            listView1.Columns.Add("Ngày Đặt Hàng", 180);
            listView1.Columns.Add("Tổng giá", 150);
            listView1.Columns.Add("Trạng Thái", 140);
            listView1.Columns.Add("Phương Thức TT", 140);
            listView1.Columns.Add("Tình Trạng TT", 140);

            listView2.Columns.Add("Mã Đơn Hàng", 100);
            listView2.Columns.Add("Tên Sản Phẩm", 410);
            listView2.Columns.Add("Số lượng", 100);
            listView2.Columns.Add("Giá", 100);
            listView2.Columns.Add("Tổng giá", 120);

            listView3.Columns.Add("Mã Đơn Hàng", 104);
            listView3.Columns.Add("Tên Sản Phẩm", 405);
            listView3.Columns.Add("Số lượng", 100);
            listView3.Columns.Add("Giá", 100);
            listView3.Columns.Add("Tổng giá", 120);

            listView5.Columns.Add("Mã ĐH", 60);
            listView5.Columns.Add("Mã SP", 60);
            listView5.Columns.Add("Tên Sản Phẩm", 300);
            listView5.Columns.Add("SL", 50);
            listView5.Columns.Add("Giá", 100);
            listView5.Columns.Add("Tổng giá", 120);
            listView5.Columns.Add("Ngày", 150);

            listView6.Columns.Add("Mã ĐH", 100);
            listView6.Columns.Add("Ngày", 300);
            listView6.Columns.Add("Tổng giá", 170);
        }

        private int totalOrderPrice(List<OrderDetail> orderDetails)
        {
            totalPrice = 0;
            for (int num = 0; num < orderDetails.Count; num++)
            {
                var orderDetail = orderDetails[num];
                var totalPriceItem = (int)(orderDetail.price * orderDetail.quantity);
                totalPrice = (int)(totalPrice + orderDetail.totalPrice);
            }
            return totalPrice;
        }

        private void LoadListView()
        {
            /*  var dbHelper = new Dbhelper();
              var orderAgents = dbHelper.GetAllDeliveryAgents();*/
       
            for (int num = 0; num < orderAgents.Count; num++)
            {
                var orderAgent = orderAgents[num];
                var orderDetailId = orderAgent.id;
                var dbHelper = new Dbhelper();
                var productList = dbHelper.getProductsFromOrderNote(orderDetailId);
                var totalPrice = totalOrderPrice(productList);

                listView1.Items.Add(new ListViewItem(new string[] { "" + orderAgent.id, orderAgent.createTime.ToString(), String.Format("{0:0,0}", totalPrice), orderAgent.status, orderAgent.paymentMethod, orderAgent.paymentStatus }));
            }
        }

        private void setupListView2(List<OrderDetail> orderDetails)
        {

            totalPrice = 0;
            for (int num = 0; num < orderDetails.Count; num++)
            {
                var orderDetail = orderDetails[num];
                var totalPriceItem = (int)( orderDetail.price*orderDetail.quantity);
                totalPrice = (int)(totalPrice + orderDetail.totalPrice);
                listView2.Items.Add(new ListViewItem(new string[] { orderId2.ToString(), orderDetail.name, orderDetail.quantity.ToString(), String.Format("{0:0,0}", orderDetail.price), String.Format("{0:0,0}", totalPriceItem) , orderDetail.status, orderDetail.paymentMethod, orderDetail.paymentStatus }));
            }
            this.label14.Text = "Tổng: " + String.Format("{0:0,0}", totalPrice) + " (VND)";

        }


        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)

        {


            if (tabControl1.SelectedTab.Text == "Xuất kho")
            {
                var dbHelper = new Dbhelper();
                orderAgents.Clear();
                listView1.Items.Clear();
                orderAgents = dbHelper.GetAllDeliveryAgents();
                listView1.Visible = true;
                LoadListView();
            }
            else
                listView1.Visible = false;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            // Save the selected employee's name, because we will remove
            // the employee's name from the list.
            string selectedEmployee = (string)cbbMonth.SelectedItem;

            int count = 0;
            
            int resultIndex = -1;

            // Call the FindStringExact method to find the first 
            // occurrence in the list.
            resultIndex = cbbMonth.FindStringExact(selectedEmployee);
            currentMonth = resultIndex + 1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

   

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbbDelivery_Receive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEmployee = (string)cbbDelivery_Receive.SelectedItem;

            int count = 0;

            int resultIndex = -1;

            // Call the FindStringExact method to find the first 
            // occurrence in the list.
            resultIndex = cbbDelivery_Receive.FindStringExact(selectedEmployee);
            listView5.Items.Clear();
            if (resultIndex == 0)
            {
                setupDeliveryListView();
            } else
            {
                setupReceiveListView();
            }


            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listView1.SelectedIndices[0];
            string s = listView1.Items[i].Text;
            MessageBox.Show(s);

            // 1. Get  Order id from orderAgents
            // 2. Create a procedure to get Order Detail 
            // 3. Get the Order Detail to show ( use functiuon from 2 )
            // 4. ...
          /*  var dbHelper = new Dbhelper();
            var products = dbHelper.getProductsFromOrderNote(1);
            setupListView2(products);*/


        }

        private void listView_MouseDown(object sender, MouseEventArgs e)
        {
            var info = listView1.HitTest(e.X, e.Y);
            var row = info.Item.Index;
            currentPosition = row;
            orderId2 = orderAgents[row].id;
            listView2.Items.Clear();
            var dbHelper = new Dbhelper();
 
            products = dbHelper.getProductsFromOrderNote(orderId2);
            if (products != null && products.Count > 0)
            {
  
                setupListView2(products);
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
       /* (DateTime createTime, string status, string paymentMethod, string paymentStatus, decimal totalPrice, int orderId)*/
        private void btnDelivery_Click(object sender, EventArgs e)
        {
            // 1. Insert into DeliveryNote 
            if(products.Count > 0)
            {
                var dbHelper = new Dbhelper();
                var firstOrderDetail = products[0];
                dbHelper.createDeliveryNote(DateTime.Now, firstOrderDetail.status, firstOrderDetail.paymentMethod, firstOrderDetail.paymentStatus, totalPrice, orderId2);
                MessageBox.Show("Đơn Xuất Kho Đã Được Tạo");
                listView1.Items.RemoveAt(currentPosition);

                dbHelper.updateOrderStatus(orderId2);
            }
        }

        private void cbbProductId_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            ComboBox comboBox = (ComboBox)sender;

            // Save the selected employee's name, because we will remove
            // the employee's name from the list.
            string selectedEmployee = (string)cbbProductId.SelectedItem;

            int count = 0;
            int resultIndex = -1;

            // Call the FindStringExact method to find the first 
            // occurrence in the list.
            resultIndex = cbbProductId.FindStringExact(selectedEmployee);

            currentProductIdToUpdate = resultIndex + 1;
            var dbHelper = new Dbhelper();
            currentProduct = dbHelper.getProductFromId(currentProductIdToUpdate);
            currentProductName = currentProduct.name;
            label4.Text = "Số lượng trong kho: " + currentProduct.quantity.ToString();

           /* MessageBox.Show("ID = " + product.quantity);*/
        }

        // Nhập kho
        private void getProducts()
        {
            // SelecAllProducts
            var dbHelper = new Dbhelper();
            var products = dbHelper.getAllProducts();
            for (int num = 0; num < products.Count; num++)
            {
                /*  setupListView3(products);*/
                var orderAgent = products[num];
                this.cbbProductId.Items.Add(orderAgent.name);
            }
        }
        private void setupListView3(List<Product> products)
        {
            listView3.Items.Clear();
            totalPrice = 0;
            for (int num = 0; num < products.Count; num++)
            {
                var orderAgent = products[num];
                var totalPriceItem = (int)(orderAgent.price * orderAgent.quantity);
                totalPrice = (int)(totalPrice + totalPriceItem);
                listView3.Items.Add(new ListViewItem(new string[] { "" + orderAgent.id, orderAgent.name, orderAgent.quantity.ToString(), String.Format("{0:0,0}", orderAgent.price), String.Format("{0:0,0}", totalPriceItem) }));
            
            }
            this.label15.Text = "Tổng: " + String.Format("{0:0,0}", totalPrice) + " (VND)";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbbProductId.SelectedIndex != -1 & !String.IsNullOrEmpty(tbQuantity.Text))
            {

                for (int i = 0; i < productsToUpdate.Count; i++)
                {
                    Product product = productsToUpdate[i];
                    if(product.name.Equals(currentProductName))
                    {
                        MessageBox.Show("Exist!");
                        return;
                    }
                }


                    int x;
                if (int.TryParse(tbQuantity.Text, out x) && x > 0)
                {
                    currentProduct.quantity = convertStringToInt(tbQuantity.Text);
                    currentProduct.id = currentProductIdToUpdate;
                    productsToUpdate.Add(currentProduct);
                    setupListView3(productsToUpdate);

                } else
                {
                    MessageBox.Show("Nhập lại số lượng!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < productsToUpdate.Count; i++)
            {
                if(productsToUpdate[i].name.Equals(currentProductName))
                {
                    productsToUpdate.RemoveAt(i);
                }
            }
            setupListView3(productsToUpdate);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var dbHelper = new Dbhelper();
            if (listView3.Items.Count != 0)
            {
                productsToUpdate.ForEach(product =>
                {
                    dbHelper.updateProductQuantity(product.id, product.quantity + convertStringToInt(label4.Text));
                });
                MessageBox.Show("Cập nhật thành công!");
            } else
            {
                MessageBox.Show("Chưa chọn sản phẩm để tạo đơn!");
            }
        }

        int convertStringToInt(String input)
        {

            int result = 0;
            try
            {
                result = Int32.Parse(input);

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var dbHelper = new Dbhelper();
            var endDate = 30;
            if(currentMonth == 2)
            {
                endDate = 28;
            }

            var fromDate = "2022/" + currentMonth.ToString() + "/01";
            var toDate = "2022/" + currentMonth.ToString() + "/"+ endDate;
            listView6.Items.Clear();
            var deliveryNotes = dbHelper.getDeliveryNoteFromMonth(fromDate, toDate);
            /*        MessageBox.Show((fromDate + " - " + toDate + " " + deliveryNotes.Count));
                    var test = 0;*/

            if(deliveryNotes == null || deliveryNotes.Count == 0)
            {
                MessageBox.Show("Dữ liệu trống!");
                label16.Text = "Tổng: 0";
                return;
            }

            var totalDeliveryNotePrice = 0;
            for (int num = 0; num < deliveryNotes.Count; num++)
            {
                var orderDetail = deliveryNotes[num];
                totalDeliveryNotePrice  = (int)(totalDeliveryNotePrice + orderDetail.totalPrice);
                listView6.Items.Add(new ListViewItem(new string[] { orderDetail.id.ToString(), orderDetail.createTime.ToString(),orderDetail.totalPrice.ToString() }));
            }

            label16.Text = "Tổng: " + totalDeliveryNotePrice.ToString() + " VND";
           
        }

        private void setupDeliveryListView()
        {
            var dbHelper = new Dbhelper();
            var orderPaid = dbHelper.GetAllDeliveryAgentsPaid();
            var orderDetails = new List<OrderDetail>();
            for (int num = 0; num < orderPaid.Count; num++)
            {
                var productFromOder = dbHelper.getProductsFromOrderNote(orderPaid[num].id);
                if(productFromOder != null)
                {
                    orderDetails.AddRange(productFromOder);
                }
            }

            for (int num = 0; num < orderDetails.Count; num++)
            {
                var orderDetail = orderDetails[num];
                var totalPriceItem = (int)(orderDetail.price * orderDetail.quantity);
                totalPrice = (int)(totalPrice + orderDetail.totalPrice);
                listView5.Items.Add(new ListViewItem(new string[] { orderDetail.orderId.ToString(), orderDetail.productId.ToString(), orderDetail.name, orderDetail.quantity.ToString(), String.Format("{0:0,0}", orderDetail.price), String.Format("{0:0,0}", totalPriceItem), orderDetail.createTime.ToString() }));
            }

        }

        private void setupReceiveListView()
        {
            var dbHelper = new Dbhelper();
            var receiveDetails = dbHelper.gelectAllReceiveNotes();
            var orderDetails = new List<ReceiveDetail>();
            for (int num = 0; num < receiveDetails.Count; num++)
            {
                var productFromOder = dbHelper.getProductsFromReceiveNote(receiveDetails[num].id);
                if (productFromOder != null)
                {
                    orderDetails.AddRange(productFromOder);
                }
            }

            for (int num = 0; num < orderDetails.Count; num++)
            {
                var orderDetail = orderDetails[num];
                var totalPriceItem = (int)(orderDetail.price * orderDetail.quantity);
                totalPrice = (int)(totalPrice + orderDetail.totalPrice);
                listView5.Items.Add(new ListViewItem(new string[] { orderDetail.receiveId.ToString(), orderDetail.productId.ToString(), orderDetail.name, orderDetail.quantity.ToString(), String.Format("{0:0,0}", orderDetail.price), String.Format("{0:0,0}", totalPriceItem), orderDetail.createTime.ToString() }));
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void tbYear_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
