namespace Pub400Demo
{
  partial class PUB400DemoForm
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
      this.components = new System.ComponentModel.Container();
      this.gcCustomer = new DevExpress.XtraGrid.GridControl();
      this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.pUB400Dataset = new Pub400Demo.PUB400Dataset();
      this.gvCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colCustomerDelete = new DevExpress.XtraGrid.Columns.GridColumn();
      this.repCustomerDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
      this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colCustomerFNAME = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colCustomerLNAME = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colCustomerCountry = new DevExpress.XtraGrid.Columns.GridColumn();
      this.repCountryLookup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.cOUNTRYBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.btnSave = new DevExpress.XtraEditors.SimpleButton();
      this.tabCtrlCustomer = new DevExpress.XtraTab.XtraTabControl();
      this.tabPgCountry = new DevExpress.XtraTab.XtraTabPage();
      this.gcCountry = new DevExpress.XtraGrid.GridControl();
      this.gvCountry = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colCountryDelete = new DevExpress.XtraGrid.Columns.GridColumn();
      this.repCountryDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
      this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDESCR = new DevExpress.XtraGrid.Columns.GridColumn();
      this.tabPgCustomer = new DevExpress.XtraTab.XtraTabPage();
      this.tabPgItem = new DevExpress.XtraTab.XtraTabPage();
      this.gcItem = new DevExpress.XtraGrid.GridControl();
      this.iTEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.gvItem = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colItemDelete = new DevExpress.XtraGrid.Columns.GridColumn();
      this.repItemDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
      this.colItemID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colItemNAME = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colItemPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
      this.customerTableAdapter = new Pub400Demo.PUB400DatasetTableAdapters.CUSTOMERTableAdapter();
      this.itemTableAdapter = new Pub400Demo.PUB400DatasetTableAdapters.ITEMTableAdapter();
      this.cOUNTRYTableAdapter = new Pub400Demo.PUB400DatasetTableAdapters.COUNTRYTableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.gcCustomer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pUB400Dataset)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repCustomerDelete)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repCountryLookup)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cOUNTRYBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tabCtrlCustomer)).BeginInit();
      this.tabCtrlCustomer.SuspendLayout();
      this.tabPgCountry.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gcCountry)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvCountry)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repCountryDelete)).BeginInit();
      this.tabPgCustomer.SuspendLayout();
      this.tabPgItem.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gcItem)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.iTEMBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvItem)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repItemDelete)).BeginInit();
      this.SuspendLayout();
      // 
      // gcCustomer
      // 
      this.gcCustomer.DataSource = this.cUSTOMERBindingSource;
      this.gcCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gcCustomer.Location = new System.Drawing.Point(0, 0);
      this.gcCustomer.MainView = this.gvCustomer;
      this.gcCustomer.Name = "gcCustomer";
      this.gcCustomer.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCustomerDelete,
            this.repCountryLookup});
      this.gcCustomer.Size = new System.Drawing.Size(759, 328);
      this.gcCustomer.TabIndex = 0;
      this.gcCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCustomer});
      // 
      // cUSTOMERBindingSource
      // 
      this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
      this.cUSTOMERBindingSource.DataSource = this.pUB400Dataset;
      // 
      // pUB400Dataset
      // 
      this.pUB400Dataset.DataSetName = "CustomerDataset";
      this.pUB400Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // gvCustomer
      // 
      this.gvCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerDelete,
            this.colCustomerID,
            this.colCustomerFNAME,
            this.colCustomerLNAME,
            this.colCustomerCountry});
      this.gvCustomer.GridControl = this.gcCustomer;
      this.gvCustomer.Name = "gvCustomer";
      this.gvCustomer.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
      // 
      // colCustomerDelete
      // 
      this.colCustomerDelete.ColumnEdit = this.repCustomerDelete;
      this.colCustomerDelete.Name = "colCustomerDelete";
      this.colCustomerDelete.OptionsColumn.AllowMove = false;
      this.colCustomerDelete.OptionsColumn.AllowSize = false;
      this.colCustomerDelete.OptionsColumn.FixedWidth = true;
      this.colCustomerDelete.Visible = true;
      this.colCustomerDelete.VisibleIndex = 0;
      this.colCustomerDelete.Width = 30;
      // 
      // repCustomerDelete
      // 
      this.repCustomerDelete.AutoHeight = false;
      this.repCustomerDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
      this.repCustomerDelete.Name = "repCustomerDelete";
      this.repCustomerDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
      this.repCustomerDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repCustomerDelete_ButtonClick);
      // 
      // colCustomerID
      // 
      this.colCustomerID.Caption = "id";
      this.colCustomerID.FieldName = "ID";
      this.colCustomerID.Name = "colCustomerID";
      this.colCustomerID.Visible = true;
      this.colCustomerID.VisibleIndex = 1;
      this.colCustomerID.Width = 71;
      // 
      // colCustomerFNAME
      // 
      this.colCustomerFNAME.Caption = "first name";
      this.colCustomerFNAME.FieldName = "FNAME";
      this.colCustomerFNAME.Name = "colCustomerFNAME";
      this.colCustomerFNAME.Visible = true;
      this.colCustomerFNAME.VisibleIndex = 2;
      this.colCustomerFNAME.Width = 134;
      // 
      // colCustomerLNAME
      // 
      this.colCustomerLNAME.Caption = "last name";
      this.colCustomerLNAME.FieldName = "LNAME";
      this.colCustomerLNAME.Name = "colCustomerLNAME";
      this.colCustomerLNAME.Visible = true;
      this.colCustomerLNAME.VisibleIndex = 3;
      this.colCustomerLNAME.Width = 131;
      // 
      // colCustomerCountry
      // 
      this.colCustomerCountry.Caption = "country";
      this.colCustomerCountry.ColumnEdit = this.repCountryLookup;
      this.colCustomerCountry.FieldName = "COUNTRY";
      this.colCustomerCountry.Name = "colCustomerCountry";
      this.colCustomerCountry.Visible = true;
      this.colCustomerCountry.VisibleIndex = 4;
      this.colCustomerCountry.Width = 375;
      // 
      // repCountryLookup
      // 
      this.repCountryLookup.AutoHeight = false;
      this.repCountryLookup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.repCountryLookup.DataSource = this.cOUNTRYBindingSource;
      this.repCountryLookup.DisplayMember = "DESCR";
      this.repCountryLookup.Name = "repCountryLookup";
      this.repCountryLookup.NullText = "";
      this.repCountryLookup.ShowHeader = false;
      this.repCountryLookup.ValueMember = "ID";
      // 
      // cOUNTRYBindingSource
      // 
      this.cOUNTRYBindingSource.DataMember = "COUNTRY";
      this.cOUNTRYBindingSource.DataSource = this.pUB400Dataset;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(684, 385);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(88, 39);
      this.btnSave.TabIndex = 1;
      this.btnSave.Text = "Save";
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // tabCtrlCustomer
      // 
      this.tabCtrlCustomer.Location = new System.Drawing.Point(12, 13);
      this.tabCtrlCustomer.Name = "tabCtrlCustomer";
      this.tabCtrlCustomer.SelectedTabPage = this.tabPgCountry;
      this.tabCtrlCustomer.Size = new System.Drawing.Size(765, 356);
      this.tabCtrlCustomer.TabIndex = 3;
      this.tabCtrlCustomer.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPgCountry,
            this.tabPgCustomer,
            this.tabPgItem});
      // 
      // tabPgCountry
      // 
      this.tabPgCountry.Controls.Add(this.gcCountry);
      this.tabPgCountry.Name = "tabPgCountry";
      this.tabPgCountry.Size = new System.Drawing.Size(759, 328);
      this.tabPgCountry.Text = "Country";
      // 
      // gcCountry
      // 
      this.gcCountry.DataSource = this.cOUNTRYBindingSource;
      this.gcCountry.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gcCountry.Location = new System.Drawing.Point(0, 0);
      this.gcCountry.MainView = this.gvCountry;
      this.gcCountry.Name = "gcCountry";
      this.gcCountry.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCountryDelete});
      this.gcCountry.Size = new System.Drawing.Size(759, 328);
      this.gcCountry.TabIndex = 1;
      this.gcCountry.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCountry});
      // 
      // gvCountry
      // 
      this.gvCountry.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCountryDelete,
            this.colID,
            this.colDESCR});
      this.gvCountry.GridControl = this.gcCountry;
      this.gvCountry.Name = "gvCountry";
      this.gvCountry.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
      // 
      // colCountryDelete
      // 
      this.colCountryDelete.ColumnEdit = this.repCountryDelete;
      this.colCountryDelete.Name = "colCountryDelete";
      this.colCountryDelete.OptionsColumn.AllowMove = false;
      this.colCountryDelete.OptionsColumn.AllowSize = false;
      this.colCountryDelete.OptionsColumn.FixedWidth = true;
      this.colCountryDelete.Visible = true;
      this.colCountryDelete.VisibleIndex = 0;
      this.colCountryDelete.Width = 30;
      // 
      // repCountryDelete
      // 
      this.repCountryDelete.AutoHeight = false;
      this.repCountryDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
      this.repCountryDelete.Name = "repCountryDelete";
      this.repCountryDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
      this.repCountryDelete.Click += new System.EventHandler(this.repCountryDelete_Click);
      // 
      // colID
      // 
      this.colID.Caption = "id";
      this.colID.FieldName = "ID";
      this.colID.Name = "colID";
      this.colID.Visible = true;
      this.colID.VisibleIndex = 1;
      this.colID.Width = 141;
      // 
      // colDESCR
      // 
      this.colDESCR.Caption = "country";
      this.colDESCR.FieldName = "DESCR";
      this.colDESCR.Name = "colDESCR";
      this.colDESCR.Visible = true;
      this.colDESCR.VisibleIndex = 2;
      this.colDESCR.Width = 923;
      // 
      // tabPgCustomer
      // 
      this.tabPgCustomer.Controls.Add(this.gcCustomer);
      this.tabPgCustomer.Name = "tabPgCustomer";
      this.tabPgCustomer.Size = new System.Drawing.Size(759, 328);
      this.tabPgCustomer.Text = "Customer";
      // 
      // tabPgItem
      // 
      this.tabPgItem.Controls.Add(this.gcItem);
      this.tabPgItem.Name = "tabPgItem";
      this.tabPgItem.Size = new System.Drawing.Size(759, 328);
      this.tabPgItem.Text = "Item";
      // 
      // gcItem
      // 
      this.gcItem.DataSource = this.iTEMBindingSource;
      this.gcItem.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gcItem.Location = new System.Drawing.Point(0, 0);
      this.gcItem.MainView = this.gvItem;
      this.gcItem.Name = "gcItem";
      this.gcItem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repItemDelete});
      this.gcItem.Size = new System.Drawing.Size(759, 328);
      this.gcItem.TabIndex = 1;
      this.gcItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvItem});
      // 
      // iTEMBindingSource
      // 
      this.iTEMBindingSource.DataMember = "ITEM";
      this.iTEMBindingSource.DataSource = this.pUB400Dataset;
      // 
      // gvItem
      // 
      this.gvItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemDelete,
            this.colItemID,
            this.colItemNAME,
            this.colItemPRICE});
      this.gvItem.GridControl = this.gcItem;
      this.gvItem.Name = "gvItem";
      this.gvItem.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
      // 
      // colItemDelete
      // 
      this.colItemDelete.ColumnEdit = this.repItemDelete;
      this.colItemDelete.Name = "colItemDelete";
      this.colItemDelete.OptionsColumn.AllowMove = false;
      this.colItemDelete.OptionsColumn.AllowSize = false;
      this.colItemDelete.OptionsColumn.FixedWidth = true;
      this.colItemDelete.Visible = true;
      this.colItemDelete.VisibleIndex = 0;
      this.colItemDelete.Width = 30;
      // 
      // repItemDelete
      // 
      this.repItemDelete.AutoHeight = false;
      this.repItemDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
      this.repItemDelete.Name = "repItemDelete";
      this.repItemDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
      this.repItemDelete.Click += new System.EventHandler(this.repItemDelete_Click);
      // 
      // colItemID
      // 
      this.colItemID.Caption = "id";
      this.colItemID.FieldName = "ID";
      this.colItemID.Name = "colItemID";
      this.colItemID.Visible = true;
      this.colItemID.VisibleIndex = 1;
      this.colItemID.Width = 110;
      // 
      // colItemNAME
      // 
      this.colItemNAME.Caption = "name";
      this.colItemNAME.FieldName = "NAME";
      this.colItemNAME.Name = "colItemNAME";
      this.colItemNAME.Visible = true;
      this.colItemNAME.VisibleIndex = 2;
      this.colItemNAME.Width = 169;
      // 
      // colItemPRICE
      // 
      this.colItemPRICE.Caption = "price";
      this.colItemPRICE.FieldName = "PRICE";
      this.colItemPRICE.Name = "colItemPRICE";
      this.colItemPRICE.Visible = true;
      this.colItemPRICE.VisibleIndex = 3;
      this.colItemPRICE.Width = 785;
      // 
      // customerTableAdapter
      // 
      this.customerTableAdapter.ClearBeforeFill = true;
      // 
      // itemTableAdapter
      // 
      this.itemTableAdapter.ClearBeforeFill = true;
      // 
      // cOUNTRYTableAdapter
      // 
      this.cOUNTRYTableAdapter.ClearBeforeFill = true;
      // 
      // PUB400DemoForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(789, 444);
      this.Controls.Add(this.tabCtrlCustomer);
      this.Controls.Add(this.btnSave);
      this.Name = "PUB400DemoForm";
      this.Text = "PUB400 Demo";
      this.Shown += new System.EventHandler(this.Form1_Shown);
      ((System.ComponentModel.ISupportInitialize)(this.gcCustomer)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pUB400Dataset)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repCustomerDelete)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repCountryLookup)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cOUNTRYBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tabCtrlCustomer)).EndInit();
      this.tabCtrlCustomer.ResumeLayout(false);
      this.tabPgCountry.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gcCountry)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvCountry)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repCountryDelete)).EndInit();
      this.tabPgCustomer.ResumeLayout(false);
      this.tabPgItem.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gcItem)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.iTEMBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvItem)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repItemDelete)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gcCustomer;
    private DevExpress.XtraGrid.Views.Grid.GridView gvCustomer;
    private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
    private DevExpress.XtraGrid.Columns.GridColumn colCustomerFNAME;
    private DevExpress.XtraGrid.Columns.GridColumn colCustomerLNAME;
    private DevExpress.XtraEditors.SimpleButton btnSave;
    private DevExpress.XtraTab.XtraTabControl tabCtrlCustomer;
    private DevExpress.XtraTab.XtraTabPage tabPgCustomer;
    private DevExpress.XtraTab.XtraTabPage tabPgItem;
    private DevExpress.XtraGrid.Columns.GridColumn colCustomerDelete;
    private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repCustomerDelete;
    private DevExpress.XtraGrid.GridControl gcItem;
    private DevExpress.XtraGrid.Views.Grid.GridView gvItem;
    private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repItemDelete;
    private DevExpress.XtraGrid.Columns.GridColumn colItemID;
    private DevExpress.XtraGrid.Columns.GridColumn colItemNAME;
    private DevExpress.XtraGrid.Columns.GridColumn colItemPRICE;
    private DevExpress.XtraGrid.Columns.GridColumn colItemDelete;
    private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
    private PUB400Dataset pUB400Dataset;
    private System.Windows.Forms.BindingSource iTEMBindingSource;
    private PUB400DatasetTableAdapters.CUSTOMERTableAdapter customerTableAdapter;
    private PUB400DatasetTableAdapters.ITEMTableAdapter itemTableAdapter;
    private DevExpress.XtraGrid.Columns.GridColumn colCustomerCountry;
    private DevExpress.XtraTab.XtraTabPage tabPgCountry;
    private DevExpress.XtraGrid.GridControl gcCountry;
    private DevExpress.XtraGrid.Views.Grid.GridView gvCountry;
    private DevExpress.XtraGrid.Columns.GridColumn colCountryDelete;
    private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repCountryDelete;
    private System.Windows.Forms.BindingSource cOUNTRYBindingSource;
    private PUB400DatasetTableAdapters.COUNTRYTableAdapter cOUNTRYTableAdapter;
    private DevExpress.XtraGrid.Columns.GridColumn colID;
    private DevExpress.XtraGrid.Columns.GridColumn colDESCR;
    private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCountryLookup;
  }
}

