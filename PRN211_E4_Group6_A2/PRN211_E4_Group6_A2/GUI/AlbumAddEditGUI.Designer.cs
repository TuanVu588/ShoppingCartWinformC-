namespace PRN211_E4_Group6_A2.GUI
{
    partial class AlbumAddEditGUI
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.comArtist = new System.Windows.Forms.ComboBox();
            this.comGenre = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(399, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 110);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(300, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(162, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChose
            // 
            this.btnChose.Location = new System.Drawing.Point(14, 205);
            this.btnChose.Name = "btnChose";
            this.btnChose.Size = new System.Drawing.Size(104, 23);
            this.btnChose.TabIndex = 22;
            this.btnChose.Text = "Chose an image";
            this.btnChose.UseVisualStyleBackColor = true;
            this.btnChose.Click += new System.EventHandler(this.btnChose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Artist:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Genre:";
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(124, 205);
            this.txtImage.Name = "txtImage";
            this.txtImage.ReadOnly = true;
            this.txtImage.Size = new System.Drawing.Size(439, 23);
            this.txtImage.TabIndex = 17;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(124, 166);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(113, 23);
            this.txtPrice.TabIndex = 16;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(124, 128);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(439, 23);
            this.txtTitle.TabIndex = 15;
            // 
            // comArtist
            // 
            this.comArtist.FormattingEnabled = true;
            this.comArtist.Location = new System.Drawing.Point(124, 90);
            this.comArtist.Name = "comArtist";
            this.comArtist.Size = new System.Drawing.Size(269, 23);
            this.comArtist.TabIndex = 14;
            // 
            // comGenre
            // 
            this.comGenre.FormattingEnabled = true;
            this.comGenre.Location = new System.Drawing.Point(124, 48);
            this.comGenre.Name = "comGenre";
            this.comGenre.Size = new System.Drawing.Size(269, 23);
            this.comGenre.TabIndex = 13;
            // 
            // AlbumAddEditGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 311);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.comArtist);
            this.Controls.Add(this.comGenre);
            this.Name = "AlbumAddEditGUI";
            this.Text = "AlbumAddEditGUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button button2;
        private Button button1;
        private Button btnChose;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtImage;
        private TextBox txtPrice;
        private TextBox txtTitle;
        private ComboBox comArtist;
        private ComboBox comGenre;
    }
}