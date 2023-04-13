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
            btnListMySqlDataSet = new Button();
            btnListSQLDataSet = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // sqlCon
            // 
            sqlCon.Location = new Point(12, 12);
            sqlCon.Name = "sqlCon";
            sqlCon.Size = new Size(161, 24);
            sqlCon.TabIndex = 0;
            sqlCon.Text = "SQL Connection Test";
            sqlCon.UseVisualStyleBackColor = true;
            sqlCon.Click += sqlCon_Click;
            // 
            // mySqlCon
            // 
            mySqlCon.Location = new Point(390, 11);
            mySqlCon.Name = "mySqlCon";
            mySqlCon.Size = new Size(161, 26);
            mySqlCon.TabIndex = 1;
            mySqlCon.Text = "Mysql Connection Test";
            mySqlCon.UseVisualStyleBackColor = true;
            mySqlCon.Click += mySqlCon_Click;
            // 
            // mySqlList
            // 
            mySqlList.Location = new Point(390, 58);
            mySqlList.Name = "mySqlList";
            mySqlList.Size = new Size(161, 26);
            mySqlList.TabIndex = 3;
            mySqlList.Text = "MySQL List (dataReader)";
            mySqlList.UseVisualStyleBackColor = true;
            mySqlList.Click += mySqlList_Click;
            // 
            // sqlList
            // 
            sqlList.Location = new Point(12, 56);
            sqlList.Name = "sqlList";
            sqlList.Size = new Size(161, 24);
            sqlList.TabIndex = 2;
            sqlList.Text = "SQL List (dataReader)";
            sqlList.UseVisualStyleBackColor = true;
            sqlList.Click += sqlList_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 90);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(161, 139);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(390, 90);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(161, 139);
            listBox2.TabIndex = 5;
            // 
            // btnListMySqlDataSet
            // 
            btnListMySqlDataSet.Location = new Point(390, 233);
            btnListMySqlDataSet.Name = "btnListMySqlDataSet";
            btnListMySqlDataSet.Size = new Size(161, 26);
            btnListMySqlDataSet.TabIndex = 7;
            btnListMySqlDataSet.Text = "MySQL List (dataSet)";
            btnListMySqlDataSet.UseVisualStyleBackColor = true;
            btnListMySqlDataSet.Click += btnListMySqlDataSet_Click;
            // 
            // btnListSQLDataSet
            // 
            btnListSQLDataSet.Location = new Point(12, 235);
            btnListSQLDataSet.Name = "btnListSQLDataSet";
            btnListSQLDataSet.Size = new Size(161, 24);
            btnListSQLDataSet.TabIndex = 6;
            btnListSQLDataSet.Text = "SQL List (dataSet)";
            btnListSQLDataSet.UseVisualStyleBackColor = true;
            btnListSQLDataSet.Click += btnListSQLDataSet_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 265);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(339, 150);
            dataGridView1.TabIndex = 8;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(390, 265);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(339, 150);
            dataGridView2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 777);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(btnListMySqlDataSet);
            Controls.Add(btnListSQLDataSet);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(mySqlList);
            Controls.Add(sqlList);
            Controls.Add(mySqlCon);
            Controls.Add(sqlCon);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button sqlCon;
        private Button mySqlCon;
        private Button mySqlList;
        private Button sqlList;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button btnListMySqlDataSet;
        private Button btnListSQLDataSet;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}