
namespace User_Control
{
	partial class RegionUC
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegionUC));
			this.captionPanel = new System.Windows.Forms.Panel();
			this.captionLabel = new DevExpress.XtraEditors.LabelControl();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.inputTextBox = new DevExpress.XtraEditors.TextEdit();
			this.searchButton = new DevExpress.XtraEditors.SimpleButton();
			this.saveButton = new DevExpress.XtraEditors.SimpleButton();
			this.regionNameCheckedListBoxControl = new DevExpress.XtraEditors.CheckedListBoxControl();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.captionPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.inputTextBox.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.regionNameCheckedListBoxControl)).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// captionPanel
			// 
			this.captionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.captionPanel.Controls.Add(this.captionLabel);
			this.captionPanel.Controls.Add(this.panel2);
			this.captionPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.captionPanel.Location = new System.Drawing.Point(0, 0);
			this.captionPanel.Name = "captionPanel";
			this.captionPanel.Size = new System.Drawing.Size(258, 25);
			this.captionPanel.TabIndex = 0;
			// 
			// captionLabel
			// 
			this.captionLabel.Appearance.ForeColor = System.Drawing.Color.Black;
			this.captionLabel.Appearance.Options.UseForeColor = true;
			this.captionLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.captionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.captionLabel.Location = new System.Drawing.Point(0, 0);
			this.captionLabel.Name = "captionLabel";
			this.captionLabel.Size = new System.Drawing.Size(243, 25);
			this.captionLabel.TabIndex = 0;
			this.captionLabel.Text = "عنوان";
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(243, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(15, 25);
			this.panel2.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.inputTextBox);
			this.panel1.Controls.Add(this.searchButton);
			this.panel1.Controls.Add(this.saveButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.ForeColor = System.Drawing.Color.Transparent;
			this.panel1.Location = new System.Drawing.Point(0, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(258, 20);
			this.panel1.TabIndex = 1;
			// 
			// inputTextBox
			// 
			this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inputTextBox.Location = new System.Drawing.Point(25, 0);
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Properties.Appearance.ForeColor = System.Drawing.Color.White;
			this.inputTextBox.Properties.Appearance.Options.UseForeColor = true;
			this.inputTextBox.Size = new System.Drawing.Size(208, 20);
			this.inputTextBox.TabIndex = 0;
			this.inputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
			this.inputTextBox.Enter += new System.EventHandler(this.InputTextBox_Enter);
			this.inputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox_KeyPress);
			// 
			// searchButton
			// 
			this.searchButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.searchButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.ImageOptions.Image")));
			this.searchButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
			this.searchButton.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
			this.searchButton.Location = new System.Drawing.Point(233, 0);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(25, 20);
			this.searchButton.TabIndex = 2;
			this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
			this.searchButton.DoubleClick += new System.EventHandler(this.SearchButton_DoubleClick);
			// 
			// saveButton
			// 
			this.saveButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.saveButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.ImageOptions.Image")));
			this.saveButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
			this.saveButton.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
			this.saveButton.Location = new System.Drawing.Point(0, 0);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(25, 20);
			this.saveButton.TabIndex = 3;
			this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// regionNameCheckedListBoxControl
			// 
			this.regionNameCheckedListBoxControl.Appearance.ForeColor = System.Drawing.Color.White;
			this.regionNameCheckedListBoxControl.Appearance.Options.UseForeColor = true;
			this.regionNameCheckedListBoxControl.CheckMode = DevExpress.XtraEditors.CheckMode.Single;
			this.regionNameCheckedListBoxControl.CheckOnClick = true;
			this.regionNameCheckedListBoxControl.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
			this.regionNameCheckedListBoxControl.ContextMenuStrip = this.contextMenuStrip;
			this.regionNameCheckedListBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.regionNameCheckedListBoxControl.Location = new System.Drawing.Point(0, 45);
			this.regionNameCheckedListBoxControl.Name = "regionNameCheckedListBoxControl";
			this.regionNameCheckedListBoxControl.Size = new System.Drawing.Size(258, 73);
			this.regionNameCheckedListBoxControl.TabIndex = 2;
			this.regionNameCheckedListBoxControl.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.RegionNameCheckedListBoxControl_ItemCheck);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteItemToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.contextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.contextMenuStrip.Size = new System.Drawing.Size(175, 26);
			// 
			// deleteItemToolStripMenuItem
			// 
			this.deleteItemToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteItemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteItemToolStripMenuItem.Image")));
			this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
			this.deleteItemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
			this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.deleteItemToolStripMenuItem.Text = "حذف مورد";
			this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.DeleteItemToolStripMenuItem_Click);
			// 
			// RegionUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.Controls.Add(this.regionNameCheckedListBoxControl);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.captionPanel);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "RegionUC";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Size = new System.Drawing.Size(258, 118);
			this.captionPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.inputTextBox.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.regionNameCheckedListBoxControl)).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel captionPanel;
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraEditors.TextEdit inputTextBox;
		private System.Windows.Forms.Panel panel2;
		public DevExpress.XtraEditors.LabelControl captionLabel;
		private DevExpress.XtraEditors.SimpleButton searchButton;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
		private DevExpress.XtraEditors.SimpleButton saveButton;
		public DevExpress.XtraEditors.CheckedListBoxControl regionNameCheckedListBoxControl;
	}
}
