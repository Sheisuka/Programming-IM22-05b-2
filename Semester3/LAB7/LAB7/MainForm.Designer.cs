namespace LAB7
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainBtn3 = new System.Windows.Forms.Button();
            this.mainBtn1 = new System.Windows.Forms.Button();
            this.mainBtn2 = new System.Windows.Forms.Button();
            this.carparkView = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(204, 450);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel1.Controls.Add(this.mainBtn3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.mainBtn1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mainBtn2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(159, 380);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // mainBtn3
            // 
            this.mainBtn3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainBtn3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mainBtn3.Location = new System.Drawing.Point(3, 347);
            this.mainBtn3.Name = "mainBtn3";
            this.mainBtn3.Size = new System.Drawing.Size(153, 30);
            this.mainBtn3.TabIndex = 3;
            this.mainBtn3.Text = "Назад";
            this.mainBtn3.UseVisualStyleBackColor = true;
            this.mainBtn3.Click += new System.EventHandler(this.mainBtn3_Click);
            // 
            // mainBtn1
            // 
            this.mainBtn1.Location = new System.Drawing.Point(3, 3);
            this.mainBtn1.Name = "mainBtn1";
            this.mainBtn1.Size = new System.Drawing.Size(150, 30);
            this.mainBtn1.TabIndex = 1;
            this.mainBtn1.Text = "Отсортировать по ТО";
            this.mainBtn1.UseVisualStyleBackColor = true;
            this.mainBtn1.Click += new System.EventHandler(this.mainBtn1_Click);
            // 
            // mainBtn2
            // 
            this.mainBtn2.Location = new System.Drawing.Point(3, 41);
            this.mainBtn2.Name = "mainBtn2";
            this.mainBtn2.Size = new System.Drawing.Size(150, 30);
            this.mainBtn2.TabIndex = 2;
            this.mainBtn2.Text = "Найти машины старше 20";
            this.mainBtn2.UseVisualStyleBackColor = true;
            this.mainBtn2.Click += new System.EventHandler(this.mainBtn2_Click);
            // 
            // carparkView
            // 
            this.carparkView.HideSelection = false;
            this.carparkView.Location = new System.Drawing.Point(210, 35);
            this.carparkView.Name = "carparkView";
            this.carparkView.Size = new System.Drawing.Size(580, 380);
            this.carparkView.TabIndex = 2;
            this.carparkView.UseCompatibleStateImageBehavior = false;
            this.carparkView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.carparkView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.splitter1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button mainBtn1;
        private System.Windows.Forms.Button mainBtn2;
        private System.Windows.Forms.Button mainBtn3;
        private System.Windows.Forms.ListView carparkView;
    }
}