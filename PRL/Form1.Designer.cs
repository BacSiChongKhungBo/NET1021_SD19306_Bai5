namespace PRL
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
            dtgView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_Mnv = new TextBox();
            txt_Hoten = new TextBox();
            txt_Ngsinh = new TextBox();
            txt_Luong = new TextBox();
            txt_Dchi = new RichTextBox();
            rbtn_Nam = new RadioButton();
            rbtn_Nu = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            SuspendLayout();
            // 
            // dtgView
            // 
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(12, 451);
            dtgView.Name = "dtgView";
            dtgView.RowTemplate.Height = 25;
            dtgView.Size = new Size(776, 150);
            dtgView.TabIndex = 0;
            dtgView.CellClick += dtgView_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(99, 37);
            label1.TabIndex = 1;
            label1.Text = "Mã NV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(99, 37);
            label2.TabIndex = 2;
            label2.Text = "Họ Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 155);
            label3.Name = "label3";
            label3.Size = new Size(138, 37);
            label3.TabIndex = 3;
            label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 221);
            label4.Name = "label4";
            label4.Size = new Size(103, 37);
            label4.TabIndex = 4;
            label4.Text = "Địa Chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 313);
            label5.Name = "label5";
            label5.Size = new Size(68, 37);
            label5.TabIndex = 5;
            label5.Text = "Phái";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 372);
            label6.Name = "label6";
            label6.Size = new Size(93, 37);
            label6.TabIndex = 6;
            label6.Text = "Lương";
            // 
            // txt_Mnv
            // 
            txt_Mnv.Location = new Point(149, 47);
            txt_Mnv.Name = "txt_Mnv";
            txt_Mnv.Size = new Size(478, 23);
            txt_Mnv.TabIndex = 7;
            // 
            // txt_Hoten
            // 
            txt_Hoten.Location = new Point(149, 105);
            txt_Hoten.Name = "txt_Hoten";
            txt_Hoten.Size = new Size(478, 23);
            txt_Hoten.TabIndex = 8;
            // 
            // txt_Ngsinh
            // 
            txt_Ngsinh.Location = new Point(149, 169);
            txt_Ngsinh.Name = "txt_Ngsinh";
            txt_Ngsinh.Size = new Size(478, 23);
            txt_Ngsinh.TabIndex = 9;
            // 
            // txt_Luong
            // 
            txt_Luong.Location = new Point(149, 386);
            txt_Luong.Name = "txt_Luong";
            txt_Luong.Size = new Size(478, 23);
            txt_Luong.TabIndex = 10;
            // 
            // txt_Dchi
            // 
            txt_Dchi.Location = new Point(149, 221);
            txt_Dchi.Name = "txt_Dchi";
            txt_Dchi.Size = new Size(478, 78);
            txt_Dchi.TabIndex = 11;
            txt_Dchi.Text = "";
            // 
            // rbtn_Nam
            // 
            rbtn_Nam.AutoSize = true;
            rbtn_Nam.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            rbtn_Nam.Location = new Point(149, 313);
            rbtn_Nam.Name = "rbtn_Nam";
            rbtn_Nam.Size = new Size(92, 41);
            rbtn_Nam.TabIndex = 12;
            rbtn_Nam.TabStop = true;
            rbtn_Nam.Text = "Nam";
            rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // rbtn_Nu
            // 
            rbtn_Nu.AutoSize = true;
            rbtn_Nu.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            rbtn_Nu.Location = new Point(383, 313);
            rbtn_Nu.Name = "rbtn_Nu";
            rbtn_Nu.Size = new Size(71, 41);
            rbtn_Nu.TabIndex = 13;
            rbtn_Nu.TabStop = true;
            rbtn_Nu.Text = "Nữ";
            rbtn_Nu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 613);
            Controls.Add(rbtn_Nu);
            Controls.Add(rbtn_Nam);
            Controls.Add(txt_Dchi);
            Controls.Add(txt_Luong);
            Controls.Add(txt_Ngsinh);
            Controls.Add(txt_Hoten);
            Controls.Add(txt_Mnv);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtgView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgView;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_Mnv;
        private TextBox txt_Hoten;
        private TextBox txt_Ngsinh;
        private TextBox txt_Luong;
        private RichTextBox txt_Dchi;
        private RadioButton rbtn_Nam;
        private RadioButton rbtn_Nu;
    }
}
