namespace RubyCafe
{
    partial class RubyCafe
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
			this.leftPanel = new System.Windows.Forms.Panel();
			this.clearButton = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.moneyLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.logoPanel = new System.Windows.Forms.Panel();
			this.rubycafelabel = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.totalpriceLabel = new System.Windows.Forms.Label();
			this.totalLabel = new System.Windows.Forms.Label();
			this.payButton = new System.Windows.Forms.Button();
			this.cartListbox = new System.Windows.Forms.ListBox();
			this.cartLabel = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pizzaPicbox = new System.Windows.Forms.PictureBox();
			this.hamburgerPicbox = new System.Windows.Forms.PictureBox();
			this.panackePicbox = new System.Windows.Forms.PictureBox();
			this.cupcakePicbox = new System.Windows.Forms.PictureBox();
			this.hotdogPicbox = new System.Windows.Forms.PictureBox();
			this.cheesePicbox = new System.Windows.Forms.PictureBox();
			this.leftPanel.SuspendLayout();
			this.panel3.SuspendLayout();
			this.logoPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pizzaPicbox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hamburgerPicbox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panackePicbox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cupcakePicbox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hotdogPicbox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cheesePicbox)).BeginInit();
			this.SuspendLayout();
			// 
			// leftPanel
			// 
			this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.leftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.leftPanel.Controls.Add(this.clearButton);
			this.leftPanel.Controls.Add(this.panel3);
			this.leftPanel.Controls.Add(this.logoPanel);
			this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftPanel.Location = new System.Drawing.Point(0, 0);
			this.leftPanel.Margin = new System.Windows.Forms.Padding(0);
			this.leftPanel.Name = "leftPanel";
			this.leftPanel.Size = new System.Drawing.Size(160, 422);
			this.leftPanel.TabIndex = 0;
			this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftPanel_Paint);
			// 
			// clearButton
			// 
			this.clearButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.clearButton.FlatAppearance.BorderSize = 0;
			this.clearButton.Location = new System.Drawing.Point(0, 391);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(160, 31);
			this.clearButton.TabIndex = 2;
			this.clearButton.Text = "Temizle";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.moneyLabel);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 89);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(160, 28);
			this.panel3.TabIndex = 1;
			// 
			// moneyLabel
			// 
			this.moneyLabel.AutoSize = true;
			this.moneyLabel.Dock = System.Windows.Forms.DockStyle.Right;
			this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.moneyLabel.ForeColor = System.Drawing.Color.White;
			this.moneyLabel.Location = new System.Drawing.Point(110, 0);
			this.moneyLabel.Name = "moneyLabel";
			this.moneyLabel.Size = new System.Drawing.Size(50, 24);
			this.moneyLabel.TabIndex = 1;
			this.moneyLabel.Text = "1000";
			this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mevcut:";
			// 
			// logoPanel
			// 
			this.logoPanel.Controls.Add(this.rubycafelabel);
			this.logoPanel.Controls.Add(this.pictureBox1);
			this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.logoPanel.Location = new System.Drawing.Point(0, 0);
			this.logoPanel.Name = "logoPanel";
			this.logoPanel.Size = new System.Drawing.Size(160, 89);
			this.logoPanel.TabIndex = 0;
			// 
			// rubycafelabel
			// 
			this.rubycafelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rubycafelabel.AutoSize = true;
			this.rubycafelabel.Font = new System.Drawing.Font("SEA GARDENS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rubycafelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(83)))));
			this.rubycafelabel.Location = new System.Drawing.Point(60, 10);
			this.rubycafelabel.Margin = new System.Windows.Forms.Padding(0);
			this.rubycafelabel.Name = "rubycafelabel";
			this.rubycafelabel.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
			this.rubycafelabel.Size = new System.Drawing.Size(84, 61);
			this.rubycafelabel.TabIndex = 1;
			this.rubycafelabel.Text = "RUBY\r\nCAFE";
			this.rubycafelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rubycafelabel.Click += new System.EventHandler(this.rubycafelabel_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = global::RubyCafe.Properties.Resources.logo;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 89);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.payButton);
			this.panel1.Controls.Add(this.cartListbox);
			this.panel1.Controls.Add(this.cartLabel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(797, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 422);
			this.panel1.TabIndex = 1;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.totalpriceLabel);
			this.panel4.Controls.Add(this.totalLabel);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(0, 336);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(200, 34);
			this.panel4.TabIndex = 3;
			// 
			// totalpriceLabel
			// 
			this.totalpriceLabel.AutoSize = true;
			this.totalpriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.totalpriceLabel.ForeColor = System.Drawing.Color.White;
			this.totalpriceLabel.Location = new System.Drawing.Point(62, 0);
			this.totalpriceLabel.Name = "totalpriceLabel";
			this.totalpriceLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.totalpriceLabel.Size = new System.Drawing.Size(19, 25);
			this.totalpriceLabel.TabIndex = 1;
			this.totalpriceLabel.Text = "0";
			this.totalpriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.totalpriceLabel.Click += new System.EventHandler(this.totalpriceLabel_Click);
			// 
			// totalLabel
			// 
			this.totalLabel.AutoSize = true;
			this.totalLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.totalLabel.ForeColor = System.Drawing.Color.White;
			this.totalLabel.Location = new System.Drawing.Point(0, 0);
			this.totalLabel.Name = "totalLabel";
			this.totalLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.totalLabel.Size = new System.Drawing.Size(65, 25);
			this.totalLabel.TabIndex = 0;
			this.totalLabel.Text = "Toplam:";
			// 
			// payButton
			// 
			this.payButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.payButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.payButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.payButton.FlatAppearance.BorderSize = 0;
			this.payButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.payButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.payButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(83)))));
			this.payButton.Location = new System.Drawing.Point(0, 370);
			this.payButton.Name = "payButton";
			this.payButton.Size = new System.Drawing.Size(200, 52);
			this.payButton.TabIndex = 2;
			this.payButton.Text = "Öde";
			this.payButton.UseVisualStyleBackColor = false;
			this.payButton.Click += new System.EventHandler(this.payButton_Click);
			// 
			// cartListbox
			// 
			this.cartListbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.cartListbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.cartListbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cartListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cartListbox.ForeColor = System.Drawing.Color.White;
			this.cartListbox.FormattingEnabled = true;
			this.cartListbox.ItemHeight = 20;
			this.cartListbox.Location = new System.Drawing.Point(0, 53);
			this.cartListbox.Margin = new System.Windows.Forms.Padding(0);
			this.cartListbox.Name = "cartListbox";
			this.cartListbox.Size = new System.Drawing.Size(200, 369);
			this.cartListbox.TabIndex = 1;
			// 
			// cartLabel
			// 
			this.cartLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.cartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cartLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(83)))));
			this.cartLabel.Location = new System.Drawing.Point(0, 0);
			this.cartLabel.Margin = new System.Windows.Forms.Padding(0);
			this.cartLabel.Name = "cartLabel";
			this.cartLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.cartLabel.Size = new System.Drawing.Size(200, 53);
			this.cartLabel.TabIndex = 0;
			this.cartLabel.Text = "SEPETINIZ";
			this.cartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.cartLabel.Click += new System.EventHandler(this.cartLabel_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.pizzaPicbox);
			this.panel2.Controls.Add(this.hamburgerPicbox);
			this.panel2.Controls.Add(this.panackePicbox);
			this.panel2.Controls.Add(this.cupcakePicbox);
			this.panel2.Controls.Add(this.hotdogPicbox);
			this.panel2.Controls.Add(this.cheesePicbox);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(160, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(637, 422);
			this.panel2.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(25, 156);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(156, 20);
			this.label2.TabIndex = 12;
			this.label2.Text = "Cheesecake - 150TL";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(471, 380);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 20);
			this.label5.TabIndex = 11;
			this.label5.Text = "Pizza - 150TL";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(251, 380);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(120, 20);
			this.label6.TabIndex = 10;
			this.label6.Text = "Pancake - 60TL";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(48, 380);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(111, 20);
			this.label7.TabIndex = 9;
			this.label7.Text = "Hotdog - 30TL";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(448, 156);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(147, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Hamburger - 120TL";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(251, 156);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Cupcake - 50TL";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pizzaPicbox
			// 
			this.pizzaPicbox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pizzaPicbox.Image = global::RubyCafe.Properties.Resources.pizza;
			this.pizzaPicbox.Location = new System.Drawing.Point(423, 214);
			this.pizzaPicbox.Name = "pizzaPicbox";
			this.pizzaPicbox.Size = new System.Drawing.Size(208, 196);
			this.pizzaPicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pizzaPicbox.TabIndex = 5;
			this.pizzaPicbox.TabStop = false;
			this.pizzaPicbox.Click += new System.EventHandler(this.pizzaPicbox_Click);
			// 
			// hamburgerPicbox
			// 
			this.hamburgerPicbox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.hamburgerPicbox.Image = global::RubyCafe.Properties.Resources.hamburger;
			this.hamburgerPicbox.Location = new System.Drawing.Point(423, 11);
			this.hamburgerPicbox.Name = "hamburgerPicbox";
			this.hamburgerPicbox.Size = new System.Drawing.Size(208, 197);
			this.hamburgerPicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.hamburgerPicbox.TabIndex = 4;
			this.hamburgerPicbox.TabStop = false;
			this.hamburgerPicbox.Click += new System.EventHandler(this.hamburgerPicbox_Click);
			// 
			// panackePicbox
			// 
			this.panackePicbox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.panackePicbox.Image = global::RubyCafe.Properties.Resources.pancake;
			this.panackePicbox.Location = new System.Drawing.Point(214, 214);
			this.panackePicbox.Name = "panackePicbox";
			this.panackePicbox.Size = new System.Drawing.Size(208, 196);
			this.panackePicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.panackePicbox.TabIndex = 3;
			this.panackePicbox.TabStop = false;
			this.panackePicbox.Click += new System.EventHandler(this.panackePicbox_Click);
			// 
			// cupcakePicbox
			// 
			this.cupcakePicbox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cupcakePicbox.Image = global::RubyCafe.Properties.Resources.cupcake;
			this.cupcakePicbox.Location = new System.Drawing.Point(214, 0);
			this.cupcakePicbox.Name = "cupcakePicbox";
			this.cupcakePicbox.Size = new System.Drawing.Size(208, 208);
			this.cupcakePicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.cupcakePicbox.TabIndex = 2;
			this.cupcakePicbox.TabStop = false;
			this.cupcakePicbox.Click += new System.EventHandler(this.cupcakePicbox_Click);
			// 
			// hotdogPicbox
			// 
			this.hotdogPicbox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.hotdogPicbox.Image = global::RubyCafe.Properties.Resources.hotdog;
			this.hotdogPicbox.Location = new System.Drawing.Point(6, 214);
			this.hotdogPicbox.Name = "hotdogPicbox";
			this.hotdogPicbox.Size = new System.Drawing.Size(208, 196);
			this.hotdogPicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.hotdogPicbox.TabIndex = 1;
			this.hotdogPicbox.TabStop = false;
			this.hotdogPicbox.Click += new System.EventHandler(this.hotdogPicbox_Click);
			// 
			// cheesePicbox
			// 
			this.cheesePicbox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cheesePicbox.Image = global::RubyCafe.Properties.Resources.cheese;
			this.cheesePicbox.Location = new System.Drawing.Point(6, 0);
			this.cheesePicbox.Name = "cheesePicbox";
			this.cheesePicbox.Size = new System.Drawing.Size(208, 208);
			this.cheesePicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.cheesePicbox.TabIndex = 0;
			this.cheesePicbox.TabStop = false;
			this.cheesePicbox.Click += new System.EventHandler(this.cheesePicbox_Click);
			// 
			// RubyCafe
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(997, 422);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.leftPanel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "RubyCafe";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RubyCafe v0.01";
			this.Load += new System.EventHandler(this.RubyCafe_Load);
			this.leftPanel.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.logoPanel.ResumeLayout(false);
			this.logoPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pizzaPicbox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hamburgerPicbox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panackePicbox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cupcakePicbox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hotdogPicbox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cheesePicbox)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Label rubycafelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox cartListbox;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.PictureBox pizzaPicbox;
        private System.Windows.Forms.PictureBox hamburgerPicbox;
        private System.Windows.Forms.PictureBox panackePicbox;
        private System.Windows.Forms.PictureBox cupcakePicbox;
        private System.Windows.Forms.PictureBox hotdogPicbox;
        private System.Windows.Forms.PictureBox cheesePicbox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label totalpriceLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}

