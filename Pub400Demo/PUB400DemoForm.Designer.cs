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
      this.btnSave = new DevExpress.XtraEditors.SimpleButton();
      this.tabCtrlCustomer = new DevExpress.XtraTab.XtraTabControl();
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
      this.colCustomerCountry = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.gcCustomer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pUB400Dataset)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repCustomerDelete)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tabCtrlCustomer)).BeginInit();
      this.tabCtrlCustomer.SuspendLayout();
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
            this.repCustomerDelete});
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
      this.tabCtrlCustomer.SelectedTabPage = this.tabPgCustomer;
      this.tabCtrlCustomer.Size = new System.Drawing.Size(765, 356);
      this.tabCtrlCustomer.TabIndex = 3;
      this.tabCtrlCustomer.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPgCustomer,
            this.tabPgItem});
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
      // colCustomerCountry
      // 
      this.colCustomerCountry.Caption = "country";
      this.colCustomerCountry.FieldName = "COUNTRY";
      this.colCustomerCountry.Name = "colCustomerCountry";
      this.colCustomerCountry.Visible = true;
      this.colCustomerCountry.VisibleIndex = 4;
      this.colCustomerCountry.Width = 375;
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
      ((System.ComponentModel.ISupportInitialize)(this.tabCtrlCustomer)).EndInit();
      this.tabCtrlCustomer.ResumeLayout(false);
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
  }
}

