namespace TPMereFille
{
    partial class FFilles
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
            this.label1 = new System.Windows.Forms.Label();
            this.textFille = new System.Windows.Forms.TextBox();
            this.btnChanger = new System.Windows.Forms.Button();
            this.btnMaMere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Je change de nom :";
            // 
            // textFille
            // 
            this.textFille.Location = new System.Drawing.Point(241, 70);
            this.textFille.Name = "textFille";
            this.textFille.Size = new System.Drawing.Size(100, 20);
            this.textFille.TabIndex = 1;
            this.textFille.TextChanged += new System.EventHandler(this.textFille_TextChanged);
            // 
            // btnChanger
            // 
            this.btnChanger.Location = new System.Drawing.Point(347, 70);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Size = new System.Drawing.Size(75, 23);
            this.btnChanger.TabIndex = 2;
            this.btnChanger.Text = "Changer";
            this.btnChanger.UseVisualStyleBackColor = true;
            this.btnChanger.Click += new System.EventHandler(this.btnChanger_Click);
            // 
            // btnMaMere
            // 
            this.btnMaMere.Location = new System.Drawing.Point(241, 108);
            this.btnMaMere.Name = "btnMaMere";
            this.btnMaMere.Size = new System.Drawing.Size(75, 23);
            this.btnMaMere.TabIndex = 3;
            this.btnMaMere.Text = "Ma mere";
            this.btnMaMere.UseVisualStyleBackColor = true;
            // 
            // FFilles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMaMere);
            this.Controls.Add(this.btnChanger);
            this.Controls.Add(this.textFille);
            this.Controls.Add(this.label1);
            this.Name = "FFilles";
            this.Text = "FFilles";
            this.Load += new System.EventHandler(this.FFilles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFille;
        private System.Windows.Forms.Button btnChanger;
        private System.Windows.Forms.Button btnMaMere;
    }
}