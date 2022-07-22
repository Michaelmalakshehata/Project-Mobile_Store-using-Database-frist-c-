using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace main
{
    public partial class Reports : DevExpress.XtraEditors.XtraForm
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accessoriesDataSet16.Bills' table. You can move, or remove it, as needed.
            this.billsTableAdapter.Fill(this.accessoriesDataSet13.Bills);
            // TODO: This line of code loads data into the 'accessoriesDataSet14.Bills' table. You can move, or remove it, as needed.
            accessContext context = new accessContext();
            DataSet ds=new DataSet();
            
            var c = context.Bills.Select(n => new { n.Id,n.customer_phone,n.productname,n.quantity, n.Price }).ToList();
            billsBindingSource.DataSource = c;
           
            this.reportViewer1.RefreshReport();
        }
    }
}