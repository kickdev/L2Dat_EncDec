namespace L2DatEncDec
{
	partial class IniEditBox
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniEditBox));
            this.IniEditer = new System.Windows.Forms.RichTextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IniEditer
            // 
            this.IniEditer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.IniEditer.Location = new System.Drawing.Point(12, 13);
            this.IniEditer.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.IniEditer.Name = "IniEditer";
            this.IniEditer.Size = new System.Drawing.Size(671, 241);
            this.IniEditer.TabIndex = 0;
            this.IniEditer.TabStop = false;
            this.IniEditer.Text = "";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveBtn.Location = new System.Drawing.Point(144, 263);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(120, 40);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(424, 263);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(120, 40);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // IniEditBox
            // 
            this.AcceptButton = this.SaveBtn;
            this.ClientSize = new System.Drawing.Size(694, 318);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.IniEditer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IniEditBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IniEditBox";
            this.Load += new System.EventHandler(this.IniEditBox_Load);
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.RichTextBox IniEditer;
		public System.Windows.Forms.Button SaveBtn;
        public System.Windows.Forms.Button CancelBtn;
	}
}