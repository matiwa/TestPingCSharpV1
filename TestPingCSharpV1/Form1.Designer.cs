namespace TestPingCSharpV1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAddressOrWWW = new System.Windows.Forms.TextBox();
            this.BPing = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BPing);
            this.groupBox1.Controls.Add(this.txtAddressOrWWW);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP Address or WWW";
            // 
            // txtAddressOrWWW
            // 
            this.txtAddressOrWWW.Location = new System.Drawing.Point(7, 20);
            this.txtAddressOrWWW.Name = "txtAddressOrWWW";
            this.txtAddressOrWWW.Size = new System.Drawing.Size(247, 20);
            this.txtAddressOrWWW.TabIndex = 0;
            this.txtAddressOrWWW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddressOrWWW_KeyPress);
            // 
            // BPing
            // 
            this.BPing.Location = new System.Drawing.Point(7, 47);
            this.BPing.Name = "BPing";
            this.BPing.Size = new System.Drawing.Size(75, 23);
            this.BPing.TabIndex = 1;
            this.BPing.Text = "Ping";
            this.BPing.UseVisualStyleBackColor = true;
            this.BPing.Click += new System.EventHandler(this.BPing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 100);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Test Ping";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BPing;
        private System.Windows.Forms.TextBox txtAddressOrWWW;
    }
}

