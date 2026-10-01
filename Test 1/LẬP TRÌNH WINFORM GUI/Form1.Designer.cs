
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace BaiTest1
{
    partial class Form1
    {
    private IContainer components = null;

    private MenuStrip menuStrip1;
    private ToolStripMenuItem mnuFile;
    private ToolStripMenuItem mnuExportCsv;
    private ToolStripMenuItem mnuExit;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel lblStatus;

    private TableLayoutPanel tlpMain;
    private GroupBox grpInput;
    private TableLayoutPanel tlpInput;
    private Label lblProductId;
    private Label lblProductName;
    private Label lblCategory;
    private Label lblUnitPrice;
    private Label lblQuantity;
    private TextBox txtProductId;
    private TextBox txtProductName;
    private ComboBox cboCategory;
    private TextBox txtUnitPrice;
    private TextBox txtQuantity;
    private Button btnChooseImage;
    private PictureBox picAvatar;
    private FlowLayoutPanel flpButtons;
    private Button btnAdd;
    private Button btnUpdate;
    private Button btnDelete;
    private Button btnClear;
    private Button btnExport;

    private GroupBox grpData;
    private TableLayoutPanel tlpRight;
    private Label lblSearch;
    private TextBox txtSearch;
    private DataGridView dgvProducts;
    private DataGridViewTextBoxColumn colProductId;
    private DataGridViewTextBoxColumn colProductName;
    private DataGridViewTextBoxColumn colCategory;
    private DataGridViewTextBoxColumn colUnitPrice;
    private DataGridViewTextBoxColumn colQuantity;

    private ErrorProvider errorProvider;
    private BindingSource bs;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new Container();
        DataGridViewCellStyle styleAlt = new DataGridViewCellStyle();
        DataGridViewCellStyle stylePrice = new DataGridViewCellStyle();
        DataGridViewCellStyle styleQty = new DataGridViewCellStyle();

        menuStrip1 = new MenuStrip();
        mnuFile = new ToolStripMenuItem();
        mnuExportCsv = new ToolStripMenuItem();
        mnuExit = new ToolStripMenuItem();
        statusStrip1 = new StatusStrip();
        lblStatus = new ToolStripStatusLabel();
        tlpMain = new TableLayoutPanel();
        grpInput = new GroupBox();
        tlpInput = new TableLayoutPanel();
        lblProductId = new Label();
        lblProductName = new Label();
        lblCategory = new Label();
        lblUnitPrice = new Label();
        lblQuantity = new Label();
        txtProductId = new TextBox();
        txtProductName = new TextBox();
        cboCategory = new ComboBox();
        txtUnitPrice = new TextBox();
        txtQuantity = new TextBox();
        btnChooseImage = new Button();
        picAvatar = new PictureBox();
        flpButtons = new FlowLayoutPanel();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnClear = new Button();
        btnExport = new Button();
        grpData = new GroupBox();
        tlpRight = new TableLayoutPanel();
        lblSearch = new Label();
        txtSearch = new TextBox();
        dgvProducts = new DataGridView();
        colProductId = new DataGridViewTextBoxColumn();
        colProductName = new DataGridViewTextBoxColumn();
        colCategory = new DataGridViewTextBoxColumn();
        colUnitPrice = new DataGridViewTextBoxColumn();
        colQuantity = new DataGridViewTextBoxColumn();
        errorProvider = new ErrorProvider(components);
        bs = new BindingSource(components);

        menuStrip1.SuspendLayout();
        statusStrip1.SuspendLayout();
        tlpMain.SuspendLayout();
        grpInput.SuspendLayout();
        tlpInput.SuspendLayout();
        ((ISupportInitialize)picAvatar).BeginInit();
        flpButtons.SuspendLayout();
        grpData.SuspendLayout();
        tlpRight.SuspendLayout();
        ((ISupportInitialize)dgvProducts).BeginInit();
        ((ISupportInitialize)errorProvider).BeginInit();
        ((ISupportInitialize)bs).BeginInit();
        SuspendLayout();

        menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile });
        menuStrip1.Name = "menuStrip1";

        mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuExportCsv, mnuExit });
        mnuFile.Name = "mnuFile";
        mnuFile.Text = "&File";

        mnuExportCsv.Name = "mnuExportCsv";
        mnuExportCsv.ShortcutKeys = Keys.Control | Keys.E;
        mnuExportCsv.Text = "Export CSV";
        mnuExportCsv.Click += mnuExportCsv_Click;

        mnuExit.Name = "mnuExit";
        mnuExit.ShortcutKeys = Keys.Control | Keys.X;
        mnuExit.Text = "Exit";
        mnuExit.Click += mnuExit_Click;

        statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
        statusStrip1.Name = "statusStrip1";

        lblStatus.Name = "lblStatus";
        lblStatus.Text = "Tổng số sản phẩm: 0";

        tlpMain.ColumnCount = 2;
        tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
        tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
        tlpMain.Controls.Add(grpInput, 0, 0);
        tlpMain.Controls.Add(grpData, 1, 0);
        tlpMain.Dock = DockStyle.Fill;
        tlpMain.Name = "tlpMain";
        tlpMain.Padding = new Padding(8);
        tlpMain.RowCount = 1;
        tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

        grpInput.Controls.Add(tlpInput);
        grpInput.Dock = DockStyle.Fill;
        grpInput.Name = "grpInput";
        grpInput.Padding = new Padding(8);
        grpInput.Text = "Thông tin sản phẩm";

        tlpInput.ColumnCount = 2;
        tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
        tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68F));
        tlpInput.Controls.Add(lblProductId, 0, 0);
        tlpInput.Controls.Add(txtProductId, 1, 0);
        tlpInput.Controls.Add(lblProductName, 0, 1);
        tlpInput.Controls.Add(txtProductName, 1, 1);
        tlpInput.Controls.Add(lblCategory, 0, 2);
        tlpInput.Controls.Add(cboCategory, 1, 2);
        tlpInput.Controls.Add(lblUnitPrice, 0, 3);
        tlpInput.Controls.Add(txtUnitPrice, 1, 3);
        tlpInput.Controls.Add(lblQuantity, 0, 4);
        tlpInput.Controls.Add(txtQuantity, 1, 4);
        tlpInput.Controls.Add(btnChooseImage, 0, 5);
        tlpInput.Controls.Add(picAvatar, 1, 5);
        tlpInput.Controls.Add(flpButtons, 0, 6);
        tlpInput.SetColumnSpan(flpButtons, 2);
        tlpInput.Dock = DockStyle.Fill;
        tlpInput.Name = "tlpInput";
        tlpInput.RowCount = 7;
        tlpInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tlpInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tlpInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tlpInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tlpInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpInput.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        lblProductId.Dock = DockStyle.Fill;
        lblProductId.Name = "lblProductId";
        lblProductId.Text = "Mã SP:";
        lblProductId.TextAlign = ContentAlignment.MiddleLeft;

        txtProductId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtProductId.Margin = new Padding(3, 8, 3, 8);
        txtProductId.Name = "txtProductId";

        lblProductName.Dock = DockStyle.Fill;
        lblProductName.Name = "lblProductName";
        lblProductName.Text = "Tên SP:";
        lblProductName.TextAlign = ContentAlignment.MiddleLeft;

        txtProductName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtProductName.Margin = new Padding(3, 8, 3, 8);
        txtProductName.Name = "txtProductName";

        lblCategory.Dock = DockStyle.Fill;
        lblCategory.Name = "lblCategory";
        lblCategory.Text = "Danh mục:";
        lblCategory.TextAlign = ContentAlignment.MiddleLeft;

        cboCategory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        cboCategory.Margin = new Padding(3, 8, 3, 8);
        cboCategory.Name = "cboCategory";

        lblUnitPrice.Dock = DockStyle.Fill;
        lblUnitPrice.Name = "lblUnitPrice";
        lblUnitPrice.Text = "Đơn giá:";
        lblUnitPrice.TextAlign = ContentAlignment.MiddleLeft;

        txtUnitPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtUnitPrice.Margin = new Padding(3, 8, 3, 8);
        txtUnitPrice.Name = "txtUnitPrice";

        lblQuantity.Dock = DockStyle.Fill;
        lblQuantity.Name = "lblQuantity";
        lblQuantity.Text = "Số lượng:";
        lblQuantity.TextAlign = ContentAlignment.MiddleLeft;

        txtQuantity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtQuantity.Margin = new Padding(3, 8, 3, 8);
        txtQuantity.Name = "txtQuantity";

        btnChooseImage.Dock = DockStyle.Top;
        btnChooseImage.Name = "btnChooseImage";
        btnChooseImage.Size = new Size(100, 32);
        btnChooseImage.Text = "Chọn ảnh...";
        btnChooseImage.UseVisualStyleBackColor = true;
        btnChooseImage.Click += BtnChooseImage_Click;

        picAvatar.BorderStyle = BorderStyle.FixedSingle;
        picAvatar.Dock = DockStyle.Fill;
        picAvatar.Margin = new Padding(3, 6, 3, 6);
        picAvatar.Name = "picAvatar";
        picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
        picAvatar.TabStop = false;

        flpButtons.AutoSize = true;
        flpButtons.Controls.Add(btnAdd);
        flpButtons.Controls.Add(btnUpdate);
        flpButtons.Controls.Add(btnDelete);
        flpButtons.Controls.Add(btnClear);
        flpButtons.Controls.Add(btnExport);
        flpButtons.Dock = DockStyle.Fill;
        flpButtons.FlowDirection = FlowDirection.LeftToRight;
        flpButtons.Name = "flpButtons";
        flpButtons.WrapContents = true;

        btnAdd.Margin = new Padding(3);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(80, 32);
        btnAdd.Text = "Thêm";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += BtnAdd_Click;

        btnUpdate.Margin = new Padding(3);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(80, 32);
        btnUpdate.Text = "Cập nhật";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += BtnUpdate_Click;

        btnDelete.Margin = new Padding(3);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(80, 32);
        btnDelete.Text = "Xóa";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += BtnDelete_Click;

        btnClear.Margin = new Padding(3);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(80, 32);
        btnClear.Text = "Làm mới";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += btnClear_Click;

        btnExport.Margin = new Padding(3);
        btnExport.Name = "btnExport";
        btnExport.Size = new Size(80, 32);
        btnExport.Text = "Xuất CSV";
        btnExport.UseVisualStyleBackColor = true;
        btnExport.Click += btnExport_Click;

        grpData.Controls.Add(tlpRight);
        grpData.Dock = DockStyle.Fill;
        grpData.Name = "grpData";
        grpData.Padding = new Padding(8);
        grpData.Text = "Danh sách sản phẩm";

    
        tlpRight.ColumnCount = 2;
        tlpRight.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
        tlpRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tlpRight.Controls.Add(lblSearch, 0, 0);
        tlpRight.Controls.Add(txtSearch, 1, 0);
        tlpRight.Controls.Add(dgvProducts, 0, 1);
        tlpRight.SetColumnSpan(dgvProducts, 2);
        tlpRight.Dock = DockStyle.Fill;
        tlpRight.Name = "tlpRight";
        tlpRight.RowCount = 2;
        tlpRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
        tlpRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

        lblSearch.Dock = DockStyle.Fill;
        lblSearch.Name = "lblSearch";
        lblSearch.Text = "Tìm kiếm:";
        lblSearch.TextAlign = ContentAlignment.MiddleLeft;

        txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtSearch.Margin = new Padding(3, 6, 3, 6);
        txtSearch.Name = "txtSearch";
        txtSearch.TextChanged += txtSearch_TextChanged;

        styleAlt.BackColor = Color.WhiteSmoke;
        dgvProducts.AllowUserToAddRows = false;
        dgvProducts.AllowUserToDeleteRows = false;
        dgvProducts.AlternatingRowsDefaultCellStyle = styleAlt;
        dgvProducts.AutoGenerateColumns = false;
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvProducts.BackgroundColor = SystemColors.Window;
        dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colProductId, colProductName, colCategory, colUnitPrice, colQuantity });
        dgvProducts.Dock = DockStyle.Fill;
        dgvProducts.MultiSelect = false;
        dgvProducts.Name = "dgvProducts";
        dgvProducts.ReadOnly = true;
        dgvProducts.RowHeadersVisible = false;
        dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;

        colProductId.DataPropertyName = "ProductId";
        colProductId.FillWeight = 15F;
        colProductId.HeaderText = "Mã SP";
        colProductId.Name = "colProductId";
        colProductId.ReadOnly = true;

        colProductName.DataPropertyName = "ProductName";
        colProductName.FillWeight = 35F;
        colProductName.HeaderText = "Tên SP";
        colProductName.Name = "colProductName";
        colProductName.ReadOnly = true;

        colCategory.DataPropertyName = "CategoryName";
        colCategory.FillWeight = 20F;
        colCategory.HeaderText = "Danh Mục";
        colCategory.Name = "colCategory";
        colCategory.ReadOnly = true;

        stylePrice.Alignment = DataGridViewContentAlignment.MiddleRight;
        stylePrice.Format = "#,##0 \"VNĐ\"";
        stylePrice.FormatProvider = CultureInfo.InvariantCulture;
        colUnitPrice.DataPropertyName = "UnitPrice";
        colUnitPrice.DefaultCellStyle = stylePrice;
        colUnitPrice.FillWeight = 18F;
        colUnitPrice.HeaderText = "Đơn Giá";
        colUnitPrice.Name = "colUnitPrice";
        colUnitPrice.ReadOnly = true;

        styleQty.Alignment = DataGridViewContentAlignment.MiddleRight;
        colQuantity.DataPropertyName = "Quantity";
        colQuantity.DefaultCellStyle = styleQty;
        colQuantity.FillWeight = 12F;
        colQuantity.HeaderText = "Số Lượng";
        colQuantity.Name = "colQuantity";
        colQuantity.ReadOnly = true;

        errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        errorProvider.ContainerControl = this;

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1134, 611);
        Controls.Add(tlpMain);
        Controls.Add(statusStrip1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        MinimumSize = new Size(900, 600);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Quản lý sản phẩm công nghệ";

        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        tlpMain.ResumeLayout(false);
        grpInput.ResumeLayout(false);
        tlpInput.ResumeLayout(false);
        tlpInput.PerformLayout();
        ((ISupportInitialize)picAvatar).EndInit();
        flpButtons.ResumeLayout(false);
        grpData.ResumeLayout(false);
        tlpRight.ResumeLayout(false);
        tlpRight.PerformLayout();
        ((ISupportInitialize)dgvProducts).EndInit();
        ((ISupportInitialize)errorProvider).EndInit();
        ((ISupportInitialize)bs).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}

}

