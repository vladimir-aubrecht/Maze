namespace Bludiste
{
    partial class nastaveni
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.velikostKroku = new System.Windows.Forms.NumericUpDown();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.cmaranice = new System.Windows.Forms.CheckBox();
            this.rozptyl_text = new System.Windows.Forms.Label();
            this.Rozptyl = new System.Windows.Forms.NumericUpDown();
            this.Animovat = new System.Windows.Forms.CheckBox();
            this.zpozdeni_text = new System.Windows.Forms.Label();
            this.Zpozdeni = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.velikostKroku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rozptyl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zpozdeni)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(99, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nastavení";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Velikost kroku";
            // 
            // velikostKroku
            // 
            this.velikostKroku.Location = new System.Drawing.Point(263, 116);
            this.velikostKroku.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.velikostKroku.Name = "velikostKroku";
            this.velikostKroku.Size = new System.Drawing.Size(45, 20);
            this.velikostKroku.TabIndex = 5;
            this.velikostKroku.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(6, 119);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 6;
            this.ok.Text = "Potvrdit";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(87, 119);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Zrušit";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // cmaranice
            // 
            this.cmaranice.AutoSize = true;
            this.cmaranice.Location = new System.Drawing.Point(12, 64);
            this.cmaranice.Name = "cmaranice";
            this.cmaranice.Size = new System.Drawing.Size(128, 17);
            this.cmaranice.TabIndex = 7;
            this.cmaranice.Text = "Generovat čmáranice";
            this.cmaranice.UseVisualStyleBackColor = true;
            this.cmaranice.CheckedChanged += new System.EventHandler(this.nastavenicmarani);
            // 
            // rozptyl_text
            // 
            this.rozptyl_text.AutoSize = true;
            this.rozptyl_text.Enabled = false;
            this.rozptyl_text.Location = new System.Drawing.Point(208, 66);
            this.rozptyl_text.Name = "rozptyl_text";
            this.rozptyl_text.Size = new System.Drawing.Size(42, 13);
            this.rozptyl_text.TabIndex = 8;
            this.rozptyl_text.Text = "Rozptyl";
            // 
            // Rozptyl
            // 
            this.Rozptyl.Enabled = false;
            this.Rozptyl.Location = new System.Drawing.Point(256, 64);
            this.Rozptyl.Name = "Rozptyl";
            this.Rozptyl.Size = new System.Drawing.Size(52, 20);
            this.Rozptyl.TabIndex = 9;
            this.Rozptyl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Rozptyl.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // Animovat
            // 
            this.Animovat.AutoSize = true;
            this.Animovat.Location = new System.Drawing.Point(12, 87);
            this.Animovat.Name = "Animovat";
            this.Animovat.Size = new System.Drawing.Size(109, 17);
            this.Animovat.TabIndex = 7;
            this.Animovat.Text = "Animovat bludiště";
            this.Animovat.UseVisualStyleBackColor = true;
            this.Animovat.CheckedChanged += new System.EventHandler(this.nastavenianimace);
            // 
            // zpozdeni_text
            // 
            this.zpozdeni_text.AutoSize = true;
            this.zpozdeni_text.Enabled = false;
            this.zpozdeni_text.Location = new System.Drawing.Point(149, 92);
            this.zpozdeni_text.Name = "zpozdeni_text";
            this.zpozdeni_text.Size = new System.Drawing.Size(101, 13);
            this.zpozdeni_text.TabIndex = 8;
            this.zpozdeni_text.Text = "Zpoždění v animaci";
            // 
            // Zpozdeni
            // 
            this.Zpozdeni.Enabled = false;
            this.Zpozdeni.Location = new System.Drawing.Point(256, 90);
            this.Zpozdeni.Name = "Zpozdeni";
            this.Zpozdeni.Size = new System.Drawing.Size(52, 20);
            this.Zpozdeni.TabIndex = 9;
            this.Zpozdeni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Zpozdeni.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // nastaveni
            // 
            this.AcceptButton = this.ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(320, 154);
            this.Controls.Add(this.Zpozdeni);
            this.Controls.Add(this.Rozptyl);
            this.Controls.Add(this.zpozdeni_text);
            this.Controls.Add(this.rozptyl_text);
            this.Controls.Add(this.Animovat);
            this.Controls.Add(this.cmaranice);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.velikostKroku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "nastaveni";
            this.Text = "Nastavení";
            ((System.ComponentModel.ISupportInitialize)(this.velikostKroku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rozptyl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zpozdeni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
        public System.Windows.Forms.NumericUpDown velikostKroku;
        public System.Windows.Forms.CheckBox cmaranice;
        private System.Windows.Forms.Label rozptyl_text;
        public System.Windows.Forms.NumericUpDown Rozptyl;
        public System.Windows.Forms.CheckBox Animovat;
        private System.Windows.Forms.Label zpozdeni_text;
        public System.Windows.Forms.NumericUpDown Zpozdeni;
    }
}