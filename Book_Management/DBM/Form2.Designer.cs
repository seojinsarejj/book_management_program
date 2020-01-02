namespace DBM
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.whghlbtn = new System.Windows.Forms.Button();
            this.bookidbox = new System.Windows.Forms.TextBox();
            this.booknamebox = new System.Windows.Forms.TextBox();
            this.authorbox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(364, 395);
            this.dataGridView1.TabIndex = 0;
            // 
            // whghlbtn
            // 
            this.whghlbtn.Location = new System.Drawing.Point(134, 357);
            this.whghlbtn.Name = "whghlbtn";
            this.whghlbtn.Size = new System.Drawing.Size(99, 56);
            this.whghlbtn.TabIndex = 1;
            this.whghlbtn.Text = "조회";
            this.whghlbtn.UseVisualStyleBackColor = true;
            this.whghlbtn.Click += new System.EventHandler(this.whghlbtn_Click);
            // 
            // bookidbox
            // 
            this.bookidbox.Location = new System.Drawing.Point(133, 88);
            this.bookidbox.Name = "bookidbox";
            this.bookidbox.Size = new System.Drawing.Size(100, 25);
            this.bookidbox.TabIndex = 2;
            // 
            // booknamebox
            // 
            this.booknamebox.Location = new System.Drawing.Point(133, 119);
            this.booknamebox.Name = "booknamebox";
            this.booknamebox.Size = new System.Drawing.Size(100, 25);
            this.booknamebox.TabIndex = 3;
            // 
            // authorbox
            // 
            this.authorbox.Location = new System.Drawing.Point(133, 150);
            this.authorbox.Name = "authorbox";
            this.authorbox.Size = new System.Drawing.Size(100, 25);
            this.authorbox.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 56);
            this.button2.TabIndex = 6;
            this.button2.Text = "등록";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "도서번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "책제목";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "저자명/출판사";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 56);
            this.button1.TabIndex = 10;
            this.button1.Text = "반납";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.authorbox);
            this.Controls.Add(this.booknamebox);
            this.Controls.Add(this.bookidbox);
            this.Controls.Add(this.whghlbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button whghlbtn;
        private System.Windows.Forms.TextBox bookidbox;
        private System.Windows.Forms.TextBox booknamebox;
        private System.Windows.Forms.TextBox authorbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}