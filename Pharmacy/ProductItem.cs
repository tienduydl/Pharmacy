using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class ProductItem : UserControl
    {
        public ProductItem()
        {
            InitializeComponent();
            label1.Text = "Số lượng:";
            label3.Text = "Giá bán:";
            button2.Text = "Thêm"; 
        }
        public string TenThuoc { 
            get {
                return mednamelabel.Text;
            }
            set { 
                mednamelabel.Text = value;
            } }
        public string Price { get {
                return giathuoclabel.Text;
            } set { 
                giathuoclabel.Text = value;
            } }
        public Image HinhAnh { get { 
                return hinhanhthuoc.Image;
            } set { 
                hinhanhthuoc.Image = value;
            } }
        public decimal soluong { get { return soluongbaninput.Value; } set { soluongbaninput.Value = value; } }
        public event EventHandler AddClicked;

        private void button2_Click(object sender, EventArgs e)
        {
            AddClicked?.Invoke(this, EventArgs.Empty);
        }
    }
    
}
