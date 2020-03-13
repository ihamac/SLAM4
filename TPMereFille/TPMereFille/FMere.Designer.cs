namespace TPMereFille
{
    partial class FMere
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btsShow = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnShowDialog = new System.Windows.Forms.Button();
            this.lbLesFilles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(183, 30);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New()";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(264, 30);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btsShow
            // 
            this.btsShow.Location = new System.Drawing.Point(183, 160);
            this.btsShow.Name = "btsShow";
            this.btsShow.Size = new System.Drawing.Size(75, 23);
            this.btsShow.TabIndex = 2;
            this.btsShow.Text = "Show";
            this.btsShow.UseVisualStyleBackColor = true;
            this.btsShow.Click += new System.EventHandler(this.btsShow_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(264, 160);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 23);
            this.btnHide.TabIndex = 3;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnShowDialog
            // 
            this.btnShowDialog.Location = new System.Drawing.Point(183, 189);
            this.btnShowDialog.Name = "btnShowDialog";
            this.btnShowDialog.Size = new System.Drawing.Size(75, 23);
            this.btnShowDialog.TabIndex = 4;
            this.btnShowDialog.Text = "ShowDialog";
            this.btnShowDialog.UseVisualStyleBackColor = true;
            this.btnShowDialog.Click += new System.EventHandler(this.btnShowDialog_Click);
            // 
            // lbLesFilles
            // 
            this.lbLesFilles.BackColor = System.Drawing.SystemColors.InfoText;
            this.lbLesFilles.ForeColor = System.Drawing.SystemColors.Info;
            this.lbLesFilles.FormattingEnabled = true;
            this.lbLesFilles.Location = new System.Drawing.Point(183, 59);
            this.lbLesFilles.Name = "lbLesFilles";
            this.lbLesFilles.Size = new System.Drawing.Size(156, 95);
            this.lbLesFilles.TabIndex = 5;
            // 
            // FMere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbLesFilles);
            this.Controls.Add(this.btnShowDialog);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btsShow);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNew);
            this.Name = "FMere";
            this.Text = "FMere";
            this.Load += new System.EventHandler(this.FMere_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btsShow;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnShowDialog;
        private System.Windows.Forms.ListBox lbLesFilles;
    }
}