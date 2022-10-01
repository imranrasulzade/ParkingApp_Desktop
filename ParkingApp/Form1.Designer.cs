namespace ParkingApp
{
    partial class Parking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parking));
            this.enterButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.allPlacesLabel = new System.Windows.Forms.Label();
            this.fixAllPlacesLabel = new System.Windows.Forms.Label();
            this.emptyPlacesLabel = new System.Windows.Forms.Label();
            this.emptyNumberOfPlaces = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numbers = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.enterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterButton.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.Location = new System.Drawing.Point(49, 18);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(239, 70);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "Giriş";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(312, 18);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(239, 70);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Çıxış";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // allPlacesLabel
            // 
            this.allPlacesLabel.BackColor = System.Drawing.Color.Silver;
            this.allPlacesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.allPlacesLabel.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allPlacesLabel.Location = new System.Drawing.Point(49, 109);
            this.allPlacesLabel.Name = "allPlacesLabel";
            this.allPlacesLabel.Size = new System.Drawing.Size(239, 49);
            this.allPlacesLabel.TabIndex = 7;
            this.allPlacesLabel.Text = "Yerlərin sayı";
            this.allPlacesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fixAllPlacesLabel
            // 
            this.fixAllPlacesLabel.BackColor = System.Drawing.Color.Linen;
            this.fixAllPlacesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fixAllPlacesLabel.Font = new System.Drawing.Font("Palatino Linotype", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixAllPlacesLabel.ForeColor = System.Drawing.Color.Green;
            this.fixAllPlacesLabel.Location = new System.Drawing.Point(114, 188);
            this.fixAllPlacesLabel.Name = "fixAllPlacesLabel";
            this.fixAllPlacesLabel.Size = new System.Drawing.Size(102, 76);
            this.fixAllPlacesLabel.TabIndex = 8;
            this.fixAllPlacesLabel.Text = "20";
            this.fixAllPlacesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // emptyPlacesLabel
            // 
            this.emptyPlacesLabel.BackColor = System.Drawing.Color.Silver;
            this.emptyPlacesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emptyPlacesLabel.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyPlacesLabel.Location = new System.Drawing.Point(304, 109);
            this.emptyPlacesLabel.Name = "emptyPlacesLabel";
            this.emptyPlacesLabel.Size = new System.Drawing.Size(247, 49);
            this.emptyPlacesLabel.TabIndex = 9;
            this.emptyPlacesLabel.Text = "Boş yer";
            this.emptyPlacesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emptyNumberOfPlaces
            // 
            this.emptyNumberOfPlaces.BackColor = System.Drawing.Color.Linen;
            this.emptyNumberOfPlaces.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.emptyNumberOfPlaces.Font = new System.Drawing.Font("Palatino Linotype", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyNumberOfPlaces.ForeColor = System.Drawing.Color.Green;
            this.emptyNumberOfPlaces.Location = new System.Drawing.Point(386, 188);
            this.emptyNumberOfPlaces.Name = "emptyNumberOfPlaces";
            this.emptyNumberOfPlaces.Size = new System.Drawing.Size(102, 76);
            this.emptyNumberOfPlaces.TabIndex = 10;
            this.emptyNumberOfPlaces.Text = "20";
            this.emptyNumberOfPlaces.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Snow;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progressBar1.ForeColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(49, 357);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(502, 39);
            this.progressBar1.Step = 20;
            this.progressBar1.TabIndex = 12;
            // 
            // numbers
            // 
            this.numbers.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.numbers.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.numbers.Location = new System.Drawing.Point(746, 360);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(42, 40);
            this.numbers.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBox1.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(582, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(158, 382);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // Parking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(818, 415);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.numbers);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.emptyNumberOfPlaces);
            this.Controls.Add(this.emptyPlacesLabel);
            this.Controls.Add(this.fixAllPlacesLabel);
            this.Controls.Add(this.allPlacesLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.enterButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Parking";
            this.Text = "Parking";
            this.Load += new System.EventHandler(this.Parking_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label allPlacesLabel;
        private System.Windows.Forms.Label fixAllPlacesLabel;
        private System.Windows.Forms.Label emptyPlacesLabel;
        private System.Windows.Forms.Label emptyNumberOfPlaces;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label numbers;
        private System.Windows.Forms.ListBox listBox1;
    }
}

