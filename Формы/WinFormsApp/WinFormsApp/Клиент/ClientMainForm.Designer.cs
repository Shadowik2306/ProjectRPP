namespace WinFormsApp.Клиент
{
    partial class ClientMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientMainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьСчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получениеСпискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.открытьСчётToolStripMenuItem,
            this.заявкиToolStripMenuItem,
            this.получениеСпискаToolStripMenuItem,
            this.отчётToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьСчётToolStripMenuItem
            // 
            this.открытьСчётToolStripMenuItem.Name = "открытьСчётToolStripMenuItem";
            this.открытьСчётToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.открытьСчётToolStripMenuItem.Text = "Создать карту";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.клиентыToolStripMenuItem.Text = "Карты";
            // 
            // заявкиToolStripMenuItem
            // 
            this.заявкиToolStripMenuItem.Name = "заявкиToolStripMenuItem";
            this.заявкиToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.заявкиToolStripMenuItem.Text = "Создать заявку";
            // 
            // получениеСпискаToolStripMenuItem
            // 
            this.получениеСпискаToolStripMenuItem.Name = "получениеСпискаToolStripMenuItem";
            this.получениеСпискаToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.получениеСпискаToolStripMenuItem.Text = "Получить список переводов";
            // 
            // отчётToolStripMenuItem
            // 
            this.отчётToolStripMenuItem.Name = "отчётToolStripMenuItem";
            this.отчётToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.отчётToolStripMenuItem.Text = "Отчёт";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(913, 473);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ClientMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 516);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClientMainForm";
            this.Text = "Банк \"Вы банкрот\"";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem открытьСчётToolStripMenuItem;
        private ToolStripMenuItem клиентыToolStripMenuItem;
        private ToolStripMenuItem заявкиToolStripMenuItem;
        private ToolStripMenuItem получениеСпискаToolStripMenuItem;
        private ToolStripMenuItem отчётToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}