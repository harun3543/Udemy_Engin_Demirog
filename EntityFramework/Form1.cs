using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        CustomerDal _customerDal = new CustomerDal();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*MyAdoDatabaseContext nesnesi bellekte çok yer kapladğı için "using" parametresi kullanılır. Using işlemi class ın işi bittiğinde 
             context nesnesini bellekten hemen silinmesini sağlar. Normalde bu nesnenin silinmesi için Garbage Collage işlemini beklemek gerekirdi.
             using kullanılırsa bu işlemi beklemeden nesneyi bellekten hemen siler.
             
             Entity Framewrok projelerinde bir connection string vermemiz gerekir. Bu string  genelde konfigurasyon dosyasına yazılır. Context,
             veritabanı ile bağlantı kurmaya çalıştığında connection stirng değerini config dosyasından kendi ismi ile oluşturulmuş kısımdan alır.
             Böylece sürekli connection string yazmaya gerek kalmaz.
             Config dosyasının ismi "App.config" 'dir.
             */

            /************************************************************************************************/
            //using (MyAdoDatabaseContext context = new MyAdoDatabaseContext())
            //{
            //    /*Entity Fremawork te veritabanına erişim kodu bu kadar kısaldı. context.Customer.ToList() kodun bu kısmı nesneye ulaşmamızı sağlar
            //     */
            //    dgwCustomer.DataSource = context.Customer.ToList();
            //}
            /**********************************************************************************************/
            /*DataGridView nesnesinin veri kaynağını belirttik.*/
            LoadCustomer();
        }

        private void LoadCustomer()
        {
            dgwCustomer.DataSource = _customerDal.GetAll();
        }

        private void BrnAdd_Click(object sender, EventArgs e)
        {
            _customerDal.Add(new Customer
            {
                Name = txtNameAdd.Text,
                LastName = txtLastNameAdd.Text,
                Number = Convert.ToInt32(txtNumberAdd.Text)

            });
            LoadCustomer();
            MessageBox.Show("Added!");
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _customerDal.Update(new Customer
            {
                ID =Convert.ToInt32(dgwCustomer.CurrentRow.Cells[0].Value.ToString()),
                Name = txtNameUpdate.Text,
                LastName = txtLastNameUpdate.Text,
                Number = Convert.ToInt32(txtNumberUpdate.Text)
            });
            LoadCustomer();
            MessageBox.Show("Updated!");
        }

        /*Bir önceki ADO.Net örneğinde silme işleminde sadece ID göndermemiz yeterliydi. Entity Framewrokte genellikle nesneler ile 
         çalıştımızdan dolayı burada nesne olarak gönderdik.*/
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _customerDal.Delete(new Customer
            {
                 ID = Convert.ToInt32(dgwCustomer.CurrentRow.Cells[0].Value.ToString()),
                
            });
            LoadCustomer();
            MessageBox.Show("Deleted!");

        }
        private void DgwCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameUpdate.Text = dgwCustomer.CurrentRow.Cells[1].Value.ToString();
            txtLastNameUpdate.Text = dgwCustomer.CurrentRow.Cells[2].Value.ToString();
            txtNumberUpdate.Text = dgwCustomer.CurrentRow.Cells[3].Value.ToString();

        }
    }
}
