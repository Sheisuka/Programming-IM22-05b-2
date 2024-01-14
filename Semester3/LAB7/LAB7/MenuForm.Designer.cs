namespace LAB7
{
    partial class MenuForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuBtn1 = new System.Windows.Forms.Button();
            this.menuBtn2 = new System.Windows.Forms.Button();
            this.menuBtn3 = new System.Windows.Forms.Button();
            this.menuBtn4 = new System.Windows.Forms.Button();
            this.menuBtn5 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.menuBtn1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.menuBtn2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuBtn3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.menuBtn4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.menuBtn5, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(105, 109);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(156, 250);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // menuBtn1
            // 
            this.menuBtn1.Location = new System.Drawing.Point(3, 3);
            this.menuBtn1.Name = "menuBtn1";
            this.menuBtn1.Size = new System.Drawing.Size(150, 30);
            this.menuBtn1.TabIndex = 0;
            this.menuBtn1.Text = "Автопарк";
            this.menuBtn1.UseVisualStyleBackColor = true;
            this.menuBtn1.Click += new System.EventHandler(this.menuBtn1_Click);
            // 
            // menuBtn2
            // 
            this.menuBtn2.Location = new System.Drawing.Point(3, 53);
            this.menuBtn2.Name = "menuBtn2";
            this.menuBtn2.Size = new System.Drawing.Size(150, 30);
            this.menuBtn2.TabIndex = 1;
            this.menuBtn2.Text = "Сохранить";
            this.menuBtn2.UseVisualStyleBackColor = true;
            this.menuBtn2.Click += new System.EventHandler(this.menuBtn2_Click);
            // 
            // menuBtn3
            // 
            this.menuBtn3.Location = new System.Drawing.Point(3, 103);
            this.menuBtn3.Name = "menuBtn3";
            this.menuBtn3.Size = new System.Drawing.Size(150, 30);
            this.menuBtn3.TabIndex = 2;
            this.menuBtn3.Text = "Создать новый";
            this.menuBtn3.UseVisualStyleBackColor = true;
            this.menuBtn3.Click += new System.EventHandler(this.menuBtn3_Click);
            // 
            // menuBtn4
            // 
            this.menuBtn4.Location = new System.Drawing.Point(3, 153);
            this.menuBtn4.Name = "menuBtn4";
            this.menuBtn4.Size = new System.Drawing.Size(150, 30);
            this.menuBtn4.TabIndex = 3;
            this.menuBtn4.Text = "Загрузить";
            this.menuBtn4.UseVisualStyleBackColor = true;
            this.menuBtn4.Click += new System.EventHandler(this.menuBtn4_Click);
            // 
            // menuBtn5
            // 
            this.menuBtn5.Location = new System.Drawing.Point(3, 203);
            this.menuBtn5.Name = "menuBtn5";
            this.menuBtn5.Size = new System.Drawing.Size(150, 30);
            this.menuBtn5.TabIndex = 4;
            this.menuBtn5.Text = "Выход";
            this.menuBtn5.UseVisualStyleBackColor = true;
            this.menuBtn5.Click += new System.EventHandler(this.menuBtn5_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button menuBtn1;
        private System.Windows.Forms.Button menuBtn2;
        private System.Windows.Forms.Button menuBtn3;
        private System.Windows.Forms.Button menuBtn4;
        private System.Windows.Forms.Button menuBtn5;
    }
}