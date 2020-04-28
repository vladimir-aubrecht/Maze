namespace Bludiste
{
    partial class Bludiste
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bludištěToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerovaniTerenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nastaveníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukončiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nápovědaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cas = new System.Windows.Forms.ToolStripTextBox();
            this.fullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bludištěToolStripMenuItem,
            this.nápovědaToolStripMenuItem,
            this.Cas,
            this.fullscreenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(920, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bludištěToolStripMenuItem
            // 
            this.bludištěToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerovaniTerenu,
            this.nastaveníToolStripMenuItem,
            this.ukončiToolStripMenuItem});
            this.bludištěToolStripMenuItem.Name = "bludištěToolStripMenuItem";
            this.bludištěToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bludištěToolStripMenuItem.Text = "Bludiště";
            // 
            // GenerovaniTerenu
            // 
            this.GenerovaniTerenu.Name = "GenerovaniTerenu";
            this.GenerovaniTerenu.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.GenerovaniTerenu.Size = new System.Drawing.Size(163, 22);
            this.GenerovaniTerenu.Text = "Generuj nové";
            this.GenerovaniTerenu.Click += new System.EventHandler(this.generujNovýToolStripMenuItem_Click);
            // 
            // nastaveníToolStripMenuItem
            // 
            this.nastaveníToolStripMenuItem.Name = "nastaveníToolStripMenuItem";
            this.nastaveníToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.nastaveníToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.nastaveníToolStripMenuItem.Text = "Nastavení";
            this.nastaveníToolStripMenuItem.Click += new System.EventHandler(this.nastaveníToolStripMenuItem_Click);
            // 
            // ukončiToolStripMenuItem
            // 
            this.ukončiToolStripMenuItem.Name = "ukončiToolStripMenuItem";
            this.ukončiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.ukončiToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.ukončiToolStripMenuItem.Text = "Ukonči";
            this.ukončiToolStripMenuItem.Click += new System.EventHandler(this.ukončiToolStripMenuItem_Click);
            // 
            // nápovědaToolStripMenuItem
            // 
            this.nápovědaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kToolStripMenuItem,
            this.oProgramuToolStripMenuItem});
            this.nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            this.nápovědaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.nápovědaToolStripMenuItem.Text = "Nápověda";
            // 
            // kToolStripMenuItem
            // 
            this.kToolStripMenuItem.Name = "kToolStripMenuItem";
            this.kToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.kToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.kToolStripMenuItem.Text = "K vlastní hře";
            this.kToolStripMenuItem.Click += new System.EventHandler(this.kToolStripMenuItem_Click);
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.oProgramuToolStripMenuItem.Text = "O Programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // Cas
            // 
            this.Cas.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Cas.AutoSize = false;
            this.Cas.BackColor = System.Drawing.SystemColors.Window;
            this.Cas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cas.HideSelection = false;
            this.Cas.Name = "Cas";
            this.Cas.ReadOnly = true;
            this.Cas.Size = new System.Drawing.Size(130, 20);
            this.Cas.Text = "Uplynulo času: 00:00";
            // 
            // fullscreenToolStripMenuItem
            // 
            this.fullscreenToolStripMenuItem.Name = "fullscreenToolStripMenuItem";
            this.fullscreenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.fullscreenToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.fullscreenToolStripMenuItem.Text = "Fullscreen";
            this.fullscreenToolStripMenuItem.Click += new System.EventHandler(this.fullscreenToolStripMenuItem_Click);
            // 
            // Bludiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 649);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Bludiste";
            this.Text = "Bludiště";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hybejse);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bludištěToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GenerovaniTerenu;
        private System.Windows.Forms.ToolStripMenuItem ukončiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nápovědaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nastaveníToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox Cas;
        private System.Windows.Forms.ToolStripMenuItem fullscreenToolStripMenuItem;
    }
}

