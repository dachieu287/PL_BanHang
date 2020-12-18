
namespace GUI
{
    partial class Manage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Chưa xử lý", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Đang xử lý", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Đang giao", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Đã Giao", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Đã hủy", System.Windows.Forms.HorizontalAlignment.Left);
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpSell = new System.Windows.Forms.TabPage();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btnSellDeteleAll = new System.Windows.Forms.Button();
            this.btnSellDelete = new System.Windows.Forms.Button();
            this.btnSellAdd = new System.Windows.Forms.Button();
            this.txtSellID = new System.Windows.Forms.TextBox();
            this.nmrSellQuantity = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.radSellProduct = new System.Windows.Forms.RadioButton();
            this.radSellCombo = new System.Windows.Forms.RadioButton();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txtSellPhone = new System.Windows.Forms.TextBox();
            this.txtSellAddress = new System.Windows.Forms.TextBox();
            this.txtSellName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSellPay = new System.Windows.Forms.Button();
            this.txtSellTotal = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.lvSell = new System.Windows.Forms.ListView();
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpProduct = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nmrProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.nmrProductPrice = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.picProductImage = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboProductCatalog = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.btnProductRefresh = new System.Windows.Forms.Button();
            this.txtProductDescription = new System.Windows.Forms.RichTextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tên = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lvProduct = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader33 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader34 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.cboProductSearchCatalog = new System.Windows.Forms.ComboBox();
            this.txtProductSearchString = new System.Windows.Forms.TextBox();
            this.tpCombo = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nmrComboDetailQuantity = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnComboDetailDelete = new System.Windows.Forms.Button();
            this.btnComboDetailAdd = new System.Windows.Forms.Button();
            this.txtComboDetailProductID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lvComboDetail = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nmrComboPrice = new System.Windows.Forms.NumericUpDown();
            this.nmrComboDiscount = new System.Windows.Forms.NumericUpDown();
            this.nmrComboPrevPrice = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.picComboImage = new System.Windows.Forms.PictureBox();
            this.btnComboEdit = new System.Windows.Forms.Button();
            this.btnComboDelete = new System.Windows.Forms.Button();
            this.btnComboAdd = new System.Windows.Forms.Button();
            this.btnComboRefresh = new System.Windows.Forms.Button();
            this.txtComboDescription = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComboName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtComboID = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lvCombo = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader35 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnComboSearch = new System.Windows.Forms.Button();
            this.txtComboSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tpCatalog = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCatalogEdit = new System.Windows.Forms.Button();
            this.btnCatalogDelete = new System.Windows.Forms.Button();
            this.btnCatalogAdd = new System.Windows.Forms.Button();
            this.btnCatalogRefresh = new System.Windows.Forms.Button();
            this.txtCatalogName = new System.Windows.Forms.TextBox();
            this.txtCatalogID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lvCatalog = new System.Windows.Forms.ListView();
            this.clhdCatalogID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhdCatalogName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpBill = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtBillName = new System.Windows.Forms.TextBox();
            this.txtBillAddress = new System.Windows.Forms.TextBox();
            this.txtBillPhone = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnBillStatus = new System.Windows.Forms.Button();
            this.radBillCancel = new System.Windows.Forms.RadioButton();
            this.radBillDone = new System.Windows.Forms.RadioButton();
            this.radBillShipping = new System.Windows.Forms.RadioButton();
            this.radBillProccessing = new System.Windows.Forms.RadioButton();
            this.radBillUnprocessed = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.lvBillDetail = new System.Windows.Forms.ListView();
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel19 = new System.Windows.Forms.Panel();
            this.btnBillSearch = new System.Windows.Forms.Button();
            this.nmrBillToTotal = new System.Windows.Forms.NumericUpDown();
            this.nmrBillFromTotal = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.dtpBillSearchToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBillSearchFromDate = new System.Windows.Forms.DateTimePicker();
            this.label29 = new System.Windows.Forms.Label();
            this.txtBillSearchString = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.lvBill = new System.Windows.Forms.ListView();
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ofdProductImage = new System.Windows.Forms.OpenFileDialog();
            this.ofdComboImage = new System.Windows.Forms.OpenFileDialog();
            this.tabMain.SuspendLayout();
            this.tpSell.SuspendLayout();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSellQuantity)).BeginInit();
            this.panel17.SuspendLayout();
            this.tpProduct.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrProductQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrProductPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tpCombo.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrComboDetailQuantity)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrComboPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrComboDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrComboPrevPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComboImage)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tpCatalog.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tpBill.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBillToTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBillFromTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpSell);
            this.tabMain.Controls.Add(this.tpProduct);
            this.tabMain.Controls.Add(this.tpCombo);
            this.tabMain.Controls.Add(this.tpCatalog);
            this.tabMain.Controls.Add(this.tpBill);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(800, 450);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMain.TabIndex = 0;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tpSell
            // 
            this.tpSell.Controls.Add(this.panel18);
            this.tpSell.Controls.Add(this.panel17);
            this.tpSell.Location = new System.Drawing.Point(4, 22);
            this.tpSell.Name = "tpSell";
            this.tpSell.Padding = new System.Windows.Forms.Padding(3);
            this.tpSell.Size = new System.Drawing.Size(792, 424);
            this.tpSell.TabIndex = 0;
            this.tpSell.Text = "Báo giá";
            this.tpSell.UseVisualStyleBackColor = true;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.btnSellDeteleAll);
            this.panel18.Controls.Add(this.btnSellDelete);
            this.panel18.Controls.Add(this.btnSellAdd);
            this.panel18.Controls.Add(this.txtSellID);
            this.panel18.Controls.Add(this.nmrSellQuantity);
            this.panel18.Controls.Add(this.label25);
            this.panel18.Controls.Add(this.label26);
            this.panel18.Controls.Add(this.radSellProduct);
            this.panel18.Controls.Add(this.radSellCombo);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(519, 3);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(270, 418);
            this.panel18.TabIndex = 1;
            // 
            // btnSellDeteleAll
            // 
            this.btnSellDeteleAll.Location = new System.Drawing.Point(106, 284);
            this.btnSellDeteleAll.Name = "btnSellDeteleAll";
            this.btnSellDeteleAll.Size = new System.Drawing.Size(89, 35);
            this.btnSellDeteleAll.TabIndex = 7;
            this.btnSellDeteleAll.Text = "Xóa hết";
            this.btnSellDeteleAll.UseVisualStyleBackColor = true;
            this.btnSellDeteleAll.Click += new System.EventHandler(this.btnSellDeteleAll_Click);
            // 
            // btnSellDelete
            // 
            this.btnSellDelete.Location = new System.Drawing.Point(106, 243);
            this.btnSellDelete.Name = "btnSellDelete";
            this.btnSellDelete.Size = new System.Drawing.Size(89, 35);
            this.btnSellDelete.TabIndex = 7;
            this.btnSellDelete.Text = "Xóa";
            this.btnSellDelete.UseVisualStyleBackColor = true;
            this.btnSellDelete.Click += new System.EventHandler(this.btnSellDelete_Click);
            // 
            // btnSellAdd
            // 
            this.btnSellAdd.Location = new System.Drawing.Point(106, 202);
            this.btnSellAdd.Name = "btnSellAdd";
            this.btnSellAdd.Size = new System.Drawing.Size(89, 35);
            this.btnSellAdd.TabIndex = 7;
            this.btnSellAdd.Text = "Thêm";
            this.btnSellAdd.UseVisualStyleBackColor = true;
            this.btnSellAdd.Click += new System.EventHandler(this.btnSellAdd_Click);
            // 
            // txtSellID
            // 
            this.txtSellID.Location = new System.Drawing.Point(71, 107);
            this.txtSellID.Name = "txtSellID";
            this.txtSellID.Size = new System.Drawing.Size(163, 20);
            this.txtSellID.TabIndex = 4;
            // 
            // nmrSellQuantity
            // 
            this.nmrSellQuantity.Location = new System.Drawing.Point(71, 150);
            this.nmrSellQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrSellQuantity.Name = "nmrSellQuantity";
            this.nmrSellQuantity.Size = new System.Drawing.Size(163, 20);
            this.nmrSellQuantity.TabIndex = 6;
            this.nmrSellQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmrSellQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(40, 110);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(25, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Mã:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(13, 152);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(52, 13);
            this.label26.TabIndex = 5;
            this.label26.Text = "Số lượng:";
            // 
            // radSellProduct
            // 
            this.radSellProduct.AutoSize = true;
            this.radSellProduct.Checked = true;
            this.radSellProduct.Location = new System.Drawing.Point(71, 68);
            this.radSellProduct.Name = "radSellProduct";
            this.radSellProduct.Size = new System.Drawing.Size(73, 17);
            this.radSellProduct.TabIndex = 2;
            this.radSellProduct.TabStop = true;
            this.radSellProduct.Text = "Sản phẩm";
            this.radSellProduct.UseVisualStyleBackColor = true;
            // 
            // radSellCombo
            // 
            this.radSellCombo.AutoSize = true;
            this.radSellCombo.Location = new System.Drawing.Point(176, 68);
            this.radSellCombo.Name = "radSellCombo";
            this.radSellCombo.Size = new System.Drawing.Size(58, 17);
            this.radSellCombo.TabIndex = 3;
            this.radSellCombo.Text = "Combo";
            this.radSellCombo.UseVisualStyleBackColor = true;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.txtSellPhone);
            this.panel17.Controls.Add(this.txtSellAddress);
            this.panel17.Controls.Add(this.txtSellName);
            this.panel17.Controls.Add(this.label18);
            this.panel17.Controls.Add(this.label17);
            this.panel17.Controls.Add(this.label14);
            this.panel17.Controls.Add(this.btnSellPay);
            this.panel17.Controls.Add(this.txtSellTotal);
            this.panel17.Controls.Add(this.label27);
            this.panel17.Controls.Add(this.lvSell);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel17.Location = new System.Drawing.Point(3, 3);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(516, 418);
            this.panel17.TabIndex = 0;
            // 
            // txtSellPhone
            // 
            this.txtSellPhone.Location = new System.Drawing.Point(123, 303);
            this.txtSellPhone.Name = "txtSellPhone";
            this.txtSellPhone.Size = new System.Drawing.Size(272, 20);
            this.txtSellPhone.TabIndex = 7;
            // 
            // txtSellAddress
            // 
            this.txtSellAddress.Location = new System.Drawing.Point(123, 277);
            this.txtSellAddress.Name = "txtSellAddress";
            this.txtSellAddress.Size = new System.Drawing.Size(272, 20);
            this.txtSellAddress.TabIndex = 7;
            // 
            // txtSellName
            // 
            this.txtSellName.Location = new System.Drawing.Point(123, 251);
            this.txtSellName.Name = "txtSellName";
            this.txtSellName.Size = new System.Drawing.Size(272, 20);
            this.txtSellName.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(44, 306);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Số điện thoại:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(74, 280);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Địa chỉ:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(88, 254);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Tên:";
            // 
            // btnSellPay
            // 
            this.btnSellPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellPay.Location = new System.Drawing.Point(123, 347);
            this.btnSellPay.Name = "btnSellPay";
            this.btnSellPay.Size = new System.Drawing.Size(272, 42);
            this.btnSellPay.TabIndex = 3;
            this.btnSellPay.Text = "Lưu";
            this.btnSellPay.UseVisualStyleBackColor = true;
            this.btnSellPay.Click += new System.EventHandler(this.btnSellPay_Click);
            // 
            // txtSellTotal
            // 
            this.txtSellTotal.Location = new System.Drawing.Point(415, 202);
            this.txtSellTotal.Name = "txtSellTotal";
            this.txtSellTotal.ReadOnly = true;
            this.txtSellTotal.Size = new System.Drawing.Size(95, 20);
            this.txtSellTotal.TabIndex = 2;
            this.txtSellTotal.Text = "0";
            this.txtSellTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(347, 205);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(62, 13);
            this.label27.TabIndex = 1;
            this.label27.Text = "Tổng cộng:";
            // 
            // lvSell
            // 
            this.lvSell.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24});
            this.lvSell.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvSell.FullRowSelect = true;
            this.lvSell.HideSelection = false;
            this.lvSell.Location = new System.Drawing.Point(0, 0);
            this.lvSell.MultiSelect = false;
            this.lvSell.Name = "lvSell";
            this.lvSell.Size = new System.Drawing.Size(516, 192);
            this.lvSell.TabIndex = 0;
            this.lvSell.UseCompatibleStateImageBehavior = false;
            this.lvSell.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Mã";
            this.columnHeader20.Width = 50;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Tên";
            this.columnHeader21.Width = 200;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Đơn giá";
            this.columnHeader22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader22.Width = 100;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Số lượng";
            this.columnHeader23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Thành tiền";
            this.columnHeader24.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader24.Width = 100;
            // 
            // tpProduct
            // 
            this.tpProduct.Controls.Add(this.panel2);
            this.tpProduct.Controls.Add(this.panel1);
            this.tpProduct.Location = new System.Drawing.Point(4, 22);
            this.tpProduct.Name = "tpProduct";
            this.tpProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tpProduct.Size = new System.Drawing.Size(792, 424);
            this.tpProduct.TabIndex = 1;
            this.tpProduct.Text = "Sản phẩm";
            this.tpProduct.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nmrProductQuantity);
            this.panel2.Controls.Add(this.nmrProductPrice);
            this.panel2.Controls.Add(this.label34);
            this.panel2.Controls.Add(this.label33);
            this.panel2.Controls.Add(this.picProductImage);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.cboProductCatalog);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnProductDelete);
            this.panel2.Controls.Add(this.btnProductAdd);
            this.panel2.Controls.Add(this.btnProductRefresh);
            this.panel2.Controls.Add(this.txtProductDescription);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtProductID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Tên);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(429, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 418);
            this.panel2.TabIndex = 0;
            // 
            // nmrProductQuantity
            // 
            this.nmrProductQuantity.Location = new System.Drawing.Point(87, 121);
            this.nmrProductQuantity.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nmrProductQuantity.Name = "nmrProductQuantity";
            this.nmrProductQuantity.Size = new System.Drawing.Size(268, 20);
            this.nmrProductQuantity.TabIndex = 18;
            this.nmrProductQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nmrProductPrice
            // 
            this.nmrProductPrice.Location = new System.Drawing.Point(87, 95);
            this.nmrProductPrice.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nmrProductPrice.Name = "nmrProductPrice";
            this.nmrProductPrice.Size = new System.Drawing.Size(268, 20);
            this.nmrProductPrice.TabIndex = 17;
            this.nmrProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(32, 123);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(52, 13);
            this.label34.TabIndex = 16;
            this.label34.Text = "Số lượng:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(37, 97);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(47, 13);
            this.label33.TabIndex = 16;
            this.label33.Text = "Đơn giá:";
            // 
            // picProductImage
            // 
            this.picProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProductImage.Image = global::GUI.Properties.Resources.upload;
            this.picProductImage.Location = new System.Drawing.Point(141, 195);
            this.picProductImage.Name = "picProductImage";
            this.picProductImage.Size = new System.Drawing.Size(150, 150);
            this.picProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProductImage.TabIndex = 15;
            this.picProductImage.TabStop = false;
            this.picProductImage.Click += new System.EventHandler(this.ptbProduct_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 260);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Hình ảnh:";
            // 
            // cboProductCatalog
            // 
            this.cboProductCatalog.FormattingEnabled = true;
            this.cboProductCatalog.Location = new System.Drawing.Point(87, 68);
            this.cboProductCatalog.Name = "cboProductCatalog";
            this.cboProductCatalog.Size = new System.Drawing.Size(268, 21);
            this.cboProductCatalog.TabIndex = 7;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(181, 351);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 41);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Location = new System.Drawing.Point(262, 351);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(75, 41);
            this.btnProductDelete.TabIndex = 12;
            this.btnProductDelete.Text = "Xóa";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(100, 351);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(75, 41);
            this.btnProductAdd.TabIndex = 11;
            this.btnProductAdd.Text = "Thêm";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // btnProductRefresh
            // 
            this.btnProductRefresh.Location = new System.Drawing.Point(19, 351);
            this.btnProductRefresh.Name = "btnProductRefresh";
            this.btnProductRefresh.Size = new System.Drawing.Size(75, 41);
            this.btnProductRefresh.TabIndex = 10;
            this.btnProductRefresh.Text = "Làm mới";
            this.btnProductRefresh.UseVisualStyleBackColor = true;
            this.btnProductRefresh.Click += new System.EventHandler(this.btnProductRefresh_Click);
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(87, 147);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(268, 42);
            this.txtProductDescription.TabIndex = 9;
            this.txtProductDescription.Text = "";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(87, 42);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(268, 20);
            this.txtProductName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mô tả:";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(87, 16);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(268, 20);
            this.txtProductID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Danh mục:";
            // 
            // Tên
            // 
            this.Tên.AutoSize = true;
            this.Tên.Location = new System.Drawing.Point(6, 45);
            this.Tên.Name = "Tên";
            this.Tên.Size = new System.Drawing.Size(78, 13);
            this.Tên.TabIndex = 2;
            this.Tên.Text = "Tên sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 418);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lvProduct);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(426, 356);
            this.panel4.TabIndex = 1;
            // 
            // lvProduct
            // 
            this.lvProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader33,
            this.columnHeader34,
            this.columnHeader4});
            this.lvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProduct.FullRowSelect = true;
            this.lvProduct.HideSelection = false;
            this.lvProduct.Location = new System.Drawing.Point(0, 0);
            this.lvProduct.MultiSelect = false;
            this.lvProduct.Name = "lvProduct";
            this.lvProduct.Size = new System.Drawing.Size(426, 356);
            this.lvProduct.TabIndex = 0;
            this.lvProduct.UseCompatibleStateImageBehavior = false;
            this.lvProduct.View = System.Windows.Forms.View.Details;
            this.lvProduct.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvProduct_ColumnClick);
            this.lvProduct.SelectedIndexChanged += new System.EventHandler(this.lvProduct_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "ProductID";
            this.columnHeader1.Text = "Mã";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "ProductName";
            this.columnHeader2.Text = "Tên";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader33
            // 
            this.columnHeader33.Text = "Đơn giá";
            this.columnHeader33.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader34
            // 
            this.columnHeader34.Text = "Số lượng";
            this.columnHeader34.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Tag = "ProductCatalog";
            this.columnHeader4.Text = "Mã danh mục";
            this.columnHeader4.Width = 80;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnProductSearch);
            this.panel3.Controls.Add(this.cboProductSearchCatalog);
            this.panel3.Controls.Add(this.txtProductSearchString);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(426, 62);
            this.panel3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Danh mục:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm kiếm:";
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.Location = new System.Drawing.Point(334, 4);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(75, 46);
            this.btnProductSearch.TabIndex = 4;
            this.btnProductSearch.Text = "Lọc";
            this.btnProductSearch.UseVisualStyleBackColor = true;
            this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);
            // 
            // cboProductSearchCatalog
            // 
            this.cboProductSearchCatalog.FormattingEnabled = true;
            this.cboProductSearchCatalog.Location = new System.Drawing.Point(66, 29);
            this.cboProductSearchCatalog.Name = "cboProductSearchCatalog";
            this.cboProductSearchCatalog.Size = new System.Drawing.Size(249, 21);
            this.cboProductSearchCatalog.TabIndex = 3;
            // 
            // txtProductSearchString
            // 
            this.txtProductSearchString.Location = new System.Drawing.Point(66, 3);
            this.txtProductSearchString.Name = "txtProductSearchString";
            this.txtProductSearchString.Size = new System.Drawing.Size(249, 20);
            this.txtProductSearchString.TabIndex = 1;
            // 
            // tpCombo
            // 
            this.tpCombo.Controls.Add(this.panel8);
            this.tpCombo.Controls.Add(this.panel7);
            this.tpCombo.Location = new System.Drawing.Point(4, 22);
            this.tpCombo.Name = "tpCombo";
            this.tpCombo.Size = new System.Drawing.Size(792, 424);
            this.tpCombo.TabIndex = 2;
            this.tpCombo.Text = "Combo";
            this.tpCombo.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.groupBox1);
            this.panel8.Controls.Add(this.groupBox2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(406, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(386, 424);
            this.panel8.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nmrComboDetailQuantity);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnComboDetailDelete);
            this.groupBox1.Controls.Add(this.btnComboDetailAdd);
            this.groupBox1.Controls.Add(this.txtComboDetailProductID);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lvComboDetail);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm:";
            // 
            // nmrComboDetailQuantity
            // 
            this.nmrComboDetailQuantity.Location = new System.Drawing.Point(313, 34);
            this.nmrComboDetailQuantity.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nmrComboDetailQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrComboDetailQuantity.Name = "nmrComboDetailQuantity";
            this.nmrComboDetailQuantity.Size = new System.Drawing.Size(65, 20);
            this.nmrComboDetailQuantity.TabIndex = 4;
            this.nmrComboDetailQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrComboDetailQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "SL:";
            // 
            // btnComboDetailDelete
            // 
            this.btnComboDetailDelete.Location = new System.Drawing.Point(303, 90);
            this.btnComboDetailDelete.Name = "btnComboDetailDelete";
            this.btnComboDetailDelete.Size = new System.Drawing.Size(75, 27);
            this.btnComboDetailDelete.TabIndex = 6;
            this.btnComboDetailDelete.Text = "Xóa";
            this.btnComboDetailDelete.UseVisualStyleBackColor = true;
            this.btnComboDetailDelete.Click += new System.EventHandler(this.btnComboDetailDelete_Click);
            // 
            // btnComboDetailAdd
            // 
            this.btnComboDetailAdd.Location = new System.Drawing.Point(303, 60);
            this.btnComboDetailAdd.Name = "btnComboDetailAdd";
            this.btnComboDetailAdd.Size = new System.Drawing.Size(75, 26);
            this.btnComboDetailAdd.TabIndex = 5;
            this.btnComboDetailAdd.Text = "Thêm";
            this.btnComboDetailAdd.UseVisualStyleBackColor = true;
            this.btnComboDetailAdd.Click += new System.EventHandler(this.btnComboDetailAdd_Click);
            // 
            // txtComboDetailProductID
            // 
            this.txtComboDetailProductID.Location = new System.Drawing.Point(313, 13);
            this.txtComboDetailProductID.Name = "txtComboDetailProductID";
            this.txtComboDetailProductID.Size = new System.Drawing.Size(65, 20);
            this.txtComboDetailProductID.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(284, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Mã:";
            // 
            // lvComboDetail
            // 
            this.lvComboDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvComboDetail.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvComboDetail.FullRowSelect = true;
            this.lvComboDetail.HideSelection = false;
            this.lvComboDetail.Location = new System.Drawing.Point(3, 16);
            this.lvComboDetail.MultiSelect = false;
            this.lvComboDetail.Name = "lvComboDetail";
            this.lvComboDetail.Size = new System.Drawing.Size(275, 101);
            this.lvComboDetail.TabIndex = 0;
            this.lvComboDetail.UseCompatibleStateImageBehavior = false;
            this.lvComboDetail.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mã";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tên";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Số lượng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nmrComboPrice);
            this.groupBox2.Controls.Add(this.nmrComboDiscount);
            this.groupBox2.Controls.Add(this.nmrComboPrevPrice);
            this.groupBox2.Controls.Add(this.label37);
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Controls.Add(this.label35);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.picComboImage);
            this.groupBox2.Controls.Add(this.btnComboEdit);
            this.groupBox2.Controls.Add(this.btnComboDelete);
            this.groupBox2.Controls.Add(this.btnComboAdd);
            this.groupBox2.Controls.Add(this.btnComboRefresh);
            this.groupBox2.Controls.Add(this.txtComboDescription);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtComboName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtComboID);
            this.groupBox2.Controls.Add(this.lbl);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 304);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin cơ bản:";
            // 
            // nmrComboPrice
            // 
            this.nmrComboPrice.Location = new System.Drawing.Point(281, 199);
            this.nmrComboPrice.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nmrComboPrice.Name = "nmrComboPrice";
            this.nmrComboPrice.Size = new System.Drawing.Size(97, 20);
            this.nmrComboPrice.TabIndex = 21;
            this.nmrComboPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nmrComboDiscount
            // 
            this.nmrComboDiscount.Location = new System.Drawing.Point(281, 173);
            this.nmrComboDiscount.Name = "nmrComboDiscount";
            this.nmrComboDiscount.Size = new System.Drawing.Size(97, 20);
            this.nmrComboDiscount.TabIndex = 21;
            this.nmrComboDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nmrComboPrevPrice
            // 
            this.nmrComboPrevPrice.Location = new System.Drawing.Point(281, 147);
            this.nmrComboPrevPrice.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nmrComboPrevPrice.Name = "nmrComboPrevPrice";
            this.nmrComboPrevPrice.Size = new System.Drawing.Size(97, 20);
            this.nmrComboPrevPrice.TabIndex = 21;
            this.nmrComboPrevPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(229, 201);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(50, 13);
            this.label37.TabIndex = 20;
            this.label37.Text = "Giá thực:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(197, 175);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(82, 13);
            this.label36.TabIndex = 19;
            this.label36.Text = "Khuyến mãi (%):";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(201, 149);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(78, 13);
            this.label35.TabIndex = 18;
            this.label35.Text = "Giá trước giảm:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 117);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Hình ảnh:";
            // 
            // picComboImage
            // 
            this.picComboImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picComboImage.Image = global::GUI.Properties.Resources.upload;
            this.picComboImage.Location = new System.Drawing.Point(68, 117);
            this.picComboImage.Name = "picComboImage";
            this.picComboImage.Size = new System.Drawing.Size(125, 125);
            this.picComboImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComboImage.TabIndex = 16;
            this.picComboImage.TabStop = false;
            this.picComboImage.Click += new System.EventHandler(this.picComboImage_Click);
            // 
            // btnComboEdit
            // 
            this.btnComboEdit.Location = new System.Drawing.Point(200, 257);
            this.btnComboEdit.Name = "btnComboEdit";
            this.btnComboEdit.Size = new System.Drawing.Size(75, 41);
            this.btnComboEdit.TabIndex = 8;
            this.btnComboEdit.Text = "Sửa";
            this.btnComboEdit.UseVisualStyleBackColor = true;
            this.btnComboEdit.Click += new System.EventHandler(this.btnComboEdit_Click);
            // 
            // btnComboDelete
            // 
            this.btnComboDelete.Location = new System.Drawing.Point(281, 257);
            this.btnComboDelete.Name = "btnComboDelete";
            this.btnComboDelete.Size = new System.Drawing.Size(75, 41);
            this.btnComboDelete.TabIndex = 9;
            this.btnComboDelete.Text = "Xóa";
            this.btnComboDelete.UseVisualStyleBackColor = true;
            this.btnComboDelete.Click += new System.EventHandler(this.btnComboDelete_Click);
            // 
            // btnComboAdd
            // 
            this.btnComboAdd.Location = new System.Drawing.Point(119, 257);
            this.btnComboAdd.Name = "btnComboAdd";
            this.btnComboAdd.Size = new System.Drawing.Size(75, 41);
            this.btnComboAdd.TabIndex = 7;
            this.btnComboAdd.Text = "Thêm";
            this.btnComboAdd.UseVisualStyleBackColor = true;
            this.btnComboAdd.Click += new System.EventHandler(this.btnComboAdd_Click);
            // 
            // btnComboRefresh
            // 
            this.btnComboRefresh.Location = new System.Drawing.Point(38, 257);
            this.btnComboRefresh.Name = "btnComboRefresh";
            this.btnComboRefresh.Size = new System.Drawing.Size(75, 41);
            this.btnComboRefresh.TabIndex = 6;
            this.btnComboRefresh.Text = "Làm mới";
            this.btnComboRefresh.UseVisualStyleBackColor = true;
            this.btnComboRefresh.Click += new System.EventHandler(this.btnComboRefresh_Click);
            // 
            // txtComboDescription
            // 
            this.txtComboDescription.Location = new System.Drawing.Point(68, 70);
            this.txtComboDescription.Name = "txtComboDescription";
            this.txtComboDescription.Size = new System.Drawing.Size(259, 41);
            this.txtComboDescription.TabIndex = 5;
            this.txtComboDescription.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Mô tả:";
            // 
            // txtComboName
            // 
            this.txtComboName.Location = new System.Drawing.Point(68, 44);
            this.txtComboName.Name = "txtComboName";
            this.txtComboName.Size = new System.Drawing.Size(259, 20);
            this.txtComboName.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tên:";
            // 
            // txtComboID
            // 
            this.txtComboID.Location = new System.Drawing.Point(68, 18);
            this.txtComboID.Name = "txtComboID";
            this.txtComboID.Size = new System.Drawing.Size(259, 20);
            this.txtComboID.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(37, 21);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(25, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Mã:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(406, 424);
            this.panel7.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.lvCombo);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 44);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(406, 380);
            this.panel10.TabIndex = 1;
            // 
            // lvCombo
            // 
            this.lvCombo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader35});
            this.lvCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCombo.FullRowSelect = true;
            this.lvCombo.HideSelection = false;
            this.lvCombo.Location = new System.Drawing.Point(0, 0);
            this.lvCombo.MultiSelect = false;
            this.lvCombo.Name = "lvCombo";
            this.lvCombo.Size = new System.Drawing.Size(406, 380);
            this.lvCombo.TabIndex = 0;
            this.lvCombo.UseCompatibleStateImageBehavior = false;
            this.lvCombo.View = System.Windows.Forms.View.Details;
            this.lvCombo.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvCombo_ColumnClick);
            this.lvCombo.SelectedIndexChanged += new System.EventHandler(this.lvCombo_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Tag = "ComboID";
            this.columnHeader3.Text = "Mã";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Tag = "ComboName";
            this.columnHeader7.Text = "Tên";
            this.columnHeader7.Width = 200;
            // 
            // columnHeader35
            // 
            this.columnHeader35.Text = "Giá";
            this.columnHeader35.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader35.Width = 100;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnComboSearch);
            this.panel9.Controls.Add(this.txtComboSearch);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(406, 44);
            this.panel9.TabIndex = 0;
            // 
            // btnComboSearch
            // 
            this.btnComboSearch.Location = new System.Drawing.Point(310, 7);
            this.btnComboSearch.Name = "btnComboSearch";
            this.btnComboSearch.Size = new System.Drawing.Size(75, 30);
            this.btnComboSearch.TabIndex = 2;
            this.btnComboSearch.Text = "Lọc";
            this.btnComboSearch.UseVisualStyleBackColor = true;
            this.btnComboSearch.Click += new System.EventHandler(this.btnComboSearch_Click);
            // 
            // txtComboSearch
            // 
            this.txtComboSearch.Location = new System.Drawing.Point(66, 13);
            this.txtComboSearch.Name = "txtComboSearch";
            this.txtComboSearch.Size = new System.Drawing.Size(227, 20);
            this.txtComboSearch.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tìm kiếm:";
            // 
            // tpCatalog
            // 
            this.tpCatalog.Controls.Add(this.panel6);
            this.tpCatalog.Controls.Add(this.panel5);
            this.tpCatalog.Location = new System.Drawing.Point(4, 22);
            this.tpCatalog.Name = "tpCatalog";
            this.tpCatalog.Size = new System.Drawing.Size(792, 424);
            this.tpCatalog.TabIndex = 3;
            this.tpCatalog.Text = "Danh mục";
            this.tpCatalog.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnCatalogEdit);
            this.panel6.Controls.Add(this.btnCatalogDelete);
            this.panel6.Controls.Add(this.btnCatalogAdd);
            this.panel6.Controls.Add(this.btnCatalogRefresh);
            this.panel6.Controls.Add(this.txtCatalogName);
            this.panel6.Controls.Add(this.txtCatalogID);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(374, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(418, 424);
            this.panel6.TabIndex = 0;
            // 
            // btnCatalogEdit
            // 
            this.btnCatalogEdit.Location = new System.Drawing.Point(210, 105);
            this.btnCatalogEdit.Name = "btnCatalogEdit";
            this.btnCatalogEdit.Size = new System.Drawing.Size(75, 41);
            this.btnCatalogEdit.TabIndex = 6;
            this.btnCatalogEdit.Text = "Sửa";
            this.btnCatalogEdit.UseVisualStyleBackColor = true;
            this.btnCatalogEdit.Click += new System.EventHandler(this.btnCatalogEdit_Click);
            // 
            // btnCatalogDelete
            // 
            this.btnCatalogDelete.Location = new System.Drawing.Point(291, 105);
            this.btnCatalogDelete.Name = "btnCatalogDelete";
            this.btnCatalogDelete.Size = new System.Drawing.Size(75, 41);
            this.btnCatalogDelete.TabIndex = 7;
            this.btnCatalogDelete.Text = "Xóa";
            this.btnCatalogDelete.UseVisualStyleBackColor = true;
            this.btnCatalogDelete.Click += new System.EventHandler(this.btnCatalogDelete_Click);
            // 
            // btnCatalogAdd
            // 
            this.btnCatalogAdd.Location = new System.Drawing.Point(129, 105);
            this.btnCatalogAdd.Name = "btnCatalogAdd";
            this.btnCatalogAdd.Size = new System.Drawing.Size(75, 41);
            this.btnCatalogAdd.TabIndex = 5;
            this.btnCatalogAdd.Text = "Thêm";
            this.btnCatalogAdd.UseVisualStyleBackColor = true;
            this.btnCatalogAdd.Click += new System.EventHandler(this.btnCatalogAdd_Click);
            // 
            // btnCatalogRefresh
            // 
            this.btnCatalogRefresh.Location = new System.Drawing.Point(48, 105);
            this.btnCatalogRefresh.Name = "btnCatalogRefresh";
            this.btnCatalogRefresh.Size = new System.Drawing.Size(75, 41);
            this.btnCatalogRefresh.TabIndex = 4;
            this.btnCatalogRefresh.Text = "Làm mới";
            this.btnCatalogRefresh.UseVisualStyleBackColor = true;
            this.btnCatalogRefresh.Click += new System.EventHandler(this.btnCatalogRefresh_Click);
            // 
            // txtCatalogName
            // 
            this.txtCatalogName.Location = new System.Drawing.Point(105, 57);
            this.txtCatalogName.Name = "txtCatalogName";
            this.txtCatalogName.Size = new System.Drawing.Size(233, 20);
            this.txtCatalogName.TabIndex = 3;
            // 
            // txtCatalogID
            // 
            this.txtCatalogID.Location = new System.Drawing.Point(105, 22);
            this.txtCatalogID.Name = "txtCatalogID";
            this.txtCatalogID.Size = new System.Drawing.Size(233, 20);
            this.txtCatalogID.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lvCatalog);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(374, 424);
            this.panel5.TabIndex = 0;
            // 
            // lvCatalog
            // 
            this.lvCatalog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhdCatalogID,
            this.clhdCatalogName});
            this.lvCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCatalog.FullRowSelect = true;
            this.lvCatalog.HideSelection = false;
            this.lvCatalog.Location = new System.Drawing.Point(0, 0);
            this.lvCatalog.MultiSelect = false;
            this.lvCatalog.Name = "lvCatalog";
            this.lvCatalog.Size = new System.Drawing.Size(374, 424);
            this.lvCatalog.TabIndex = 0;
            this.lvCatalog.UseCompatibleStateImageBehavior = false;
            this.lvCatalog.View = System.Windows.Forms.View.Details;
            this.lvCatalog.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvCatalog_ColumnClick);
            this.lvCatalog.SelectedIndexChanged += new System.EventHandler(this.lvCatalog_SelectedIndexChanged);
            // 
            // clhdCatalogID
            // 
            this.clhdCatalogID.Tag = "CatalogID";
            this.clhdCatalogID.Text = "Mã";
            this.clhdCatalogID.Width = 70;
            // 
            // clhdCatalogName
            // 
            this.clhdCatalogName.Tag = "CatalogName";
            this.clhdCatalogName.Text = "Tên";
            this.clhdCatalogName.Width = 300;
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.groupBox6);
            this.tpBill.Controls.Add(this.panel19);
            this.tpBill.Location = new System.Drawing.Point(4, 22);
            this.tpBill.Name = "tpBill";
            this.tpBill.Size = new System.Drawing.Size(792, 424);
            this.tpBill.TabIndex = 4;
            this.tpBill.Text = "Đơn hàng";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtBillName);
            this.groupBox6.Controls.Add(this.txtBillAddress);
            this.groupBox6.Controls.Add(this.txtBillPhone);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.btnBillStatus);
            this.groupBox6.Controls.Add(this.radBillCancel);
            this.groupBox6.Controls.Add(this.radBillDone);
            this.groupBox6.Controls.Add(this.radBillShipping);
            this.groupBox6.Controls.Add(this.radBillProccessing);
            this.groupBox6.Controls.Add(this.radBillUnprocessed);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.lvBillDetail);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(424, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(368, 424);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Danh sách:";
            // 
            // txtBillName
            // 
            this.txtBillName.Location = new System.Drawing.Point(105, 216);
            this.txtBillName.Name = "txtBillName";
            this.txtBillName.Size = new System.Drawing.Size(217, 20);
            this.txtBillName.TabIndex = 7;
            // 
            // txtBillAddress
            // 
            this.txtBillAddress.Location = new System.Drawing.Point(105, 242);
            this.txtBillAddress.Name = "txtBillAddress";
            this.txtBillAddress.Size = new System.Drawing.Size(217, 20);
            this.txtBillAddress.TabIndex = 7;
            // 
            // txtBillPhone
            // 
            this.txtBillPhone.Location = new System.Drawing.Point(105, 268);
            this.txtBillPhone.Name = "txtBillPhone";
            this.txtBillPhone.Size = new System.Drawing.Size(217, 20);
            this.txtBillPhone.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(28, 271);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Số điện thoại:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(58, 245);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "Địa chỉ:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(72, 219);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Tên:";
            // 
            // btnBillStatus
            // 
            this.btnBillStatus.Location = new System.Drawing.Point(247, 332);
            this.btnBillStatus.Name = "btnBillStatus";
            this.btnBillStatus.Size = new System.Drawing.Size(75, 51);
            this.btnBillStatus.TabIndex = 3;
            this.btnBillStatus.Text = "Lưu";
            this.btnBillStatus.UseVisualStyleBackColor = true;
            this.btnBillStatus.Click += new System.EventHandler(this.btnBillStatus_Click);
            // 
            // radBillCancel
            // 
            this.radBillCancel.AutoSize = true;
            this.radBillCancel.Location = new System.Drawing.Point(105, 401);
            this.radBillCancel.Name = "radBillCancel";
            this.radBillCancel.Size = new System.Drawing.Size(59, 17);
            this.radBillCancel.TabIndex = 2;
            this.radBillCancel.TabStop = true;
            this.radBillCancel.Text = "Đã hủy";
            this.radBillCancel.UseVisualStyleBackColor = true;
            // 
            // radBillDone
            // 
            this.radBillDone.AutoSize = true;
            this.radBillDone.Location = new System.Drawing.Point(105, 378);
            this.radBillDone.Name = "radBillDone";
            this.radBillDone.Size = new System.Drawing.Size(62, 17);
            this.radBillDone.TabIndex = 2;
            this.radBillDone.TabStop = true;
            this.radBillDone.Text = "Đã giao";
            this.radBillDone.UseVisualStyleBackColor = true;
            // 
            // radBillShipping
            // 
            this.radBillShipping.AutoSize = true;
            this.radBillShipping.Location = new System.Drawing.Point(105, 355);
            this.radBillShipping.Name = "radBillShipping";
            this.radBillShipping.Size = new System.Drawing.Size(74, 17);
            this.radBillShipping.TabIndex = 2;
            this.radBillShipping.TabStop = true;
            this.radBillShipping.Text = "Đang giao";
            this.radBillShipping.UseVisualStyleBackColor = true;
            // 
            // radBillProccessing
            // 
            this.radBillProccessing.AutoSize = true;
            this.radBillProccessing.Location = new System.Drawing.Point(105, 332);
            this.radBillProccessing.Name = "radBillProccessing";
            this.radBillProccessing.Size = new System.Drawing.Size(75, 17);
            this.radBillProccessing.TabIndex = 2;
            this.radBillProccessing.TabStop = true;
            this.radBillProccessing.Text = "Đang xử lý";
            this.radBillProccessing.UseVisualStyleBackColor = true;
            // 
            // radBillUnprocessed
            // 
            this.radBillUnprocessed.AutoSize = true;
            this.radBillUnprocessed.Location = new System.Drawing.Point(105, 309);
            this.radBillUnprocessed.Name = "radBillUnprocessed";
            this.radBillUnprocessed.Size = new System.Drawing.Size(74, 17);
            this.radBillUnprocessed.TabIndex = 2;
            this.radBillUnprocessed.TabStop = true;
            this.radBillUnprocessed.Text = "Chưa xử lý";
            this.radBillUnprocessed.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 351);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Trạng thái:";
            // 
            // lvBillDetail
            // 
            this.lvBillDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader29,
            this.columnHeader30,
            this.columnHeader31,
            this.columnHeader32});
            this.lvBillDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvBillDetail.FullRowSelect = true;
            this.lvBillDetail.HideSelection = false;
            this.lvBillDetail.Location = new System.Drawing.Point(3, 16);
            this.lvBillDetail.MultiSelect = false;
            this.lvBillDetail.Name = "lvBillDetail";
            this.lvBillDetail.Size = new System.Drawing.Size(362, 177);
            this.lvBillDetail.TabIndex = 0;
            this.lvBillDetail.UseCompatibleStateImageBehavior = false;
            this.lvBillDetail.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "Mã";
            this.columnHeader29.Width = 50;
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "Tên";
            this.columnHeader30.Width = 145;
            // 
            // columnHeader31
            // 
            this.columnHeader31.Text = "Giá";
            this.columnHeader31.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader31.Width = 100;
            // 
            // columnHeader32
            // 
            this.columnHeader32.Text = "Số lượng";
            this.columnHeader32.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.btnBillSearch);
            this.panel19.Controls.Add(this.nmrBillToTotal);
            this.panel19.Controls.Add(this.nmrBillFromTotal);
            this.panel19.Controls.Add(this.label32);
            this.panel19.Controls.Add(this.label31);
            this.panel19.Controls.Add(this.label30);
            this.panel19.Controls.Add(this.dtpBillSearchToDate);
            this.panel19.Controls.Add(this.dtpBillSearchFromDate);
            this.panel19.Controls.Add(this.label29);
            this.panel19.Controls.Add(this.txtBillSearchString);
            this.panel19.Controls.Add(this.label28);
            this.panel19.Controls.Add(this.lvBill);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel19.Location = new System.Drawing.Point(0, 0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(424, 424);
            this.panel19.TabIndex = 0;
            // 
            // btnBillSearch
            // 
            this.btnBillSearch.Location = new System.Drawing.Point(346, 11);
            this.btnBillSearch.Name = "btnBillSearch";
            this.btnBillSearch.Size = new System.Drawing.Size(75, 57);
            this.btnBillSearch.TabIndex = 10;
            this.btnBillSearch.Text = "Lọc";
            this.btnBillSearch.UseVisualStyleBackColor = true;
            this.btnBillSearch.Click += new System.EventHandler(this.btnBillSearch_Click);
            // 
            // nmrBillToTotal
            // 
            this.nmrBillToTotal.Location = new System.Drawing.Point(230, 57);
            this.nmrBillToTotal.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nmrBillToTotal.Name = "nmrBillToTotal";
            this.nmrBillToTotal.Size = new System.Drawing.Size(110, 20);
            this.nmrBillToTotal.TabIndex = 9;
            this.nmrBillToTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmrBillToTotal.Value = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            // 
            // nmrBillFromTotal
            // 
            this.nmrBillFromTotal.Location = new System.Drawing.Point(230, 31);
            this.nmrBillFromTotal.Name = "nmrBillFromTotal";
            this.nmrBillFromTotal.Size = new System.Drawing.Size(110, 20);
            this.nmrBillFromTotal.TabIndex = 9;
            this.nmrBillFromTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(192, 64);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(39, 13);
            this.label32.TabIndex = 8;
            this.label32.Text = "Đến $:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(199, 37);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(32, 13);
            this.label31.TabIndex = 7;
            this.label31.Text = "Từ $:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(8, 64);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(56, 13);
            this.label30.TabIndex = 6;
            this.label30.Text = "Đến ngày:";
            // 
            // dtpBillSearchToDate
            // 
            this.dtpBillSearchToDate.Checked = false;
            this.dtpBillSearchToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpBillSearchToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBillSearchToDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpBillSearchToDate.Location = new System.Drawing.Point(74, 57);
            this.dtpBillSearchToDate.Name = "dtpBillSearchToDate";
            this.dtpBillSearchToDate.ShowCheckBox = true;
            this.dtpBillSearchToDate.Size = new System.Drawing.Size(112, 20);
            this.dtpBillSearchToDate.TabIndex = 5;
            this.dtpBillSearchToDate.Value = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            // 
            // dtpBillSearchFromDate
            // 
            this.dtpBillSearchFromDate.Checked = false;
            this.dtpBillSearchFromDate.CustomFormat = "dd/MM/yyy";
            this.dtpBillSearchFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBillSearchFromDate.Location = new System.Drawing.Point(74, 31);
            this.dtpBillSearchFromDate.Name = "dtpBillSearchFromDate";
            this.dtpBillSearchFromDate.ShowCheckBox = true;
            this.dtpBillSearchFromDate.Size = new System.Drawing.Size(112, 20);
            this.dtpBillSearchFromDate.TabIndex = 4;
            this.dtpBillSearchFromDate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(15, 37);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(49, 13);
            this.label29.TabIndex = 3;
            this.label29.Text = "Từ ngày:";
            // 
            // txtBillSearchString
            // 
            this.txtBillSearchString.Location = new System.Drawing.Point(74, 4);
            this.txtBillSearchString.Name = "txtBillSearchString";
            this.txtBillSearchString.Size = new System.Drawing.Size(266, 20);
            this.txtBillSearchString.TabIndex = 2;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(12, 7);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(52, 13);
            this.label28.TabIndex = 1;
            this.label28.Text = "Tìm kiếm:";
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27,
            this.columnHeader28});
            this.lvBill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvBill.FullRowSelect = true;
            listViewGroup1.Header = "Chưa xử lý";
            listViewGroup1.Name = "lvgUnprocessed";
            listViewGroup2.Header = "Đang xử lý";
            listViewGroup2.Name = "lvgProcessing";
            listViewGroup3.Header = "Đang giao";
            listViewGroup3.Name = "lvgShipping";
            listViewGroup4.Header = "Đã Giao";
            listViewGroup4.Name = "lvgDone";
            listViewGroup5.Header = "Đã hủy";
            listViewGroup5.Name = "lvgCancel";
            this.lvBill.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
            this.lvBill.HideSelection = false;
            this.lvBill.Location = new System.Drawing.Point(0, 90);
            this.lvBill.MultiSelect = false;
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(424, 334);
            this.lvBill.TabIndex = 0;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            this.lvBill.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvBill_ColumnClick);
            this.lvBill.SelectedIndexChanged += new System.EventHandler(this.lvBill_SelectedIndexChanged);
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Mã";
            this.columnHeader25.Width = 50;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Tên KH";
            this.columnHeader26.Width = 150;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Thời gian";
            this.columnHeader27.Width = 120;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Tổng tiền";
            this.columnHeader28.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader28.Width = 100;
            // 
            // ofdProductImage
            // 
            this.ofdProductImage.Filter = "Image|*.jpg;*.jpeg;*.png";
            // 
            // ofdComboImage
            // 
            this.ofdComboImage.Filter = "Image|*.jpg;*.jpeg;*.png";
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabMain);
            this.Name = "Manage";
            this.Text = "Manage";
            this.tabMain.ResumeLayout(false);
            this.tpSell.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSellQuantity)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.tpProduct.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrProductQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrProductPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tpCombo.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrComboDetailQuantity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrComboPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrComboDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrComboPrevPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComboImage)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.tpCatalog.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.tpBill.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBillToTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBillFromTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpSell;
        private System.Windows.Forms.TabPage tpProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lvProduct;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tpCombo;
        private System.Windows.Forms.TabPage tpCatalog;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboProductCatalog;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Button btnProductRefresh;
        private System.Windows.Forms.RichTextBox txtProductDescription;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Tên;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.ComboBox cboProductSearchCatalog;
        private System.Windows.Forms.TextBox txtProductSearchString;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnCatalogEdit;
        private System.Windows.Forms.Button btnCatalogDelete;
        private System.Windows.Forms.Button btnCatalogAdd;
        private System.Windows.Forms.Button btnCatalogRefresh;
        private System.Windows.Forms.TextBox txtCatalogName;
        private System.Windows.Forms.TextBox txtCatalogID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView lvCatalog;
        private System.Windows.Forms.ColumnHeader clhdCatalogID;
        private System.Windows.Forms.ColumnHeader clhdCatalogName;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnComboDetailAdd;
        private System.Windows.Forms.TextBox txtComboDetailProductID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView lvComboDetail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnComboEdit;
        private System.Windows.Forms.Button btnComboDelete;
        private System.Windows.Forms.Button btnComboAdd;
        private System.Windows.Forms.Button btnComboRefresh;
        private System.Windows.Forms.RichTextBox txtComboDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtComboName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtComboID;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ListView lvCombo;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnComboSearch;
        private System.Windows.Forms.TextBox txtComboSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnComboDetailDelete;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmrComboDetailQuantity;
        private System.Windows.Forms.PictureBox picProductImage;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.OpenFileDialog ofdProductImage;
        private System.Windows.Forms.PictureBox picComboImage;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.OpenFileDialog ofdComboImage;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button btnSellAdd;
        private System.Windows.Forms.TextBox txtSellID;
        private System.Windows.Forms.NumericUpDown nmrSellQuantity;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.RadioButton radSellProduct;
        private System.Windows.Forms.RadioButton radSellCombo;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ListView lvSell;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.TextBox txtSellTotal;
        private System.Windows.Forms.Button btnSellDeteleAll;
        private System.Windows.Forms.Button btnSellDelete;
        private System.Windows.Forms.Button btnSellPay;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DateTimePicker dtpBillSearchFromDate;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtBillSearchString;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnBillSearch;
        private System.Windows.Forms.NumericUpDown nmrBillToTotal;
        private System.Windows.Forms.NumericUpDown nmrBillFromTotal;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DateTimePicker dtpBillSearchToDate;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListView lvBillDetail;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.ColumnHeader columnHeader31;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ColumnHeader columnHeader33;
        private System.Windows.Forms.ColumnHeader columnHeader34;
        private System.Windows.Forms.NumericUpDown nmrProductQuantity;
        private System.Windows.Forms.NumericUpDown nmrProductPrice;
        private System.Windows.Forms.NumericUpDown nmrComboPrice;
        private System.Windows.Forms.NumericUpDown nmrComboDiscount;
        private System.Windows.Forms.NumericUpDown nmrComboPrevPrice;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ColumnHeader columnHeader35;
        private System.Windows.Forms.Button btnBillStatus;
        private System.Windows.Forms.RadioButton radBillCancel;
        private System.Windows.Forms.RadioButton radBillDone;
        private System.Windows.Forms.RadioButton radBillShipping;
        private System.Windows.Forms.RadioButton radBillProccessing;
        private System.Windows.Forms.RadioButton radBillUnprocessed;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSellPhone;
        private System.Windows.Forms.TextBox txtSellAddress;
        private System.Windows.Forms.TextBox txtSellName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBillName;
        private System.Windows.Forms.TextBox txtBillAddress;
        private System.Windows.Forms.TextBox txtBillPhone;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
    }
}