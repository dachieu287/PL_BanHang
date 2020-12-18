using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class Manage : Form
    {
        private readonly ListViewColumnSorter sorter = null;

        private readonly AccountBUS accountBUS = null;
        private readonly BillBUS billBUS = null;
        private readonly BillDetailBUS billDetailBUS = null;
        private readonly CatalogBUS catalogBUS = null;
        private readonly ComboBUS comboBUS = null;
        private readonly ComboDetailBUS comboDetailBUS = null;
        private readonly ProductBUS productBUS = null;

        public Manage()
        {
            InitializeComponent();
            sorter = new ListViewColumnSorter();
            lvCatalog.ListViewItemSorter = sorter;
            lvCombo.ListViewItemSorter = sorter;
            lvProduct.ListViewItemSorter = sorter;
            lvBill.ListViewItemSorter = sorter;
            
            accountBUS = new AccountBUS();
            billBUS = new BillBUS();
            billDetailBUS = new BillDetailBUS();
            catalogBUS = new CatalogBUS();
            comboBUS = new ComboBUS();
            comboDetailBUS = new ComboDetailBUS();
            productBUS = new ProductBUS();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedTab.Name.Equals("tpCatalog"))
            {
                ShowAllCatalog();
            }
            else if (tabMain.SelectedTab.Name.Equals("tpProduct"))
            {
                ShowAllProduct();
                LoadCboCatalog();
            }
            else if (tabMain.SelectedTab.Name.Equals("tpCombo"))
            {
                ShowAllCombo();
            }
            else if (tabMain.SelectedTab.Name.Equals("tpBill"))
            {
                ShowAllBill();
            }
        }
        private void ShowAllBill()
        {
            lvBill.Items.Clear();
            List<Bill> bills = billBUS.GetAll();
            foreach (Bill bill in bills)
            {
                ListViewItem item = new ListViewItem(bill.ID.ToString());
                item.SubItems.Add(bill.Name);
                item.SubItems.Add(bill.Datetime.ToString("dd/MM/yyyy hh:mm:ss"));
                item.SubItems.Add(bill.Total.ToString());
                item.SubItems.Add(bill.Status.ToString());
                item.Tag = bill;
                if (bill.Status == BillStatus.Unprocessed)
                {
                    item.Group = lvBill.Groups["lvgUnprocessed"];
                }
                else if (bill.Status == BillStatus.Processing)
                {
                    item.Group = lvBill.Groups["lvgProcessing"];
                }
                else if (bill.Status == BillStatus.Shipping)
                {
                    item.Group = lvBill.Groups["lvgShipping"];
                }
                else if (bill.Status == BillStatus.Done)
                {
                    item.Group = lvBill.Groups["lvgDone"];
                }
                else if (bill.Status == BillStatus.Cancel)
                {
                    item.Group = lvBill.Groups["lvgCancel"];
                }
                
                lvBill.Items.Add(item);
            }
        }

        private void ShowBills(List<Bill> bills)
        {
            lvBill.Items.Clear();
            foreach (Bill bill in bills)
            {
                ListViewItem item = new ListViewItem(bill.ID.ToString());
                item.SubItems.Add(bill.Name);
                item.SubItems.Add(bill.Datetime.ToString("dd/MM/yyyy hh:mm:ss"));
                item.SubItems.Add(bill.Total.ToString());
                item.SubItems.Add(bill.Status.ToString());
                item.Tag = bill;
                if (bill.Status == BillStatus.Unprocessed)
                {
                    item.Group = lvBill.Groups["lvgUnprocessed"];
                }
                else if (bill.Status == BillStatus.Processing)
                {
                    item.Group = lvBill.Groups["lvgProcessing"];
                }
                else if (bill.Status == BillStatus.Shipping)
                {
                    item.Group = lvBill.Groups["lvgShipping"];
                }
                else if (bill.Status == BillStatus.Done)
                {
                    item.Group = lvBill.Groups["lvgDone"];
                }
                else if (bill.Status == BillStatus.Cancel)
                {
                    item.Group = lvBill.Groups["lvgCancel"];
                }
                lvBill.Items.Add(item);
            }
        }

        private void ShowBillDetails(List<BillDetail> billDetails)
        {
            lvBillDetail.Items.Clear();
            foreach (BillDetail billDetail in billDetails)
            {
                string id = "";
                string name = "";
                decimal price = billDetail.Price;
                int quantity = billDetail.Quantity;
                if (billDetail.Product != null)
                {
                    id = billDetail.Product.ID;
                    name = productBUS.GetName(id);
                }
                else if (billDetail.Combo != null)
                {
                    id = billDetail.Combo.ID;
                    name = comboBUS.GetName(id);
                }

                ListViewItem item = new ListViewItem(id);
                item.SubItems.Add(name);
                item.SubItems.Add(price.ToString());
                item.SubItems.Add(quantity.ToString());
                lvBillDetail.Items.Add(item);
            }
        }

        public void ShowAllCatalog()
        {
            lvCatalog.Items.Clear();
            List<Catalog> catalogs = catalogBUS.GetAll();
            foreach (Catalog catalog in catalogs)
            {
                ListViewItem item = new ListViewItem(catalog.ID);
                item.SubItems.Add(catalog.Name);
                item.Tag = catalog;

                lvCatalog.Items.Add(item);
            }
        }

        public void ShowCatalogs(List<Catalog> catalogs)
        {
            lvCatalog.Items.Clear();
            foreach (Catalog catalog in catalogs)
            {
                ListViewItem item = new ListViewItem(catalog.ID);
                item.SubItems.Add(catalog.Name);
                item.Tag = catalog;

                lvCatalog.Items.Add(item);
            }
        }

        public void LoadCboCatalog()
        {
            cboProductCatalog.Items.Clear();
            cboProductSearchCatalog.Items.Clear();

            List<Catalog> catalogs = catalogBUS.GetAll();

            cboProductCatalog.Items.AddRange(catalogs.ToArray());

            cboProductSearchCatalog.Items.Add("Tất cả");
            cboProductSearchCatalog.Items.AddRange(catalogs.ToArray());
            cboProductSearchCatalog.SelectedIndex = 0;
        }

        public void ShowAllProduct()
        {
            lvProduct.Items.Clear();
            List<Product> products = productBUS.GetAll();
            foreach (Product product in products)
            {
                ListViewItem item = new ListViewItem(product.ID);
                item.SubItems.Add(product.Name);
                item.SubItems.Add(product.Price.ToString());
                item.SubItems.Add(product.Quantity.ToString());
                item.SubItems.Add(product.Catalog.ID);
                item.Tag = product;

                lvProduct.Items.Add(item);
            }
        }

        public void ShowProducts(List<Product> products)
        {
            lvProduct.Items.Clear();
            foreach (Product product in products)
            {
                ListViewItem item = new ListViewItem(product.ID);
                item.SubItems.Add(product.Name);
                item.SubItems.Add(product.Price.ToString());
                item.SubItems.Add(product.Quantity.ToString());
                item.SubItems.Add(product.Catalog.ID);
                item.Tag = product;

                lvProduct.Items.Add(item);
            }
        }

        public void ShowAllCombo()
        {
            lvCombo.Items.Clear();
            List<Combo> combos = comboBUS.GetAll();
            foreach (Combo combo in combos)
            {
                ListViewItem item = new ListViewItem(combo.ID);
                item.SubItems.Add(combo.Name);
                item.SubItems.Add(combo.Price.ToString());
                item.Tag = combo;

                lvCombo.Items.Add(item);
            }
        }

        public void ShowCombos(List<Combo> combos)
        {
            lvCombo.Items.Clear();
            foreach (Combo combo in combos)
            {
                ListViewItem item = new ListViewItem(combo.ID);
                item.SubItems.Add(combo.Name);
                item.SubItems.Add(combo.Price.ToString());
                item.Tag = combo;

                lvCombo.Items.Add(item);
            }
        }

        public void ShowComboDetailByComboID(string comboid)
        {
            List<ComboDetail> comboDetails = comboDetailBUS.GetByComboID(comboid);
            lvComboDetail.Items.Clear();
            foreach (ComboDetail comboDetail in comboDetails)
            {
                ListViewItem item = new ListViewItem(comboDetail.Product.ID);
                item.SubItems.Add(comboDetail.Product.Name);
                item.SubItems.Add(comboDetail.Quantity.ToString());
                item.Tag = comboDetail;

                lvComboDetail.Items.Add(item);
            }
        }

        private void lvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProduct.SelectedItems.Count == 0)
            {
                return;
            }

            Product product = lvProduct.SelectedItems[0].Tag as Product;
            txtProductID.Text = product.ID;
            txtProductName.Text = product.Name;
            nmrProductQuantity.Value = product.Quantity;
            nmrProductPrice.Value = product.Price;

            int index = -1;
            for (int i = 0; i < cboProductCatalog.Items.Count; i++)
            {
                if ((cboProductCatalog.Items[i] as Catalog).ID.Equals(product.Catalog.ID))
                {
                    index = i;
                    break;
                }
            }
            cboProductCatalog.SelectedIndex = index;

            txtProductDescription.Text = product.Description;
            picProductImage.Image = Image.FromStream(new MemoryStream(product.Image));
        }

        private void lvCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCatalog.SelectedItems.Count == 0)
            {
                return;
            }
            Catalog catalog = lvCatalog.SelectedItems[0].Tag as Catalog;

            txtCatalogID.Text = catalog.ID;
            txtCatalogName.Text = catalog.Name;
        }

        private void btnCatalogRefresh_Click(object sender, EventArgs e)
        {
            txtCatalogID.Text = "";
            txtCatalogName.Text = "";
        }

        private void btnCatalogAdd_Click(object sender, EventArgs e)
        {
            string id = txtCatalogID.Text;
            string name = txtCatalogName.Text;

            if (String.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Mã không được trống");
                return;
            }
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Tên không được trống");
                return;
            }

            Catalog catalog = new Catalog
            {
                ID = id,
                Name = name
            };
            bool result = catalogBUS.Add(catalog);

            if (result)
            {
                MessageBox.Show("Thêm thành công");
                ShowAllCatalog();
                btnCatalogRefresh.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnCatalogEdit_Click(object sender, EventArgs e)
        {
            if (lvCatalog.SelectedItems.Count == 0)
            {
                return;
            }
            string id = txtCatalogID.Text;
            string name = txtCatalogName.Text;

            if (String.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Mã không được trống");
                return;
            }
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Tên không được trống");
                return;
            }

            Catalog catalog = lvCatalog.SelectedItems[0].Tag as Catalog;
            string oldid = catalog.ID;
            catalog = new Catalog
            {
                ID = id,
                Name = name
            };

            bool result = catalogBUS.Update(oldid, catalog);

            if (result)
            {
                MessageBox.Show("Sửa thành công");
                ShowAllCatalog();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnCatalogDelete_Click(object sender, EventArgs e)
        {
            if (lvCatalog.SelectedItems.Count == 0)
            {
                return;
            }

            Catalog catalog = lvCatalog.SelectedItems[0].Tag as Catalog;
            string id = catalog.ID;

           bool result = catalogBUS.Delete(id);
            if (result)
            {
                MessageBox.Show("Xóa thành công");
                ShowAllCatalog();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnProductRefresh_Click(object sender, EventArgs e)
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtProductDescription.Text = "";
            cboProductCatalog.SelectedIndex = -1;
            nmrProductQuantity.Value = 0;
            nmrProductPrice.Value = 0;
            ofdProductImage.Reset();
            picProductImage.Image = GUI.Properties.Resources.upload;
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            string id = txtProductID.Text;
            string name = txtProductName.Text;
            string description = txtProductDescription.Text;
            string filename = ofdProductImage.FileName;
            int quantity = (int)nmrProductQuantity.Value;
            decimal price = nmrProductPrice.Value;
            Catalog catalog = cboProductCatalog.SelectedItem as Catalog;

            if (String.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Mã không được trống");
                return;
            }
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Tên không được trống");
                return;
            }
            if (cboProductCatalog.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn danh mục");
                return;
            }
            if (String.IsNullOrEmpty(filename))
            {
                MessageBox.Show("Vui lòng chọn ảnh");
                return;
            }

            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] image = br.ReadBytes((int)fs.Length);
            Product product = new Product
            {
                ID = id,
                Name = name,
                Description = description,
                Catalog = catalog,
                Quantity = quantity,
                Price = price,
                Image = image
            };

            bool result = productBUS.Add(product);
            if (result)
            {
                MessageBox.Show("Thêm thành công");
                ShowAllProduct();
                btnProductRefresh.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm thất bại\n - Mã đã tồn tại");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvProduct.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm");
                return;
            }

            string id = txtProductID.Text;
            string name = txtProductName.Text;
            string description = txtProductDescription.Text;
            int quantity = (int)nmrProductQuantity.Value;
            decimal price = nmrProductPrice.Value;
            string filename = ofdProductImage.FileName;
            Catalog catalog = cboProductCatalog.SelectedItem as Catalog;

            if (String.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Mã không được trống");
                return;
            }
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Tên không được trống");
                return;
            }
            if (cboProductCatalog.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn danh mục");
                return;
            }


            Product oldproduct = lvProduct.SelectedItems[0].Tag as Product;
            byte[] image;
            if (String.IsNullOrEmpty(filename))
            {
                image = oldproduct.Image;
            }
            else
            {
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                image = br.ReadBytes((int)fs.Length);
            }

            Product product = new Product
            {
                ID = id,
                Name = name,
                Description = description,
                Image = image,
                Catalog = catalog,
                Quantity = quantity,
                Price = price,
            };

            bool result = productBUS.Edit(oldproduct.ID, product);
            if (result)
            {
                MessageBox.Show("Sửa thành công");
                ShowAllProduct();
                ofdProductImage.Reset();
            }
            else
            {
                MessageBox.Show("Sửa thất bại\n - Trùng mã");
            }
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            if (lvProduct.SelectedItems.Count == 0)
            {
                return;
            }

            string id = (lvProduct.SelectedItems[0].Tag as Product).ID;
            bool result = productBUS.Delete(id);
            if (result)
            {
                MessageBox.Show("Xóa thành công");
                ShowAllProduct();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            string searchString = txtProductSearchString.Text;
            string searchCatalog = cboProductSearchCatalog.SelectedIndex > 0 ? (cboProductSearchCatalog.SelectedItem as Catalog).ID : null;

            List<Product> products = productBUS.Search(searchString, searchCatalog);

            ShowProducts(products);
        }

        private void lvCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCombo.SelectedItems.Count == 0)
            {
                lvComboDetail.Items.Clear();
                return;
            }

            Combo combo = lvCombo.SelectedItems[0].Tag as Combo;
            txtComboID.Text = combo.ID;
            txtComboName.Text = combo.Name;
            txtComboDescription.Text = combo.Description;
            nmrComboPrevPrice.Value = combo.PrevPrice;
            nmrComboDiscount.Value = combo.Discount;
            nmrComboPrice.Value = combo.Price;
            picComboImage.Image = Image.FromStream(new MemoryStream(combo.Image));

            ShowComboDetailByComboID(combo.ID);
        }

        private void btnComboRefresh_Click(object sender, EventArgs e)
        {
            txtComboID.Text = "";
            txtComboName.Text = "";
            txtComboDescription.Text = "";
            nmrComboPrevPrice.Value = 0;
            nmrComboDiscount.Value = 0;
            nmrComboPrice.Value = 0;
            ofdComboImage.Reset();
            picComboImage.Image = GUI.Properties.Resources.upload;
        }

        private void btnComboAdd_Click(object sender, EventArgs e)
        {
            string id = txtComboID.Text;
            string name = txtComboName.Text;
            string description = txtComboDescription.Text;
            decimal prevprice = nmrComboPrevPrice.Value;
            int discount = (int)nmrComboDiscount.Value;
            decimal price = nmrComboPrice.Value;
            string filename = ofdComboImage.FileName;

            if (String.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Mã không được bỏ trống");
                return;
            }
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Tên không được bỏ trống");
                return;
            }
            if (String.IsNullOrEmpty(filename))
            {
                MessageBox.Show("Vui lòng chọn ảnh");
                return;
            }

            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] image = br.ReadBytes((int)fs.Length);

            Combo combo = new Combo
            {
                ID = id,
                Name = name,
                Description = description,
                Image = image,
                PrevPrice = prevprice,
                Discount = discount,
                Price = price,
            };

            bool result = comboBUS.Add(combo);
            if (result)
            {
                MessageBox.Show("Thêm thành công");
                ShowAllCombo();
                btnComboRefresh.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm thất bại\n - Trùng mã");
            }
        }

        private void btnComboEdit_Click(object sender, EventArgs e)
        {
            if (lvCombo.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một trường để sửa");
                return;
            }

            string id = txtComboID.Text;
            string name = txtComboName.Text;
            string description = txtComboDescription.Text;
            string filename = ofdComboImage.FileName;
            decimal prevprice = nmrComboPrevPrice.Value;
            int discount = (int)nmrComboDiscount.Value;
            decimal price = nmrComboPrice.Value;

            if (String.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Mã không được bỏ trống");
                return;
            }
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Tên không được bỏ trống");
                return;
            }

            Combo oldcombo = lvCombo.SelectedItems[0].Tag as Combo;
            byte[] image = null;
            if (String.IsNullOrEmpty(filename))
            {
                image = oldcombo.Image;
            }
            else
            {
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                image = br.ReadBytes((int)fs.Length);
            }

            Combo combo = new Combo
            {
                ID = id,
                Name = name,
                Description = description,
                Image = image,
                PrevPrice = prevprice,
                Discount = discount,
                Price = price
            };

            bool result = comboBUS.Edit(oldcombo.ID, combo);
            if (result)
            {
                MessageBox.Show("Sửa thành công");
                ShowAllCombo();
                ofdComboImage.Reset();
            }
            else
            {
                MessageBox.Show("Sửa thất bại \n - Trùng mã");
            }
        }

        private void btnComboDelete_Click(object sender, EventArgs e)
        {
            if (lvCombo.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một trường để xóa");
                return;
            }

            string id = (lvCombo.SelectedItems[0].Tag as Combo).ID;
            bool result = comboBUS.Delete(id);
            if (result)
            {
                MessageBox.Show("Xóa thành công");
                ShowAllCombo();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnComboDetailAdd_Click(object sender, EventArgs e)
        {
            if (lvCombo.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một trường combo");
                return;
            }

            string comboid = (lvCombo.SelectedItems[0].Tag as Combo).ID;
            string productid = txtComboDetailProductID.Text;
            int quantity = (int) nmrComboDetailQuantity.Value;

            if (String.IsNullOrWhiteSpace(productid))
            {
                MessageBox.Show("Mã sản phẩm không được bỏ trống");
                return;
            }

            ComboDetail comboDetail = new ComboDetail
            {
                Combo = new Combo { ID = comboid},
                Product = new Product { ID = productid},
                Quantity = quantity
            };

            bool result = comboDetailBUS.Add(comboDetail);
            if (result)
            {
                MessageBox.Show("Thêm thành công");
                ShowComboDetailByComboID(comboid);
                txtComboDetailProductID.Text = "";
                nmrComboDetailQuantity.Value = 0;
            }
            else
            {
                MessageBox.Show("Thêm thất bại: \n - Đã có mã sản phẩm trong combo\n - Mã sản phẩm không tồn tại");
            }
        }

        private void btnComboDetailDelete_Click(object sender, EventArgs e)
        {
            if (lvComboDetail.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một trường để xóa");
                return;
            }

            ComboDetail comboDetail = lvComboDetail.SelectedItems[0].Tag as ComboDetail;
            bool result = comboDetailBUS.Delete(comboDetail.Combo.ID, comboDetail.Product.ID);
            if (result)
            {
                MessageBox.Show("Xóa thành công");
                ShowComboDetailByComboID(comboDetail.Combo.ID);
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnComboSearch_Click(object sender, EventArgs e)
        {
            string stringSearch = txtComboSearch.Text;
            List<Combo> combos;
            if (String.IsNullOrEmpty(stringSearch))
            {
                combos = comboBUS.GetAll();
                ShowCombos(combos);
                return;
            }

            combos = comboBUS.Search(stringSearch);
            ShowCombos(combos);
        }

        private void lvCatalog_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (sorter.Order == SortOrder.Ascending)
            {
                sorter.Order = SortOrder.Descending;
            }
            else
            {
                sorter.Order = SortOrder.Ascending;
            }
            sorter.SortColumn = e.Column;
            lvCatalog.Sort();
        }

        private void lvProduct_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (sorter.Order == SortOrder.Ascending)
            {
                sorter.Order = SortOrder.Descending;
            }
            else
            {
                sorter.Order = SortOrder.Ascending;
            }
            sorter.SortColumn = e.Column;
            lvProduct.Sort();
        }

        private void lvCombo_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (sorter.Order == SortOrder.Ascending)
            {
                sorter.Order = SortOrder.Descending;
            }
            else
            {
                sorter.Order = SortOrder.Ascending;
            }
            sorter.SortColumn = e.Column;
            lvCombo.Sort();
        }

        private void ptbProduct_Click(object sender, EventArgs e)
        {
            if (ofdProductImage.ShowDialog() == DialogResult.OK)
            {
                picProductImage.Image = Image.FromFile(ofdProductImage.FileName);
            }
        }

        private void picComboImage_Click(object sender, EventArgs e)
        {
            if (ofdComboImage.ShowDialog() == DialogResult.OK)
            {
                picComboImage.Image = Image.FromFile(ofdComboImage.FileName);
            }
        }
       

        private void btnSellAdd_Click(object sender, EventArgs e)
        {
            string id = txtSellID.Text;
            int quantity = (int)nmrSellQuantity.Value;
            if (String.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui lòng nhập mã");
                return;
            }

            //
            BillDetail billDetail = null;
            if (radSellProduct.Checked)
            {
                foreach (ListViewItem lvi in lvSell.Items)
                {
                    if ((lvi.Tag as BillDetail).Product != null && (lvi.Tag as BillDetail).Product.ID.Equals(id))
                    {
                        MessageBox.Show("Đã có");
                        return;
                    }
                }
                billDetail = billDetailBUS.GetProductDetail(id);
            }
            else if (radSellCombo.Checked)
            {
                foreach (ListViewItem lvi in lvSell.Items)
                {
                    if ((lvi.Tag as BillDetail).Combo != null && (lvi.Tag as BillDetail).Combo.ID.Equals(id))
                    {
                        MessageBox.Show("Đã có");
                        return;
                    }
                }
                billDetail = billDetailBUS.GetComboDetail(id);
            }

            //
            if (billDetail != null)
            {
                ListViewItem item = new ListViewItem();
                if (radSellProduct.Checked)
                {
                    item.Text = billDetail.Product.ID;
                    item.SubItems.Add(billDetail.Product.Name);
                }
                else if (radSellCombo.Checked)
                {
                    item.Text = billDetail.Combo.ID;
                    item.SubItems.Add(billDetail.Combo.Name);
                }
                billDetail.Quantity = quantity;

                item.SubItems.Add(billDetail.Price.ToString());
                item.SubItems.Add(quantity.ToString());
                item.SubItems.Add((billDetail.Price * quantity).ToString());
                item.Tag = billDetail;
                lvSell.Items.Add(item);

                txtSellTotal.Text = (decimal.Parse(txtSellTotal.Text) + (quantity * billDetail.Price)).ToString();
                txtSellID.Text = "";
                nmrSellQuantity.Value = 1;
            }
            else
            {
                MessageBox.Show("Sản phẩm không có bán");
            }
        }

        private void btnSellDelete_Click(object sender, EventArgs e)
        {
            if (lvSell.SelectedItems.Count == 0)
            {
                return;
            }

            BillDetail billDetail = lvSell.SelectedItems[0].Tag as BillDetail;
            txtSellTotal.Text = (decimal.Parse(txtSellTotal.Text) - (billDetail.Quantity * billDetail.Price)).ToString();
            lvSell.Items.RemoveAt(lvSell.SelectedIndices[0]);
        }

        private void btnSellDeteleAll_Click(object sender, EventArgs e)
        {
            txtSellTotal.Text = "0";
            lvSell.Items.Clear();
        }

        private void btnSellPay_Click(object sender, EventArgs e)
        {
            if (lvSell.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm hàng");
                return;
            }
            string name = txtSellName.Text;
            string address = txtSellAddress.Text;
            string phone = txtSellPhone.Text;

            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập tên");
                return;
            }

            if (String.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ");
            }

            if (!Regex.IsMatch(phone, @"^([\+]?33[-]?|[0])?[1-9][0-9]{8}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }

            List<BillDetail> billDetails = new List<BillDetail>();
            foreach (ListViewItem item in lvSell.Items)
            {
                BillDetail billDetail = item.Tag as BillDetail;
                billDetails.Add(billDetail);
            }
            

            Bill bill = new Bill
            {
                Name = name,
                Address = address,
                Phone = phone,
                BillDetails = billDetails,
                Status = BillStatus.Unprocessed,
                Total = decimal.Parse(txtSellTotal.Text)
            };

            if (billBUS.Add(bill))
            {
                MessageBox.Show("Thành công");
                lvSell.Items.Clear();
                txtSellTotal.Text = "0";
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void btnBillSearch_Click(object sender, EventArgs e)
        {
            string searchString = txtBillSearchString.Text;
            DateTime? fromDate = dtpBillSearchFromDate.Checked ? (DateTime?)dtpBillSearchFromDate.Value : null;
            DateTime? toDate = dtpBillSearchToDate.Checked ? (DateTime?)dtpBillSearchToDate.Value : null;
            decimal fromTotal = nmrBillFromTotal.Value;
            decimal toTotal = nmrBillToTotal.Value;

            List<Bill> bills = billBUS.Search(searchString, fromDate, toDate, fromTotal, toTotal);
            ShowBills(bills);
        }

        private void lvBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBill.SelectedItems.Count == 0)
            {
                lvBillDetail.Items.Clear();
                return;
            }

            Bill bill = (lvBill.SelectedItems[0].Tag as Bill);
            List<BillDetail> billDetails = billDetailBUS.GetBillDetails(bill.ID);
            ShowBillDetails(billDetails);

            txtBillName.Text = bill.Name;
            txtBillAddress.Text = bill.Address;
            txtBillPhone.Text = bill.Phone;

            if (bill.Status == BillStatus.Unprocessed)
            {
                radBillUnprocessed.Checked = true;
            }
            else if (bill.Status == BillStatus.Processing)
            {
                radBillProccessing.Checked = true;
            }
            else if (bill.Status == BillStatus.Shipping)
            {
                radBillShipping.Checked = true;
            }
            else if (bill.Status == BillStatus.Done)
            {
                radBillDone.Checked = true;
            }
            else if (bill.Status == BillStatus.Cancel)
            {
                radBillCancel.Checked = true;
            }
        }

        private void btnBillStatus_Click(object sender, EventArgs e)
        {
            if (lvBill.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một trường");
                return;
            }

            string name = txtBillName.Text;
            string address = txtBillAddress.Text;
            string phone = txtBillPhone.Text;

            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập tên");
                return;
            }

            if (String.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ");
            }

            if (!Regex.IsMatch(phone, @"^([\+]?33[-]?|[0])?[1-9][0-9]{8}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }

            int oldid = (lvBill.SelectedItems[0].Tag as Bill).ID;
            BillStatus billStatus = BillStatus.Unprocessed;
            if (radBillUnprocessed.Checked)
            {
                billStatus = BillStatus.Unprocessed;
            }
            else if (radBillProccessing.Checked)
            {
                billStatus = BillStatus.Processing;
            }
            else if (radBillShipping.Checked)
            {
                billStatus = BillStatus.Shipping;
            }
            else if (radBillDone.Checked)
            {
                billStatus = BillStatus.Done;
            }
            else if (radBillCancel.Checked)
            {
                billStatus = BillStatus.Cancel;
            }

            Bill bill = new Bill
            {
                Name = name,
                Address = address,
                Phone = phone,
                Status = billStatus,
            };

            if (billBUS.Edit(oldid, bill))
            {
                MessageBox.Show("Thành công");
                ShowAllBill();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void lvBill_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (sorter.Order == SortOrder.Ascending)
            {
                sorter.Order = SortOrder.Descending;
            }
            else
            {
                sorter.Order = SortOrder.Ascending;
            }
            sorter.SortColumn = e.Column;
            lvBill.Sort();
        }
    }
}
