
namespace TobbAblakosB
{
    partial class MainForm
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
            this.asztaliGepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laptopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asztaliGepToolStripMenuItem,
            this.laptopToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asztaliGepToolStripMenuItem
            // 
            this.asztaliGepToolStripMenuItem.Name = "asztaliGepToolStripMenuItem";
            this.asztaliGepToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.asztaliGepToolStripMenuItem.Text = "Asztali gép";
            this.asztaliGepToolStripMenuItem.Click += new System.EventHandler(this.asztaliGepToolStripMenuItem_Click);
            // 
            // laptopToolStripMenuItem
            // 
            this.laptopToolStripMenuItem.Name = "laptopToolStripMenuItem";
            this.laptopToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.laptopToolStripMenuItem.Text = "Laptop";
            this.laptopToolStripMenuItem.Click += new System.EventHandler(this.laptopToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asztaliGepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laptopToolStripMenuItem;
    }
}

