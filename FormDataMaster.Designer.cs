
namespace ReservasiHotel
{
    partial class FormDataMaster
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formReservasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataKamarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataResepsionisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTamuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataMasterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataMasterToolStripMenuItem
            // 
            this.dataMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formReservasiToolStripMenuItem,
            this.dataKamarToolStripMenuItem,
            this.dataResepsionisToolStripMenuItem,
            this.dataTamuToolStripMenuItem});
            this.dataMasterToolStripMenuItem.Name = "dataMasterToolStripMenuItem";
            this.dataMasterToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.dataMasterToolStripMenuItem.Text = "Data Master";
            // 
            // formReservasiToolStripMenuItem
            // 
            this.formReservasiToolStripMenuItem.Name = "formReservasiToolStripMenuItem";
            this.formReservasiToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.formReservasiToolStripMenuItem.Text = "Form Reservasi";
            this.formReservasiToolStripMenuItem.Click += new System.EventHandler(this.formReservasiToolStripMenuItem_Click);
            // 
            // dataKamarToolStripMenuItem
            // 
            this.dataKamarToolStripMenuItem.Name = "dataKamarToolStripMenuItem";
            this.dataKamarToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.dataKamarToolStripMenuItem.Text = "Data Kamar";
            this.dataKamarToolStripMenuItem.Click += new System.EventHandler(this.dataKamarToolStripMenuItem_Click);
            // 
            // dataResepsionisToolStripMenuItem
            // 
            this.dataResepsionisToolStripMenuItem.Name = "dataResepsionisToolStripMenuItem";
            this.dataResepsionisToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.dataResepsionisToolStripMenuItem.Text = "Data Resepsionis";
            this.dataResepsionisToolStripMenuItem.Click += new System.EventHandler(this.dataResepsionisToolStripMenuItem_Click);
            // 
            // dataTamuToolStripMenuItem
            // 
            this.dataTamuToolStripMenuItem.Name = "dataTamuToolStripMenuItem";
            this.dataTamuToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.dataTamuToolStripMenuItem.Text = "Data Tamu";
            this.dataTamuToolStripMenuItem.Click += new System.EventHandler(this.dataTamuToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormDataMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDataMaster";
            this.Text = "Data Master";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formReservasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataKamarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataResepsionisToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataTamuToolStripMenuItem;
    }
}

