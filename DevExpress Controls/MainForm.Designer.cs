﻿
namespace DevExpress_Controls
{
	partial class MainForm
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
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
			this.mainTabPane = new DevExpress.XtraBars.Navigation.TabPane();
			this.listVariableNumricTabNavigationPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
			this.variableLabelControl = new DevExpress.XtraEditors.LabelControl();
			this.productRegisterTabNavigationPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
			this.producteListGridControl = new DevExpress.XtraGrid.GridControl();
			this.producteBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productListGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colEntity_Status = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProduct_Name = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDateTime_Register = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
			this.deleteRepository = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.colDeactive = new DevExpress.XtraGrid.Columns.GridColumn();
			this.deactiveRepository = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.selectAllCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.newButton = new System.Windows.Forms.Button();
			this.registerButton = new System.Windows.Forms.Button();
			this.entityStatusCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.priceLabelControl = new DevExpress.XtraEditors.LabelControl();
			this.quantityLabelControl = new DevExpress.XtraEditors.LabelControl();
			this.productNameLabelControl = new DevExpress.XtraEditors.LabelControl();
			this.priceTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.quantityTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.productNameTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.customerTabNavigationPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
			this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
			((System.ComponentModel.ISupportInitialize)(this.mainTabPane)).BeginInit();
			this.mainTabPane.SuspendLayout();
			this.listVariableNumricTabNavigationPage.SuspendLayout();
			this.productRegisterTabNavigationPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.producteListGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.producteBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productListGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deleteRepository)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deactiveRepository)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.selectAllCheckEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.entityStatusCheckEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.priceTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.quantityTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productNameTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// mainTabPane
			// 
			this.mainTabPane.Controls.Add(this.listVariableNumricTabNavigationPage);
			this.mainTabPane.Controls.Add(this.productRegisterTabNavigationPage);
			this.mainTabPane.Controls.Add(this.customerTabNavigationPage);
			this.mainTabPane.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTabPane.Font = new System.Drawing.Font("Tahoma", 8F);
			this.mainTabPane.Location = new System.Drawing.Point(0, 0);
			this.mainTabPane.Name = "mainTabPane";
			this.mainTabPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.listVariableNumricTabNavigationPage,
            this.productRegisterTabNavigationPage,
            this.customerTabNavigationPage});
			this.mainTabPane.RegularSize = new System.Drawing.Size(800, 450);
			this.mainTabPane.SelectedPage = this.listVariableNumricTabNavigationPage;
			this.mainTabPane.Size = new System.Drawing.Size(800, 450);
			this.mainTabPane.TabIndex = 4;
			this.mainTabPane.Text = "مشتری";
			this.mainTabPane.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.MainTabPane_SelectedPageChanged);
			// 
			// listVariableNumricTabNavigationPage
			// 
			this.listVariableNumricTabNavigationPage.Caption = "لیست متغییر های عددی";
			this.listVariableNumricTabNavigationPage.Controls.Add(this.variableLabelControl);
			this.listVariableNumricTabNavigationPage.Font = new System.Drawing.Font("Tahoma", 12F);
			this.listVariableNumricTabNavigationPage.Name = "listVariableNumricTabNavigationPage";
			this.listVariableNumricTabNavigationPage.Size = new System.Drawing.Size(800, 423);
			this.listVariableNumricTabNavigationPage.Click += new System.EventHandler(this.listVariableNumricTabNavigationPage_Click);
			// 
			// variableLabelControl
			// 
			this.variableLabelControl.Appearance.Options.UseTextOptions = true;
			this.variableLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.variableLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.variableLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.variableLabelControl.Location = new System.Drawing.Point(289, 14);
			this.variableLabelControl.Name = "variableLabelControl";
			this.variableLabelControl.Size = new System.Drawing.Size(222, 394);
			this.variableLabelControl.TabIndex = 0;
			// 
			// productRegisterTabNavigationPage
			// 
			this.productRegisterTabNavigationPage.Caption = "ثبت  کالا";
			this.productRegisterTabNavigationPage.Controls.Add(this.producteListGridControl);
			this.productRegisterTabNavigationPage.Controls.Add(this.selectAllCheckEdit);
			this.productRegisterTabNavigationPage.Controls.Add(this.newButton);
			this.productRegisterTabNavigationPage.Controls.Add(this.registerButton);
			this.productRegisterTabNavigationPage.Controls.Add(this.entityStatusCheckEdit);
			this.productRegisterTabNavigationPage.Controls.Add(this.priceLabelControl);
			this.productRegisterTabNavigationPage.Controls.Add(this.quantityLabelControl);
			this.productRegisterTabNavigationPage.Controls.Add(this.productNameLabelControl);
			this.productRegisterTabNavigationPage.Controls.Add(this.priceTextEdit);
			this.productRegisterTabNavigationPage.Controls.Add(this.quantityTextEdit);
			this.productRegisterTabNavigationPage.Controls.Add(this.productNameTextEdit);
			this.productRegisterTabNavigationPage.Name = "productRegisterTabNavigationPage";
			this.productRegisterTabNavigationPage.Size = new System.Drawing.Size(800, 423);
			// 
			// producteListGridControl
			// 
			this.producteListGridControl.DataSource = this.producteBindingSource;
			this.producteListGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.producteListGridControl.Location = new System.Drawing.Point(0, 139);
			this.producteListGridControl.MainView = this.productListGridView;
			this.producteListGridControl.Name = "producteListGridControl";
			this.producteListGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.deleteRepository,
            this.deactiveRepository});
			this.producteListGridControl.Size = new System.Drawing.Size(800, 284);
			this.producteListGridControl.TabIndex = 8;
			this.producteListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.productListGridView});
			// 
			// producteBindingSource
			// 
			this.producteBindingSource.DataSource = typeof(Models.Producte);
			// 
			// productListGridView
			// 
			this.productListGridView.Appearance.Row.Options.UseTextOptions = true;
			this.productListGridView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.productListGridView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.productListGridView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.productListGridView.Appearance.SelectedRow.Options.UseForeColor = true;
			this.productListGridView.AutoFillColumn = this.colEntity_Status;
			this.productListGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProduct_Name,
            this.colQuantity,
            this.colPrice,
            this.colDateTime_Register,
            this.colEntity_Status,
            this.colDelete,
            this.colDeactive});
			this.productListGridView.GridControl = this.producteListGridControl;
			this.productListGridView.Name = "productListGridView";
			this.productListGridView.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
			this.productListGridView.OptionsView.ShowGroupPanel = false;
			// 
			// colEntity_Status
			// 
			this.colEntity_Status.AppearanceHeader.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colEntity_Status.AppearanceHeader.Options.UseFont = true;
			this.colEntity_Status.AppearanceHeader.Options.UseTextOptions = true;
			this.colEntity_Status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colEntity_Status.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colEntity_Status.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colEntity_Status.Caption = "وضعیت موجودی";
			this.colEntity_Status.FieldName = "Entity_Status";
			this.colEntity_Status.Name = "colEntity_Status";
			this.colEntity_Status.OptionsColumn.AllowEdit = false;
			this.colEntity_Status.OptionsColumn.AllowMove = false;
			this.colEntity_Status.OptionsColumn.AllowSize = false;
			this.colEntity_Status.OptionsEditForm.UseEditorColRowSpan = false;
			this.colEntity_Status.Visible = true;
			this.colEntity_Status.VisibleIndex = 4;
			// 
			// colProduct_Name
			// 
			this.colProduct_Name.AppearanceHeader.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colProduct_Name.AppearanceHeader.Options.UseFont = true;
			this.colProduct_Name.AppearanceHeader.Options.UseTextOptions = true;
			this.colProduct_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colProduct_Name.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colProduct_Name.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colProduct_Name.Caption = "نام کالا";
			this.colProduct_Name.FieldName = "Product_Name";
			this.colProduct_Name.Name = "colProduct_Name";
			this.colProduct_Name.OptionsColumn.AllowMove = false;
			this.colProduct_Name.OptionsEditForm.UseEditorColRowSpan = false;
			this.colProduct_Name.Visible = true;
			this.colProduct_Name.VisibleIndex = 0;
			// 
			// colQuantity
			// 
			this.colQuantity.AppearanceHeader.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colQuantity.AppearanceHeader.Options.UseFont = true;
			this.colQuantity.AppearanceHeader.Options.UseTextOptions = true;
			this.colQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQuantity.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colQuantity.Caption = "تعداد کالا";
			this.colQuantity.FieldName = "Quantity";
			this.colQuantity.Name = "colQuantity";
			this.colQuantity.OptionsColumn.AllowEdit = false;
			this.colQuantity.OptionsColumn.AllowMove = false;
			this.colQuantity.OptionsColumn.AllowSize = false;
			this.colQuantity.OptionsEditForm.UseEditorColRowSpan = false;
			this.colQuantity.Visible = true;
			this.colQuantity.VisibleIndex = 1;
			// 
			// colPrice
			// 
			this.colPrice.AppearanceHeader.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colPrice.AppearanceHeader.Options.UseFont = true;
			this.colPrice.AppearanceHeader.Options.UseTextOptions = true;
			this.colPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPrice.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colPrice.Caption = "قیمت کالا";
			this.colPrice.FieldName = "Price";
			this.colPrice.Name = "colPrice";
			this.colPrice.OptionsColumn.AllowEdit = false;
			this.colPrice.OptionsColumn.AllowMove = false;
			this.colPrice.OptionsColumn.AllowSize = false;
			this.colPrice.OptionsEditForm.UseEditorColRowSpan = false;
			this.colPrice.Visible = true;
			this.colPrice.VisibleIndex = 2;
			// 
			// colDateTime_Register
			// 
			this.colDateTime_Register.AppearanceHeader.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colDateTime_Register.AppearanceHeader.Options.UseFont = true;
			this.colDateTime_Register.AppearanceHeader.Options.UseTextOptions = true;
			this.colDateTime_Register.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDateTime_Register.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDateTime_Register.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colDateTime_Register.Caption = "تاریخ ثبت";
			this.colDateTime_Register.FieldName = "DateTime_Register";
			this.colDateTime_Register.Name = "colDateTime_Register";
			this.colDateTime_Register.OptionsColumn.AllowEdit = false;
			this.colDateTime_Register.OptionsColumn.AllowMove = false;
			this.colDateTime_Register.OptionsColumn.AllowSize = false;
			this.colDateTime_Register.OptionsEditForm.UseEditorColRowSpan = false;
			this.colDateTime_Register.Visible = true;
			this.colDateTime_Register.VisibleIndex = 3;
			// 
			// colDelete
			// 
			this.colDelete.AppearanceHeader.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colDelete.AppearanceHeader.Options.UseFont = true;
			this.colDelete.AppearanceHeader.Options.UseTextOptions = true;
			this.colDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDelete.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDelete.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colDelete.Caption = "حذف کالا";
			this.colDelete.ColumnEdit = this.deleteRepository;
			this.colDelete.Name = "colDelete";
			this.colDelete.OptionsColumn.AllowMove = false;
			this.colDelete.OptionsColumn.AllowSize = false;
			this.colDelete.OptionsEditForm.UseEditorColRowSpan = false;
			this.colDelete.Visible = true;
			this.colDelete.VisibleIndex = 5;
			// 
			// deleteRepository
			// 
			this.deleteRepository.AppearanceFocused.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.deleteRepository.AppearanceFocused.Options.UseForeColor = true;
			this.deleteRepository.AutoHeight = false;
			editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
			this.deleteRepository.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.deleteRepository.Name = "deleteRepository";
			this.deleteRepository.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			this.deleteRepository.Click += new System.EventHandler(this.DeleteRepository_Click);
			// 
			// colDeactive
			// 
			this.colDeactive.AppearanceHeader.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colDeactive.AppearanceHeader.Options.UseFont = true;
			this.colDeactive.AppearanceHeader.Options.UseTextOptions = true;
			this.colDeactive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDeactive.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDeactive.Caption = "غیر فعال سازی";
			this.colDeactive.ColumnEdit = this.deactiveRepository;
			this.colDeactive.Name = "colDeactive";
			this.colDeactive.Visible = true;
			this.colDeactive.VisibleIndex = 6;
			// 
			// deactiveRepository
			// 
			this.deactiveRepository.AutoHeight = false;
			editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
			this.deactiveRepository.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.deactiveRepository.Name = "deactiveRepository";
			this.deactiveRepository.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			this.deactiveRepository.Click += new System.EventHandler(this.DeactiveRepository_Click);
			// 
			// selectAllCheckEdit
			// 
			this.selectAllCheckEdit.Location = new System.Drawing.Point(704, 114);
			this.selectAllCheckEdit.Name = "selectAllCheckEdit";
			this.selectAllCheckEdit.Properties.Caption = "انتخاب همه";
			this.selectAllCheckEdit.Size = new System.Drawing.Size(84, 19);
			this.selectAllCheckEdit.TabIndex = 7;
			// 
			// newButton
			// 
			this.newButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.newButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.newButton.Location = new System.Drawing.Point(104, 102);
			this.newButton.Name = "newButton";
			this.newButton.Size = new System.Drawing.Size(88, 31);
			this.newButton.TabIndex = 6;
			this.newButton.Text = "کالای جدید";
			this.newButton.UseCompatibleTextRendering = true;
			this.newButton.UseVisualStyleBackColor = true;
			this.newButton.Click += new System.EventHandler(this.NewButton_Click);
			// 
			// registerButton
			// 
			this.registerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.registerButton.ForeColor = System.Drawing.Color.Lime;
			this.registerButton.Location = new System.Drawing.Point(12, 102);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(86, 31);
			this.registerButton.TabIndex = 3;
			this.registerButton.Text = "ثبت کالا";
			this.registerButton.UseCompatibleTextRendering = true;
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// entityStatusCheckEdit
			// 
			this.entityStatusCheckEdit.Location = new System.Drawing.Point(152, 38);
			this.entityStatusCheckEdit.Name = "entityStatusCheckEdit";
			this.entityStatusCheckEdit.Properties.Caption = "وضعیت موجودی";
			this.entityStatusCheckEdit.Size = new System.Drawing.Size(108, 19);
			this.entityStatusCheckEdit.TabIndex = 2;
			this.entityStatusCheckEdit.CheckedChanged += new System.EventHandler(this.EntityStatusCheckEdit_CheckedChanged);
			// 
			// priceLabelControl
			// 
			this.priceLabelControl.Location = new System.Drawing.Point(378, 19);
			this.priceLabelControl.Name = "priceLabelControl";
			this.priceLabelControl.Size = new System.Drawing.Size(48, 13);
			this.priceLabelControl.TabIndex = 1;
			this.priceLabelControl.Text = "قیمت کالا:";
			// 
			// quantityLabelControl
			// 
			this.quantityLabelControl.Location = new System.Drawing.Point(558, 19);
			this.quantityLabelControl.Name = "quantityLabelControl";
			this.quantityLabelControl.Size = new System.Drawing.Size(41, 13);
			this.quantityLabelControl.TabIndex = 1;
			this.quantityLabelControl.Text = "تعداد کالا";
			// 
			// productNameLabelControl
			// 
			this.productNameLabelControl.Location = new System.Drawing.Point(739, 19);
			this.productNameLabelControl.Name = "productNameLabelControl";
			this.productNameLabelControl.Size = new System.Drawing.Size(35, 13);
			this.productNameLabelControl.TabIndex = 1;
			this.productNameLabelControl.Text = "نام کالا:";
			// 
			// priceTextEdit
			// 
			this.priceTextEdit.Location = new System.Drawing.Point(266, 38);
			this.priceTextEdit.Name = "priceTextEdit";
			this.priceTextEdit.Size = new System.Drawing.Size(160, 20);
			this.priceTextEdit.TabIndex = 0;
			this.priceTextEdit.TextChanged += new System.EventHandler(this.PriceTextEdit_TextChanged);
			this.priceTextEdit.Enter += new System.EventHandler(this.PriceTextEdit_Enter);
			this.priceTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceTextEdit_KeyPress);
			// 
			// quantityTextEdit
			// 
			this.quantityTextEdit.Location = new System.Drawing.Point(432, 38);
			this.quantityTextEdit.Name = "quantityTextEdit";
			this.quantityTextEdit.Size = new System.Drawing.Size(167, 20);
			this.quantityTextEdit.TabIndex = 0;
			this.quantityTextEdit.TextChanged += new System.EventHandler(this.QuantityTextEdit_TextChanged);
			this.quantityTextEdit.Enter += new System.EventHandler(this.QuantityTextEdit_Enter);
			this.quantityTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityTextEdit_KeyPress);
			// 
			// productNameTextEdit
			// 
			this.productNameTextEdit.Location = new System.Drawing.Point(605, 38);
			this.productNameTextEdit.Name = "productNameTextEdit";
			this.productNameTextEdit.Size = new System.Drawing.Size(169, 20);
			this.productNameTextEdit.TabIndex = 0;
			this.productNameTextEdit.TextChanged += new System.EventHandler(this.ProductNameTextEdit_TextChanged);
			this.productNameTextEdit.Enter += new System.EventHandler(this.ProductNameTextEdit_Enter);
			this.productNameTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductNameTextEdit_KeyPress);
			// 
			// customerTabNavigationPage
			// 
			this.customerTabNavigationPage.Caption = "مشتری";
			this.customerTabNavigationPage.Name = "customerTabNavigationPage";
			this.customerTabNavigationPage.Size = new System.Drawing.Size(800, 423);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.mainTabPane);
			this.Name = "MainForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main Form";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.mainTabPane)).EndInit();
			this.mainTabPane.ResumeLayout(false);
			this.listVariableNumricTabNavigationPage.ResumeLayout(false);
			this.productRegisterTabNavigationPage.ResumeLayout(false);
			this.productRegisterTabNavigationPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.producteListGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.producteBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productListGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deleteRepository)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deactiveRepository)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.selectAllCheckEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.entityStatusCheckEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.priceTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.quantityTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productNameTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraBars.Navigation.TabPane mainTabPane;
		private DevExpress.XtraBars.Navigation.TabNavigationPage listVariableNumricTabNavigationPage;
		private DevExpress.XtraEditors.LabelControl variableLabelControl;
		private DevExpress.XtraBars.Navigation.TabNavigationPage productRegisterTabNavigationPage;
		private DevExpress.XtraBars.Navigation.TabNavigationPage customerTabNavigationPage;
		private DevExpress.XtraEditors.CheckEdit entityStatusCheckEdit;
		private DevExpress.XtraEditors.LabelControl priceLabelControl;
		private DevExpress.XtraEditors.LabelControl quantityLabelControl;
		private DevExpress.XtraEditors.LabelControl productNameLabelControl;
		private DevExpress.XtraEditors.TextEdit priceTextEdit;
		private DevExpress.XtraEditors.TextEdit quantityTextEdit;
		private DevExpress.XtraEditors.TextEdit productNameTextEdit;
		private System.Windows.Forms.Button newButton;
		private System.Windows.Forms.Button registerButton;
		private DevExpress.XtraEditors.CheckEdit selectAllCheckEdit;
		private DevExpress.XtraGrid.GridControl producteListGridControl;
		private System.Windows.Forms.BindingSource producteBindingSource;
		private DevExpress.XtraGrid.Views.Grid.GridView productListGridView;
		private DevExpress.XtraGrid.Columns.GridColumn colProduct_Name;
		private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
		private DevExpress.XtraGrid.Columns.GridColumn colPrice;
		private DevExpress.XtraGrid.Columns.GridColumn colDateTime_Register;
		private DevExpress.XtraGrid.Columns.GridColumn colEntity_Status;
		private DevExpress.XtraGrid.Columns.GridColumn colDelete;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit deleteRepository;
		private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
		private DevExpress.XtraGrid.Columns.GridColumn colDeactive;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit deactiveRepository;
	}
}
