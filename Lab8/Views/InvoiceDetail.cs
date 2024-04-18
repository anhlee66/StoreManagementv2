using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Lab8.Views
{
    public partial class InvoiceDetail : UserControl
    {
        AdminOrder order;
        public InvoiceDetail(AdminOrder order)
        {
            InitializeComponent();
            this.order = order;
        }
        private int _id;
        private string _name;
        private int _quantity;
        private int _maxQuantity;

        private decimal _price;

        private void btnRemove_Click(object sender, EventArgs e)
        {
            order.removeInvoice(this.Id);
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            Quantity = Convert.ToInt32(numQuantity.Value);
            order.calculateTotalPrice();
        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;

            }
        }
        [Category("Data")]

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                txtName.Text = value;
            }
        }
        [Category("Data")]

        public decimal Price
        {
            get { return _price; }
            set
            {
                _price = value;
                txtPrice.Text = value.ToString();
            }
        }
        [Category("Data")]
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value <= _maxQuantity)
                {
                    _quantity = value;
                    numQuantity.Value = value;
                }

            }
        }
        public int MaxQuantity
        {
            get { return _quantity; }
            set
            {
                _maxQuantity = value;
            }
        }
    }
}
