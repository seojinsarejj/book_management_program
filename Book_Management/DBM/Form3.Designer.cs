namespace DBM
{
    partial class Form3
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
            this.idmakingbox = new System.Windows.Forms.TextBox();
            this.namemakingbox = new System.Windows.Forms.TextBox();
            this.emailmakingbox = new System.Windows.Forms.TextBox();
            this.phonemakingbox = new System.Windows.Forms.TextBox();
            this.pwmakingbox = new System.Windows.Forms.TextBox();
            this.registerbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idmakingbox
            // 
            this.idmakingbox.Location = new System.Drawing.Point(384, 89);
            this.idmakingbox.Name = "idmakingbox";
            this.idmakingbox.Size = new System.Drawing.Size(100, 25);
            this.idmakingbox.TabIndex = 0;
            // 
            // namemakingbox
            // 
            this.namemakingbox.Location = new System.Drawing.Point(384, 201);
            this.namemakingbox.Name = "namemakingbox";
            this.namemakingbox.Size = new System.Drawing.Size(100, 25);
            this.namemakingbox.TabIndex = 1;
            // 
            // emailmakingbox
            // 
            this.emailmakingbox.Location = new System.Drawing.Point(384, 250);
            this.emailmakingbox.Name = "emailmakingbox";
            this.emailmakingbox.Size = new System.Drawing.Size(100, 25);
            this.emailmakingbox.TabIndex = 2;
            // 
            // phonemakingbox
            // 
            this.phonemakingbox.Location = new System.Drawing.Point(384, 299);
            this.phonemakingbox.Name = "phonemakingbox";
            this.phonemakingbox.Size = new System.Drawing.Size(100, 25);
            this.phonemakingbox.TabIndex = 3;
            this.phonemakingbox.TextChanged += new System.EventHandler(this.phonemakingbox_TextChanged);
            // 
            // pwmakingbox
            // 
            this.pwmakingbox.Location = new System.Drawing.Point(384, 143);
            this.pwmakingbox.Name = "pwmakingbox";
            this.pwmakingbox.Size = new System.Drawing.Size(100, 25);
            this.pwmakingbox.TabIndex = 4;
            // 
            // registerbtn
            // 
            this.registerbtn.Location = new System.Drawing.Point(384, 346);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(100, 35);
            this.registerbtn.TabIndex = 5;
            this.registerbtn.Text = "가입";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "phone number";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.pwmakingbox);
            this.Controls.Add(this.phonemakingbox);
            this.Controls.Add(this.emailmakingbox);
            this.Controls.Add(this.namemakingbox);
            this.Controls.Add(this.idmakingbox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idmakingbox;
        private System.Windows.Forms.TextBox namemakingbox;
        private System.Windows.Forms.TextBox emailmakingbox;
        private System.Windows.Forms.TextBox phonemakingbox;
        private System.Windows.Forms.TextBox pwmakingbox;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}