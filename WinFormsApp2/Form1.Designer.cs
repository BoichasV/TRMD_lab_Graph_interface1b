
namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.тестуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вхідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реєстраціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отриманняДанихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проДодатокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тестуванняToolStripMenuItem,
            this.результатToolStripMenuItem,
            this.проДодатокToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // тестуванняToolStripMenuItem
            // 
            this.тестуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вхідToolStripMenuItem,
            this.реєстраціяToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.тестуванняToolStripMenuItem.Name = "тестуванняToolStripMenuItem";
            this.тестуванняToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.тестуванняToolStripMenuItem.Text = "Тестування";
            // 
            // вхідToolStripMenuItem
            // 
            this.вхідToolStripMenuItem.Name = "вхідToolStripMenuItem";
            this.вхідToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.вхідToolStripMenuItem.Text = "Вхід";
            this.вхідToolStripMenuItem.Click += new System.EventHandler(this.вхідToolStripMenuItem_Click);
            // 
            // реєстраціяToolStripMenuItem
            // 
            this.реєстраціяToolStripMenuItem.Name = "реєстраціяToolStripMenuItem";
            this.реєстраціяToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.реєстраціяToolStripMenuItem.Text = "Реєстрація";
            this.реєстраціяToolStripMenuItem.Click += new System.EventHandler(this.реєстраціяToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // результатToolStripMenuItem
            // 
            this.результатToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отриманняДанихToolStripMenuItem});
            this.результатToolStripMenuItem.Name = "результатToolStripMenuItem";
            this.результатToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.результатToolStripMenuItem.Text = "Результат";
            // 
            // отриманняДанихToolStripMenuItem
            // 
            this.отриманняДанихToolStripMenuItem.Name = "отриманняДанихToolStripMenuItem";
            this.отриманняДанихToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.отриманняДанихToolStripMenuItem.Text = "Отримання даних";
            this.отриманняДанихToolStripMenuItem.Click += new System.EventHandler(this.отриманняДанихToolStripMenuItem_Click);
            // 
            // проДодатокToolStripMenuItem
            // 
            this.проДодатокToolStripMenuItem.Name = "проДодатокToolStripMenuItem";
            this.проДодатокToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.проДодатокToolStripMenuItem.Text = "Про додаток";
            this.проДодатокToolStripMenuItem.Click += new System.EventHandler(this.проДодатокToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 422);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem тестуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вхідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реєстраціяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проДодатокToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem отриманняДанихToolStripMenuItem;
    }
}

