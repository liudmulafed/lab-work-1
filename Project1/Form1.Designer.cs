namespace Project1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(194, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(493, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Вивести";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Автор";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кількість сторінок";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Назва";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Тема";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Дата публікації";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(137, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Місце";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(422, 42);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(283, 22);
            this.txtAuthor.TabIndex = 8;
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(422, 101);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(283, 22);
            this.txtPages.TabIndex = 9;
            // 
            // txtTopic
            // 
            this.txtTopic.Location = new System.Drawing.Point(422, 154);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(283, 22);
            this.txtTopic.TabIndex = 10;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(422, 210);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(283, 22);
            this.txtTitle.TabIndex = 11;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(422, 274);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(283, 22);
            this.txtDate.TabIndex = 12;
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(422, 337);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(283, 22);
            this.txtPlace.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(793, 515);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtTopic);
            this.Controls.Add(this.txtPages);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtPlace;
    }
}

