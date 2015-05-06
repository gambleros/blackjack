namespace BlackJack
{
    partial class BlackJackForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJackForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPlayer = new System.Windows.Forms.TextBox();
            this.tbDealer = new System.Windows.Forms.TextBox();
            this.btnDeal = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.tbAlert = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(201, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dealer Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(368, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player Score:";
            // 
            // tbPlayer
            // 
            this.tbPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tbPlayer.Location = new System.Drawing.Point(496, 227);
            this.tbPlayer.Name = "tbPlayer";
            this.tbPlayer.ReadOnly = true;
            this.tbPlayer.Size = new System.Drawing.Size(26, 24);
            this.tbPlayer.TabIndex = 2;
            // 
            // tbDealer
            // 
            this.tbDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tbDealer.Location = new System.Drawing.Point(332, 227);
            this.tbDealer.Name = "tbDealer";
            this.tbDealer.ReadOnly = true;
            this.tbDealer.Size = new System.Drawing.Size(30, 24);
            this.tbDealer.TabIndex = 3;
            // 
            // btnDeal
            // 
            this.btnDeal.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDeal.Location = new System.Drawing.Point(204, 257);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(122, 41);
            this.btnDeal.TabIndex = 4;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = false;
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.SpringGreen;
            this.btnHit.Location = new System.Drawing.Point(332, 257);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(121, 41);
            this.btnHit.TabIndex = 5;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            // 
            // btnStand
            // 
            this.btnStand.BackColor = System.Drawing.Color.Crimson;
            this.btnStand.Location = new System.Drawing.Point(459, 257);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(122, 41);
            this.btnStand.TabIndex = 6;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = false;
            // 
            // tbAlert
            // 
            this.tbAlert.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbAlert.Location = new System.Drawing.Point(204, 190);
            this.tbAlert.Name = "tbAlert";
            this.tbAlert.ReadOnly = true;
            this.tbAlert.Size = new System.Drawing.Size(377, 29);
            this.tbAlert.TabIndex = 7;
            this.tbAlert.Text = "Click Deal to Start !";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            this.imageList1.Images.SetKeyName(0, "c1.png");
            this.imageList1.Images.SetKeyName(1, "c2.png");
            this.imageList1.Images.SetKeyName(2, "c3.png");
            this.imageList1.Images.SetKeyName(3, "c4.png");
            this.imageList1.Images.SetKeyName(4, "c5.png");
            this.imageList1.Images.SetKeyName(5, "c6.png");
            this.imageList1.Images.SetKeyName(6, "c7.png");
            this.imageList1.Images.SetKeyName(7, "c8.png");
            this.imageList1.Images.SetKeyName(8, "c9.png");
            this.imageList1.Images.SetKeyName(9, "c10.png");
            this.imageList1.Images.SetKeyName(10, "c11.png");
            this.imageList1.Images.SetKeyName(11, "c12.png");
            this.imageList1.Images.SetKeyName(12, "c13.png");
            this.imageList1.Images.SetKeyName(13, "d1.png");
            this.imageList1.Images.SetKeyName(14, "d2.png");
            this.imageList1.Images.SetKeyName(15, "d3.png");
            this.imageList1.Images.SetKeyName(16, "d4.png");
            this.imageList1.Images.SetKeyName(17, "d5.png");
            this.imageList1.Images.SetKeyName(18, "d6.png");
            this.imageList1.Images.SetKeyName(19, "d7.png");
            this.imageList1.Images.SetKeyName(20, "d8.png");
            this.imageList1.Images.SetKeyName(21, "d9.png");
            this.imageList1.Images.SetKeyName(22, "d10.png");
            this.imageList1.Images.SetKeyName(23, "d11.png");
            this.imageList1.Images.SetKeyName(24, "d12.png");
            this.imageList1.Images.SetKeyName(25, "d13.png");
            this.imageList1.Images.SetKeyName(26, "h1.png");
            this.imageList1.Images.SetKeyName(27, "h2.png");
            this.imageList1.Images.SetKeyName(28, "h3.png");
            this.imageList1.Images.SetKeyName(29, "h4.png");
            this.imageList1.Images.SetKeyName(30, "h5.png");
            this.imageList1.Images.SetKeyName(31, "h6.png");
            this.imageList1.Images.SetKeyName(32, "h7.png");
            this.imageList1.Images.SetKeyName(33, "h8.png");
            this.imageList1.Images.SetKeyName(34, "h9.png");
            this.imageList1.Images.SetKeyName(35, "h10.png");
            this.imageList1.Images.SetKeyName(36, "h11.png");
            this.imageList1.Images.SetKeyName(37, "h12.png");
            this.imageList1.Images.SetKeyName(38, "h13.png");
            this.imageList1.Images.SetKeyName(39, "s1.png");
            this.imageList1.Images.SetKeyName(40, "s2.png");
            this.imageList1.Images.SetKeyName(41, "s3.png");
            this.imageList1.Images.SetKeyName(42, "s4.png");
            this.imageList1.Images.SetKeyName(43, "s5.png");
            this.imageList1.Images.SetKeyName(44, "s6.png");
            this.imageList1.Images.SetKeyName(45, "s7.png");
            this.imageList1.Images.SetKeyName(46, "s8.png");
            this.imageList1.Images.SetKeyName(47, "s9.png");
            this.imageList1.Images.SetKeyName(48, "s10.png");
            this.imageList1.Images.SetKeyName(49, "s11.png");
            this.imageList1.Images.SetKeyName(50, "s12.png");
            this.imageList1.Images.SetKeyName(51, "s13.png");
            this.imageList1.Images.SetKeyName(52, "hidden.png");
            // 
            // BlackJackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack.Properties.Resources.back_2X;
            this.ClientSize = new System.Drawing.Size(811, 514);
            this.Controls.Add(this.tbAlert);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.tbDealer);
            this.Controls.Add(this.tbPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BlackJackForm";
            this.Text = "BlackJack";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BlackJackForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPlayer;
        private System.Windows.Forms.TextBox tbDealer;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.TextBox tbAlert;
        public System.Windows.Forms.ImageList imageList1;
    }
}