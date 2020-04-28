namespace Bludiste
{
    partial class nastavenivelikosti
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
            this.label2 = new System.Windows.Forms.Label();
            this.radky = new System.Windows.Forms.NumericUpDown();
            this.sloupce = new System.Windows.Forms.NumericUpDown();
            this.okb = new System.Windows.Forms.Button();
            this.cancelb = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.krok = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.radky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sloupce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.krok)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Počet řádek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Počet sloupců";
            // 
            // radky
            // 
            this.radky.Location = new System.Drawing.Point(106, 19);
            this.radky.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.radky.Name = "radky";
            this.radky.Size = new System.Drawing.Size(75, 20);
            this.radky.TabIndex = 1;
            this.radky.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // sloupce
            // 
            this.sloupce.Location = new System.Drawing.Point(106, 44);
            this.sloupce.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.sloupce.Name = "sloupce";
            this.sloupce.Size = new System.Drawing.Size(75, 20);
            this.sloupce.TabIndex = 1;
            this.sloupce.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // okb
            // 
            this.okb.Location = new System.Drawing.Point(7, 96);
            this.okb.Name = "okb";
            this.okb.Size = new System.Drawing.Size(75, 23);
            this.okb.TabIndex = 2;
            this.okb.Text = "Potvrdit";
            this.okb.UseVisualStyleBackColor = true;
            this.okb.Click += new System.EventHandler(this.okb_Click);
            // 
            // cancelb
            // 
            this.cancelb.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelb.Location = new System.Drawing.Point(106, 96);
            this.cancelb.Name = "cancelb";
            this.cancelb.Size = new System.Drawing.Size(75, 23);
            this.cancelb.TabIndex = 2;
            this.cancelb.Text = "Zrušit";
            this.cancelb.UseVisualStyleBackColor = true;
            this.cancelb.Click += new System.EventHandler(this.cancelb_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Velikost kroku";
            // 
            // krok
            // 
            this.krok.Location = new System.Drawing.Point(106, 70);
            this.krok.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.krok.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.krok.Name = "krok";
            this.krok.Size = new System.Drawing.Size(75, 20);
            this.krok.TabIndex = 1;
            this.krok.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.krok.ValueChanged += new System.EventHandler(this.zmenakroku);
            // 
            // nastavenivelikosti
            // 
            this.AcceptButton = this.okb;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelb;
            this.ClientSize = new System.Drawing.Size(191, 129);
            this.Controls.Add(this.cancelb);
            this.Controls.Add(this.okb);
            this.Controls.Add(this.krok);
            this.Controls.Add(this.sloupce);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radky);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "nastavenivelikosti";
            this.Text = "Nastavte velikost bludiště";
            ((System.ComponentModel.ISupportInitialize)(this.radky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sloupce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.krok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okb;
        private System.Windows.Forms.Button cancelb;
        public System.Windows.Forms.NumericUpDown radky;
        public System.Windows.Forms.NumericUpDown sloupce;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown krok;
    }
}