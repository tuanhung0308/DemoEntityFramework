using DemoEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace DemoEntityFramework
{
    public partial class Form1 : Form
    {
        public NorthwindContext context;
       
        public List<Supplier> suppliers;
        public Form1()
        {
            context = new NorthwindContext();
            InitializeComponent();
        }

        public void LoadData()
        {
            dgvSupplier.DataSource = (from x in context.Suppliers
                                      select new
                                      {
                                          x.SupplierId,
                                          x.CompanyName,
                                          x.ContactName,
                                          x.ContactTitle,
                                          x.Phone,
                                          x.HomePage
                                      }


                                      ).ToList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            suppliers = new List<Supplier>();
            
            // LoadData();
            //  cbTitle.DataSource = context.Suppliers.Select(x => x.ContactTitle).Distinct().ToList();
            //Select distinct contactTitle form Supplier
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            tbSupplierID.Text = dgvSupplier.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            tbCompanyName.Text = dgvSupplier.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            tbContactName.Text = dgvSupplier.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            cbTitle.SelectedItem = dgvSupplier.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            tbPhone.Text = dgvSupplier.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            tbHomePage.Text = dgvSupplier.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
        }

        public Supplier GetSupplier()
        {
            Supplier s = new Supplier();
            //s.SupplierId = int.Parse(tbSupplierID.Text);
            s.CompanyName = tbCompanyName.Text;
            s.ContactName = tbContactName.Text;
            s.ContactTitle = cbTitle.SelectedItem.ToString();
            s.Phone = tbPhone.Text;
            s.HomePage = tbHomePage.Text;
            return s;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier newSub = GetSupplier();
                context.Suppliers.Add(newSub);
                context.SaveChanges();
                LoadData();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbSupplierID.Text);
                //Lay thong tin can update tu giao dien (thong tin moi)
                Supplier newSup = GetSupplier();

                //Lay ra duoc supplir can update (thong tin cu)
                Supplier updateSup = context.Suppliers.FirstOrDefault(x => x.SupplierId == id);
                updateSup.ContactTitle = newSup.ContactTitle;
                updateSup.Phone = newSup.Phone;
                updateSup.HomePage = newSup.HomePage;
                updateSup.ContactName = newSup.ContactName;
                updateSup.CompanyName = newSup.CompanyName;
                context.SaveChanges();
                LoadData();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //Cach nay su dung cho ham delete

                int id = int.Parse(tbSupplierID.Text);
                context.Database.ExecuteSqlRaw($"update Products set SupplierID = null where SupplierID = {id}");
                context.Database.ExecuteSqlRaw($"delete from Suppliers where SupplierID = {id}");
                LoadData();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void btInsertDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                context.Suppliers.AddRange(suppliers);
                context.SaveChanges(true);
                MessageBox.Show($"Insert successfully {suppliers.Count} suppliers");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}