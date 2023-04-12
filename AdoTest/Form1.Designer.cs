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
            SuspendLayout();
            // 
            // sqlCon
            // 
            sqlCon.Location = new Point(121, 50);
            sqlCon.Name = "sqlCon";
            sqlCon.Size = new Size(75, 23);
            sqlCon.TabIndex = 0;
            sqlCon.Text = "SQL";
            sqlCon.UseVisualStyleBackColor = true;
            sqlCon.Click += sqlCon_Click;
            // 
            // mySqlCon
            // 
            mySqlCon.Location = new Point(274, 50);
            mySqlCon.Name = "mySqlCon";
            mySqlCon.Size = new Size(75, 23);
            mySqlCon.TabIndex = 1;
            mySqlCon.Text = "Mysql";
            mySqlCon.UseVisualStyleBackColor = true;
            mySqlCon.Click += mySqlCon_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mySqlCon);
            Controls.Add(sqlCon);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button sqlCon;
        private Button mySqlCon;
    }
}