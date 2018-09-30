namespace PhanMemUngDungThiTracNghiemTiengAnh
{
    partial class frm_PMTA
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
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdb_NhanVien = new System.Windows.Forms.RadioButton();
            this.rdb_ThiSinh = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageSlider1
            // 
            this.imageSlider1.Location = new System.Drawing.Point(702, -329);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(400, 292);
            this.imageSlider1.TabIndex = 0;
            this.imageSlider1.Text = "imageSlider1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::PhanMemUngDungThiTracNghiemTiengAnh.Properties.Resources.LOGO2;
            this.label1.Location = new System.Drawing.Point(74, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 149);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = global::PhanMemUngDungThiTracNghiemTiengAnh.Properties.Resources.NV1;
            this.label2.Location = new System.Drawing.Point(366, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 80);
            this.label2.TabIndex = 3;
            // 
            // rdb_NhanVien
            // 
            this.rdb_NhanVien.AutoSize = true;
            this.rdb_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_NhanVien.ForeColor = System.Drawing.Color.Maroon;
            this.rdb_NhanVien.Location = new System.Drawing.Point(355, 137);
            this.rdb_NhanVien.Name = "rdb_NhanVien";
            this.rdb_NhanVien.Size = new System.Drawing.Size(110, 24);
            this.rdb_NhanVien.TabIndex = 6;
            this.rdb_NhanVien.TabStop = true;
            this.rdb_NhanVien.Text = "Nhân viên";
            this.rdb_NhanVien.UseVisualStyleBackColor = true;
            // 
            // rdb_ThiSinh
            // 
            this.rdb_ThiSinh.AutoSize = true;
            this.rdb_ThiSinh.BackColor = System.Drawing.Color.Transparent;
            this.rdb_ThiSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_ThiSinh.ForeColor = System.Drawing.Color.Maroon;
            this.rdb_ThiSinh.Location = new System.Drawing.Point(293, 311);
            this.rdb_ThiSinh.Name = "rdb_ThiSinh";
            this.rdb_ThiSinh.Size = new System.Drawing.Size(94, 24);
            this.rdb_ThiSinh.TabIndex = 7;
            this.rdb_ThiSinh.TabStop = true;
            this.rdb_ThiSinh.Text = "Thí sinh";
            this.rdb_ThiSinh.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Image = global::PhanMemUngDungThiTracNghiemTiengAnh.Properties.Resources.TS1;
            this.label3.Location = new System.Drawing.Point(306, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 80);
            this.label3.TabIndex = 8;
            // 
            // frm_PMTA
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::PhanMemUngDungThiTracNghiemTiengAnh.Properties.Resources.khunghinh2;
            this.ClientSize = new System.Drawing.Size(540, 382);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdb_ThiSinh);
            this.Controls.Add(this.rdb_NhanVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageSlider1);
            this.Name = "frm_PMTA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm luyện thi trắc nghiệm tiếng anh";
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdb_NhanVien;
        private System.Windows.Forms.RadioButton rdb_ThiSinh;
        private System.Windows.Forms.Label label3;
    }
}