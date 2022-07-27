
namespace User_Control
{
	partial class addRegionUC
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addRegionUC));
			this.captionPanel = new System.Windows.Forms.Panel();
			this.captionLabel = new DevExpress.XtraEditors.LabelControl();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.inputTextBox = new DevExpress.XtraEditors.TextEdit();
			this.saveButton = new System.Windows.Forms.Button();
			this.regionNameCheckedListBoxControl = new DevExpress.XtraEditors.CheckedListBoxControl();
			this.captionPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.inputTextBox.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.regionNameCheckedListBoxControl)).BeginInit();
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
			this.captionPanel.Size = new System.Drawing.Size(193, 25);
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
			this.captionLabel.Size = new System.Drawing.Size(178, 25);
			this.captionLabel.TabIndex = 0;
			this.captionLabel.Text = "عنوان";
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(178, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(15, 25);
			this.panel2.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.inputTextBox);
			this.panel1.Controls.Add(this.saveButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.ForeColor = System.Drawing.Color.Transparent;
			this.panel1.Location = new System.Drawing.Point(0, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(193, 20);
			this.panel1.TabIndex = 1;
			// 
			// inputTextBox
			// 
			this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inputTextBox.Location = new System.Drawing.Point(25, 0);
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Properties.Appearance.ForeColor = System.Drawing.Color.White;
			this.inputTextBox.Properties.Appearance.Options.UseForeColor = true;
			this.inputTextBox.Size = new System.Drawing.Size(168, 20);
			this.inputTextBox.TabIndex = 0;
			this.inputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
			this.inputTextBox.Enter += new System.EventHandler(this.InputTextBox_Enter);
			this.inputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox_KeyPress);
			// 
			// saveButton
			// 
			this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.saveButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.saveButton.FlatAppearance.BorderSize = 0;
			this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveButton.ForeColor = System.Drawing.Color.White;
			this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
			this.saveButton.Location = new System.Drawing.Point(0, 0);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(25, 20);
			this.saveButton.TabIndex = 1;
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// regionNameCheckedListBoxControl
			// 
			this.regionNameCheckedListBoxControl.Appearance.ForeColor = System.Drawing.Color.White;
			this.regionNameCheckedListBoxControl.Appearance.Options.UseForeColor = true;
			this.regionNameCheckedListBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.regionNameCheckedListBoxControl.Location = new System.Drawing.Point(0, 45);
			this.regionNameCheckedListBoxControl.Name = "regionNameCheckedListBoxControl";
			this.regionNameCheckedListBoxControl.Size = new System.Drawing.Size(193, 73);
			this.regionNameCheckedListBoxControl.TabIndex = 2;
			// 
			// addRegionUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.Controls.Add(this.regionNameCheckedListBoxControl);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.captionPanel);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "addRegionUC";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Size = new System.Drawing.Size(193, 118);
			this.captionPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.inputTextBox.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.regionNameCheckedListBoxControl)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel captionPanel;
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraEditors.TextEdit inputTextBox;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Panel panel2;
		private DevExpress.XtraEditors.CheckedListBoxControl regionNameCheckedListBoxControl;
		public DevExpress.XtraEditors.LabelControl captionLabel;
	}
}
