using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace ADONet
{
    public partial class Form1 : Form
    {
        CustomerDal customerdal = new CustomerDal();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<Customer> customers = new List<Customer>();
            //customers = customerdal.GetAll();
            _GetAll();

        }

        public void _GetAll()
        {
            dgwCustomer.DataSource = customerdal.GetAll();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Customer customer1 = new Customer
            {
                ID =Convert.ToInt32(txtUpId.Text),
                Name = txtUpName.Text,
                LastName = txtUpLast.Text,
                Number =Convert.ToInt32(txtUpNum.Text)
            };

            customerdal._Update(customer1);
            _GetAll();
        }
        private void btnAdd_click(object sender,EventArgs e)
        {
            Customer customer2 = new Customer
            {
                Name = txtAddName.Text,
                LastName = txtAddLast.Text,
                Number = Convert.ToInt32(txtAddNum.Text)
            };

            customerdal._Insert(customer2);
            _GetAll();
        }

        private void btnDelete_click(object sender,EventArgs e)
        {
            int _id = Convert.ToInt32(txtUpId.Text);
            customerdal._Delete(_id);
            _GetAll();

        }
    }
}
