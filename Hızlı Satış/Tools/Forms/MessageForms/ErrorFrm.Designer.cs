namespace Hızlı_Satış.Tools.Forms.MessageForms
{
    partial class ErrorFrm
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
            this.aciklamatxt = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.basliktxt = new System.Windows.Forms.Label();
            this.kapatbtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // aciklamatxt
            // 
            this.aciklamatxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aciklamatxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aciklamatxt.Location = new System.Drawing.Point(110, 44);
            this.aciklamatxt.Name = "aciklamatxt";
            this.aciklamatxt.Size = new System.Drawing.Size(316, 88);
            this.aciklamatxt.TabIndex = 2;
            this.aciklamatxt.Text = "label2";
            this.aciklamatxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.basliktxt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.aciklamatxt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.kapatbtn, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 177);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Hızlı_Satış.Properties.Resources.error;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 3);
            this.pictureBox1.Size = new System.Drawing.Size(101, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // basliktxt
            // 
            this.basliktxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basliktxt.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basliktxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.basliktxt.Location = new System.Drawing.Point(110, 0);
            this.basliktxt.Name = "basliktxt";
            this.basliktxt.Size = new System.Drawing.Size(316, 44);
            this.basliktxt.TabIndex = 1;
            this.basliktxt.Text = "label1";
            this.basliktxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kapatbtn
            // 
            this.kapatbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.kapatbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kapatbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.kapatbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kapatbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapatbtn.ForeColor = System.Drawing.Color.White;
            this.kapatbtn.Location = new System.Drawing.Point(113, 138);
            this.kapatbtn.Margin = new System.Windows.Forms.Padding(6);
            this.kapatbtn.Name = "kapatbtn";
            this.kapatbtn.Size = new System.Drawing.Size(310, 33);
            this.kapatbtn.TabIndex = 3;
            this.kapatbtn.Text = "Tamam";
            this.kapatbtn.UseVisualStyleBackColor = false;
            this.kapatbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ErrorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 177);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ErrorFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErrorFrm";
            this.Load += new System.EventHandler(this.ErrorFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label aciklamatxt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label basliktxt;
        private System.Windows.Forms.Button kapatbtn;
    }
}