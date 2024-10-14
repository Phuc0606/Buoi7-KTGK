using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace De02
{
    public partial class frmSanpham : Form
    {
        private Model1 db = new Model1();
      
        public frmSanpham()
        {
            InitializeComponent();
        }

        private void frmSanpham_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadLoaiSP();
            UpdateButtonState();
        }

        private void LoadProducts()
        {
       
            dgvSanpham.Rows.Clear();
            var products = db.Sanpham.Include(p => p.LoaiSP).ToList();

            foreach (var product in products)
            {
                dgvSanpham.Rows.Add(product.MaSP, product.TenSP, product.Ngaynhap.ToString("dd/MM/yyyy"), product.LoaiSP.TenLoai);
            }
        }
        private void LoadLoaiSP()
        {
            cbLoaiSP.Items.Clear();

            // Lấy danh sách loại sản phẩm từ cơ sở dữ liệu
            var loaiSPs = db.LoaiSP.ToList();

            foreach (var loaiSP in loaiSPs)
            {
                cbLoaiSP.Items.Add(new { Text = loaiSP.TenLoai, Value = loaiSP.MaLoai });
            }

            cbLoaiSP.DisplayMember = "Text";
            cbLoaiSP.ValueMember = "Value";
        }


        private void dgvSanpham_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSanpham.SelectedRows.Count > 0)
            {
                var selectedRow = dgvSanpham.SelectedRows[0];
                txtMaSP.Text = selectedRow.Cells[0].Value.ToString();
                txtTenSP.Text = selectedRow.Cells[1].Value.ToString();
                dtNgaynhap.Value = DateTime.Parse(selectedRow.Cells[2].Value.ToString());

                // Lấy loại sản phẩm và hiển thị lên ComboBox
                cbLoaiSP.SelectedIndex = cbLoaiSP.FindStringExact(selectedRow.Cells[3].Value.ToString());
            }
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            btSua.Enabled = dgvSanpham.SelectedRows.Count > 0;
            btXoa.Enabled = dgvSanpham.SelectedRows.Count > 0;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                // Tạo đối tượng sản phẩm mới
                var product = new Sanpham
                {
                    MaSP = txtMaSP.Text,
                    TenSP = txtTenSP.Text,
                    Ngaynhap = dtNgaynhap.Value,
                    MaLoai = ((dynamic)cbLoaiSP.SelectedItem).Value
                };

  
                db.Sanpham.Add(product);
                db.SaveChanges();

                // Cập nhật DataGridView
                LoadProducts();
                ClearInputs();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát chương trình", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            var filteredProducts = db.Sanpham
                .Include(p => p.LoaiSP)
                .Where(p => p.TenSP.ToLower().Contains(searchText))
                .ToList();

            dgvSanpham.Rows.Clear();
            foreach (var product in filteredProducts)
            {
                dgvSanpham.Rows.Add(product.MaSP, product.TenSP, product.Ngaynhap.ToString("dd/MM/yyyy"), product.LoaiSP.TenLoai);
            }
        }
    

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dgvSanpham.SelectedRows.Count > 0 && ValidateInput())
            {
                var selectedRow = dgvSanpham.SelectedRows[0];
                var maSP = selectedRow.Cells[0].Value.ToString();

                var product = db.Sanpham.Find(maSP);
                if (product != null)
                {
                    product.TenSP = txtTenSP.Text;
                    product.Ngaynhap = dtNgaynhap.Value;
                    product.MaLoai = ((dynamic)cbLoaiSP.SelectedItem).Value;

                    db.SaveChanges();

                    LoadProducts();
                    ClearInputs();
                }
            }
        }
    
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(txtTenSP.Text) || cbLoaiSP.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm.");
                return false;
            }
            return true;
        }

        // Xóa các trường nhập liệu
        private void ClearInputs()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            dtNgaynhap.Value = DateTime.Now;
            cbLoaiSP.SelectedIndex = -1;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanpham.SelectedRows.Count > 0)
            {
                var selectedRow = dgvSanpham.SelectedRows[0];
                var maSP = selectedRow.Cells[0].Value.ToString();

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var product = db.Sanpham.Find(maSP);
                    if (product != null)
                    {
                        db.Sanpham.Remove(product);
                        db.SaveChanges();

                        LoadProducts();
                        ClearInputs();
                    }
                }
            }
        }

    

        

     
    }
    
}
   

