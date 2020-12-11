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
        private readonly PriceBUS priceBUS = null;
        private readonly ProductBUS productBUS = null;

        public Manage()
        {
            InitializeComponent();
            sorter = new ListViewColumnSorter();
            lvCatalog.ListViewItemSorter = sorter;
            lvCombo.ListViewItemSorter = sorter;
            lvPrice.ListViewItemSorter = sorter;
            lvPriceHistory.ListViewItemSorter = sorter;
            lvProduct.ListViewItemSorter = sorter;
            lvStorage.ListViewItemSorter = sorter;
            
            accountBUS = new AccountBUS();
            billBUS = new BillBUS();
            billDetailBUS = new BillDetailBUS();
            catalogBUS = new CatalogBUS();
            comboBUS = new ComboBUS();
            comboDetailBUS = new ComboDetailBUS();
            priceBUS = new PriceBUS();
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
            else if (tabMain.SelectedTab.Name.Equals("tpPrice"))
            {
                ShowAllPriceByOption();
                LoadCboCatalogPrice();
            }
            else if (tabMain.SelectedTab.Name.Equals("tpStorage"))
            {
                ShowAllStorage();
                LoadCboCatalogStorage();
            }
            else if (tabMain.SelectedTab.Name.Equals("tpBill"))
            {
                ShowAllBill();
            }
        }

        private void LoadCboCatalogStorage()
        {
            cboStorageSearchCatalog.Items.Clear();
            List<Catalog> catalogs = catalogBUS.GetAll();
            cboStorageSearchCatalog.Items.Add("Tất cả");
            cboStorageSearchCatalog.Items.AddRange(catalogs.ToArray());
            cboStorageSearchCatalog.SelectedIndex = 0;
        }
        private void ShowAllBill()
        {
            lvBill.Items.Clear();
            List<Bill> bills = billBUS.GetAll();
            foreach (Bill bill in bills)
            {
                ListViewItem item = new ListViewItem(bill.ID.ToString());
                item.SubItems.Add(bill.Account.Email);
                item.SubItems.Add(bill.Datetime.ToString("dd/MM/yyyy hh:mm:ss"));
                item.SubItems.Add(bill.Total.ToString());
                item.SubItems.Add(bill.Status.ToString());
                item.Tag = bill;
                item.Group = lvBill.Groups["lvgStore"];
                lvBill.Items.Add(item);
            }
        }

        private void ShowAllStorage()
        {
            lvStorage.Items.Clear();
            List<Product> products = productBUS.GetAll();
            foreach (Product product in products)
            {
                ListViewItem item = new ListViewItem(product.ID);
                item.SubItems.Add(product.Name);
                item.SubItems.Add(product.Quantity.ToString());
                item.Tag = product;
                lvStorage.Items.Add(item);
            }
        }

        private void ShowStorages(List<Product> products)
        {
            lvStorage.Items.Clear();
            foreach (Product product in products)
            {
                ListViewItem item = new ListViewItem(product.ID);
                item.SubItems.Add(product.Name);
                item.SubItems.Add(product.Quantity.ToString());
                item.Tag = product;
                lvStorage.Items.Add(item);
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
                item.SubItems.Add(combo.Description);
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
                item.SubItems.Add(combo.Description);
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

        public void ShowAllPriceByOption()
        {
            lvPrice.Items.Clear();
            if (radPriceProduct.Checked)
            {
                List<Price> prices = priceBUS.GetByProduct();
                foreach (Price price in prices)
                {
                    ListViewItem item = new ListViewItem(price.Product.ID);
                    item.SubItems.Add(price.Product.Name);
                    item.SubItems.Add(price.Pricez.ToString());
                    item.Tag = price.Product.ID;
                    lvPrice.Items.Add(item);
                }
            }
            else if (radPriceCombo.Checked)
            {
                List<Price> prices = priceBUS.GetByCombo();
                foreach (Price price in prices)
                {
                    ListViewItem item = new ListViewItem(price.Combo.ID);
                    item.SubItems.Add(price.Combo.Name);
                    item.SubItems.Add(price.Pricez.ToString());
                    item.Tag = price.Combo.ID;
                    lvPrice.Items.Add(item);
                }
            }
        }

        public void ShowPricesByOption(List<Price> prices)
        {
            lvPrice.Items.Clear();
            if (radPriceProduct.Checked)
            {
                foreach (Price price in prices)
                {
                    ListViewItem item = new ListViewItem(price.Product.ID);
                    item.SubItems.Add(price.Product.Name);
                    item.SubItems.Add(price.Pricez.ToString());
                    item.Tag = price.Product.ID;
                    lvPrice.Items.Add(item);
                }
            }
            else if (radPriceCombo.Checked)
            {
                foreach (Price price in prices)
                {
                    ListViewItem item = new ListViewItem(price.Combo.ID);
                    item.SubItems.Add(price.Combo.Name);
                    item.SubItems.Add(price.Pricez.ToString());
                    item.Tag = price.Combo.ID;
                    lvPrice.Items.Add(item);
                }
            }
        }

        public void ShowHistoryPriceByProduct(string productid)
        {
            lvPriceHistory.Items.Clear();
            List<Price> prices = priceBUS.GetHistoryByProduct(productid);
            foreach (Price price in prices)
            {
                ListViewItem item = new ListViewItem(price.FromDatetime.ToString("dd/MM/yyyy hh:mm:ss"));
                item.SubItems.Add(price.ToDatetime == null ? "" : ((DateTime)price.ToDatetime).ToString("dd/MM/yyyy hh:mm:ss"));
                item.SubItems.Add(price.PrevPrice.ToString());
                item.SubItems.Add(price.Discount.ToString());
                item.SubItems.Add(price.Pricez.ToString());
                lvPriceHistory.Items.Add(item);
            }
        }

        public void ShowHistoryPriceByCombo(string comboid)
        {
            lvPriceHistory.Items.Clear();
            List<Price> prices = priceBUS.GetHistoryByCombo(comboid);
            foreach (Price price in prices)
            {
                ListViewItem item = new ListViewItem(price.FromDatetime.ToString("dd/MM/yyyy hh:mm:ss"));
                item.SubItems.Add(price.ToDatetime == null ? "" : ((DateTime)price.ToDatetime).ToString("dd/MM/yyyy hh:mm:ss"));
                item.SubItems.Add(price.PrevPrice.ToString());
                item.SubItems.Add(price.Discount.ToString());
                item.SubItems.Add(price.Pricez.ToString());
                lvPriceHistory.Items.Add(item);
            }
        }

        public void LoadCboCatalogPrice()
        {
            cboPriceSearchCatalog.Items.Clear();
            List<Catalog> catalogs = catalogBUS.GetAll();
            cboPriceSearchCatalog.Items.Add("Tất cả");
            cboPriceSearchCatalog.Items.AddRange(catalogs.ToArray());
            cboPriceSearchCatalog.SelectedIndex = 0;
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
            ofdProductImage.Reset();
            picProductImage.Image = GUI.Properties.Resources.upload;
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            string id = txtProductID.Text;
            string name = txtProductName.Text;
            string description = txtProductDescription.Text;
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
                MessageBox.Show("Thêm thất bại");
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
            byte[] image = null;
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
                Catalog = catalog
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
                MessageBox.Show("Sửa thất bại");
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

        private void Manage_Load(object sender, EventArgs e)
        {

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
            picComboImage.Image = Image.FromStream(new MemoryStream(combo.Image));

            ShowComboDetailByComboID(combo.ID);
        }

        private void btnComboRefresh_Click(object sender, EventArgs e)
        {
            txtComboID.Text = "";
            txtComboName.Text = "";
            txtComboDescription.Text = "";
            ofdComboImage.Reset();
            picComboImage.Image = GUI.Properties.Resources.upload;
        }

        private void btnComboAdd_Click(object sender, EventArgs e)
        {
            string id = txtComboID.Text;
            string name = txtComboName.Text;
            string description = txtComboDescription.Text;
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
                Image = image
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
                Image = image
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
            List<Combo> combos = null;
            string stringSearch = txtComboSearch.Text;
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

        private void lvPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPrice.SelectedItems.Count == 0)
            {
                lvPriceHistory.Items.Clear();
                return;
            }

            string id = lvPrice.SelectedItems[0].Tag as string;
            txtPriceOptionID.Text = id;
            if (radPriceProduct.Checked)
            {
                ShowHistoryPriceByProduct(id);
                radPriceUpdateProduct.Checked = true;
            }
            else if (radPriceCombo.Checked)
            {
                ShowHistoryPriceByCombo(id);
                radPriceUpdateCombo.Checked = true;
            }
        }

        private void chkPromotion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPricePromotion.Checked)
            {
                nmrPricePrevPrice.Enabled = true;
                nmrPriceDiscount.Enabled = true;
            }
            else
            {
                nmrPricePrevPrice.Enabled = false;
                nmrPriceDiscount.Enabled = false;
            }
        }

        private void btnPriceUpdate_Click(object sender, EventArgs e)
        {
            string optionid = txtPriceOptionID.Text;

            if (String.IsNullOrEmpty(optionid))
            {
                MessageBox.Show("Vui lòng nhập mã");
                return;
            }
            Price price = new Price();
            if (radPriceUpdateProduct.Checked)
            {
                price.Product = new Product { ID = optionid };
            }
            else if (radPriceUpdateCombo.Checked)
            {
                price.Combo = new Combo { ID = optionid };
            }
            if (chkPricePromotion.Checked)
            {
                price.Discount = (int)nmrPriceDiscount.Value;
                price.PrevPrice = nmrPricePrevPrice.Value;
            }
            price.FromDatetime = DateTime.Now;
            price.Pricez = nmrPricePrice.Value;

            bool result = priceBUS.Update(price);
            if (result)
            {
                MessageBox.Show("Cập nhật thành công");
                if (radPriceUpdateProduct.Checked)
                {
                    ShowHistoryPriceByProduct(optionid);
                }
                else if (radPriceUpdateCombo.Checked)
                {
                    ShowHistoryPriceByCombo(optionid);
                }
                ShowAllPriceByOption();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void radPriceProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (radPriceCombo.Checked)
            {
                cboPriceSearchCatalog.Enabled = false;
            }
            else if (radPriceProduct.Checked)
            {
                cboPriceSearchCatalog.Enabled = true;
            }
             ShowAllPriceByOption();
             
        }

        private void btnPriceSearch_Click(object sender, EventArgs e)
        {
            string searchString = txtPriceSearchString.Text;
            string searchCatalog = null;
            if (radPriceProduct.Checked)
            {               
                if (cboPriceSearchCatalog.SelectedIndex > 0)
                {
                    searchCatalog = (cboPriceSearchCatalog.SelectedItem as Catalog).ID;
                }
                List<Price> prices = priceBUS.SearchByProduct(searchString, searchCatalog);
                ShowPricesByOption(prices);
            }
            else if (radPriceCombo.Checked)
            {
                List<Price> prices = priceBUS.SearchByCombo(searchString);
                ShowPricesByOption(prices);
            }
        }

        private void lvPrice_ColumnClick(object sender, ColumnClickEventArgs e)
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
            lvPrice.Sort();
        }

        private void lvPriceHistory_ColumnClick(object sender, ColumnClickEventArgs e)
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
            lvPriceHistory.Sort();
        }

        private void btnStorageImport_Click(object sender, EventArgs e)
        {
            string id = txtStorageID.Text;
            int quantity = (int)nmrStorageQuantity.Value;
            if (String.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Vui lòng nhập mã");
                return;
            }

            if (productBUS.ChangeQuantity(id, quantity, true))
            {
                MessageBox.Show("Nhập thành công");
                ShowAllStorage();
            }
            else
            {
                MessageBox.Show("Nhập thất bại\n - Mã không tồn tại");
            }
        }

        private void lvStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStorage.SelectedItems.Count == 0)
            {
                return;
            }
            txtStorageID.Text = (lvStorage.SelectedItems[0].Tag as Product).ID;
        }

        private void btnStorageExport_Click(object sender, EventArgs e)
        {
            string id = txtStorageID.Text;
            int quantity = (int)nmrStorageQuantity.Value;
            if (String.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Vui lòng nhập mã");
                return;
            }

            if (productBUS.ChangeQuantity(id, quantity, false))
            {
                MessageBox.Show("Xuất thành công");
                ShowAllStorage();
            }
            else
            {
                MessageBox.Show("Xuất thất bại\n - Mã không tồn tại\n - Số lượng xuất nhiều hơn số lượng hàng còn");
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
                    
                    if (billDetail.Quantity < quantity)
                    {
                        MessageBox.Show("Không đủ hàng");
                        return;
                    }
                    item.Text = billDetail.Product.ID;
                    item.SubItems.Add(billDetail.Product.Name);
                }
                else if (radSellCombo.Checked)
                {
                    string result = billDetailBUS.CheckQuantityCombo(id, quantity);
                    if (!String.IsNullOrEmpty(result))
                    {
                        MessageBox.Show(result + " trong combo không đủ hàng");
                        return;
                    }
                    item.Text = billDetail.Combo.ID;
                    item.SubItems.Add(billDetail.Combo.Name);
                }
                billDetail.Quantity = quantity;

                item.SubItems.Add(billDetail.Price.Pricez.ToString());
                item.SubItems.Add(quantity.ToString());
                item.SubItems.Add((billDetail.Price.Pricez * quantity).ToString());
                item.Tag = billDetail;
                lvSell.Items.Add(item);

                txtSellTotal.Text = (decimal.Parse(txtSellTotal.Text) + (quantity * billDetail.Price.Pricez)).ToString();
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
            txtSellTotal.Text = (decimal.Parse(txtSellTotal.Text) - (billDetail.Quantity * billDetail.Price.Pricez)).ToString();
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
            List<BillDetail> billDetails = new List<BillDetail>();
            foreach (ListViewItem item in lvSell.Items)
            {
                BillDetail billDetail = item.Tag as BillDetail;
                billDetails.Add(billDetail);
            }

            Bill bill = new Bill
            {
                Account = Session.Account,
                Datetime = DateTime.Now,
                BillDetails = billDetails,
                Status = BillStatus.Tại_cửa_hàng,
                Total = decimal.Parse(txtSellTotal.Text)
            };

            if (billBUS.Add(bill))
            {
                MessageBox.Show("Thanh toán thành công");
                lvSell.Items.Clear();
                txtSellTotal.Text = "0";
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại");
            }
        }

        private void btnStorageSearch_Click(object sender, EventArgs e)
        {
            string searchString = txtStorageSearchString.Text;
            string searchCatalog = cboStorageSearchCatalog.SelectedIndex > 0 ? (cboStorageSearchCatalog.SelectedItem as Catalog).ID : null;

            List<Product> products = productBUS.Search(searchString, searchCatalog);

            ShowStorages(products);
        }

        private void lvStorage_ColumnClick(object sender, ColumnClickEventArgs e)
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
            lvStorage.Sort();
        }
    }
}
