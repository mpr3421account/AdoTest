namespace AdoTest
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
            sqlCon = new Button();
            mySqlCon = new Button();
            mySqlList = new Button();
            sqlList = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // sqlCon
            // 
            sqlCon.Location = new Point(14, 16);
            sqlCon.Margin = new Padding(3, 4, 3, 4);
            sqlCon.Name = "sqlCon";
            sqlCon.Size = new Size(184, 51);
            sqlCon.TabIndex = 0;
            sqlCon.Text = "SQL Connection Test";
            sqlCon.UseVisualStyleBackColor = true;
            sqlCon.Click += sqlCon_Click;
            // 
            // mySqlCon
            // 
            mySqlCon.Location = new Point(532, 16);
            mySqlCon.Margin = new Padding(3, 4, 3, 4);
            mySqlCon.Name = "mySqlCon";
            mySqlCon.Size = new Size(184, 53);
            mySqlCon.TabIndex = 1;
            mySqlCon.Text = "Mysql Connection Test";
            mySqlCon.UseVisualStyleBackColor = true;
            mySqlCon.Click += mySqlCon_Click;
            // 
            // mySqlList
            // 
            mySqlList.Location = new Point(532, 113);
            mySqlList.Margin = new Padding(3, 4, 3, 4);
            mySqlList.Name = "mySqlList";
            mySqlList.Size = new Size(184, 53);
            mySqlList.TabIndex = 3;
            mySqlList.Text = "MySQL List";
            mySqlList.UseVisualStyleBackColor = true;
            mySqlList.Click += mySqlList_Click;
            // 
            // sqlList
            // 
            sqlList.Location = new Point(14, 113);
            sqlList.Margin = new Padding(3, 4, 3, 4);
            sqlList.Name = "sqlList";
            sqlList.Size = new Size(184, 51);
            sqlList.TabIndex = 2;
            sqlList.Text = "SQL List";
            sqlList.UseVisualStyleBackColor = true;
            sqlList.Click += sqlList_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(14, 172);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(368, 184);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(532, 172);
            listBox2.Margin = new Padding(3, 4, 3, 4);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(370, 184);
            listBox2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(mySqlList);
            Controls.Add(sqlList);
            Controls.Add(mySqlCon);
            Controls.Add(sqlCon);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button sqlCon;
        private Button mySqlCon;
        private Button mySqlList;
        private Button sqlList;
        private ListBox listBox1;
        private ListBox listBox2;
    }
}