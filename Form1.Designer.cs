namespace CSharp______TinhDaySo
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
            label1 = new Label();
            txtBD = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            txtKT = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtTong = new TextBox();
            txtTich = new TextBox();
            label6 = new Label();
            txtTongChan = new TextBox();
            label7 = new Label();
            txtTongLe = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20F);
            label1.Location = new Point(36, 9);
            label1.Name = "label1";
            label1.Size = new Size(259, 33);
            label1.TabIndex = 0;
            label1.Text = "Giới Hạn Của Dãy Số";
            label1.Click += label1_Click;
            // 
            // txtBD
            // 
            txtBD.Font = new Font("Segoe UI", 15F);
            txtBD.Location = new Point(196, 73);
            txtBD.Name = "txtBD";
            txtBD.Size = new Size(100, 34);
            txtBD.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15F);
            label2.Location = new Point(36, 82);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 2;
            label2.Text = "Số bắt đầu";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 20F);
            button1.Location = new Point(82, 234);
            button1.Name = "button1";
            button1.Size = new Size(162, 48);
            button1.TabIndex = 3;
            button1.Text = "Tính Toán";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15F);
            label3.Location = new Point(36, 158);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 5;
            label3.Text = "Số bắt đầu";
            // 
            // txtKT
            // 
            txtKT.Font = new Font("Segoe UI", 15F);
            txtKT.Location = new Point(198, 149);
            txtKT.Name = "txtKT";
            txtKT.Size = new Size(100, 34);
            txtKT.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 20F);
            label4.Location = new Point(583, 16);
            label4.Name = "label4";
            label4.Size = new Size(110, 33);
            label4.TabIndex = 6;
            label4.Text = "Kết Quả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15F);
            label5.Location = new Point(458, 76);
            label5.Name = "label5";
            label5.Size = new Size(126, 25);
            label5.TabIndex = 9;
            label5.Text = "Tổng các số:";
            // 
            // txtTong
            // 
            txtTong.Font = new Font("Segoe UI", 15F);
            txtTong.Location = new Point(653, 67);
            txtTong.Name = "txtTong";
            txtTong.Size = new Size(100, 34);
            txtTong.TabIndex = 10;
            // 
            // txtTich
            // 
            txtTich.Font = new Font("Segoe UI", 15F);
            txtTich.Location = new Point(653, 129);
            txtTich.Name = "txtTich";
            txtTich.Size = new Size(100, 34);
            txtTich.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15F);
            label6.Location = new Point(458, 135);
            label6.Name = "label6";
            label6.Size = new Size(118, 25);
            label6.TabIndex = 11;
            label6.Text = "Tích các số:";
            // 
            // txtTongChan
            // 
            txtTongChan.Font = new Font("Segoe UI", 15F);
            txtTongChan.Location = new Point(653, 195);
            txtTongChan.Name = "txtTongChan";
            txtTongChan.Size = new Size(100, 34);
            txtTongChan.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15F);
            label7.Location = new Point(458, 204);
            label7.Name = "label7";
            label7.Size = new Size(179, 25);
            label7.TabIndex = 13;
            label7.Text = "Tổng các số Chẵn:";
            // 
            // txtTongLe
            // 
            txtTongLe.Font = new Font("Segoe UI", 15F);
            txtTongLe.Location = new Point(653, 257);
            txtTongLe.Name = "txtTongLe";
            txtTongLe.Size = new Size(100, 34);
            txtTongLe.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 15F);
            label8.Location = new Point(458, 263);
            label8.Name = "label8";
            label8.Size = new Size(153, 25);
            label8.TabIndex = 15;
            label8.Text = "Tổng các số Lẻ:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 338);
            Controls.Add(txtTongLe);
            Controls.Add(label8);
            Controls.Add(txtTongChan);
            Controls.Add(label7);
            Controls.Add(txtTich);
            Controls.Add(label6);
            Controls.Add(txtTong);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtKT);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtBD);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tính Toán Trên Dãy Số";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBD;
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox txtKT;
        private Label label4;
        private Label label5;
        private TextBox txtTong;
        private TextBox txtTich;
        private Label label6;
        private TextBox txtTongChan;
        private Label label7;
        private TextBox txtTongLe;
        private Label label8;
    }
}
