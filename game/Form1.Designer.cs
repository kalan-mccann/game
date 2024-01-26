namespace game
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
            this.components = new System.ComponentModel.Container();
            this.up = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.attack = new System.Windows.Forms.Button();
            this.dialoug = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.battlebox = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(329, 555);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(75, 23);
            this.up.TabIndex = 1;
            this.up.Text = "Forward";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(260, 584);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(75, 23);
            this.left.TabIndex = 2;
            this.left.Text = "Right";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(396, 584);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(75, 23);
            this.right.TabIndex = 3;
            this.right.Text = "Left";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // attack
            // 
            this.attack.Enabled = false;
            this.attack.Location = new System.Drawing.Point(294, 377);
            this.attack.Name = "attack";
            this.attack.Size = new System.Drawing.Size(142, 35);
            this.attack.TabIndex = 4;
            this.attack.Text = "attack";
            this.attack.UseVisualStyleBackColor = true;
            this.attack.Click += new System.EventHandler(this.button4_Click);
            // 
            // dialoug
            // 
            this.dialoug.BackColor = System.Drawing.Color.Silver;
            this.dialoug.Location = new System.Drawing.Point(12, 377);
            this.dialoug.Name = "dialoug";
            this.dialoug.Size = new System.Drawing.Size(242, 257);
            this.dialoug.TabIndex = 5;
            this.dialoug.Text = "welcome back lol";
            this.dialoug.Click += new System.EventHandler(this.dialoug_Click);
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.description.Location = new System.Drawing.Point(185, 271);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(384, 63);
            this.description.TabIndex = 6;
            this.description.Text = "You are lost in the town of shrumbleton";
            // 
            // battlebox
            // 
            this.battlebox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.battlebox.Location = new System.Drawing.Point(525, 400);
            this.battlebox.Name = "battlebox";
            this.battlebox.Size = new System.Drawing.Size(209, 207);
            this.battlebox.TabIndex = 8;
            this.battlebox.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            this.battlebox.Click += new System.EventHandler(this.label4_Click);
            // 
            // gametimer
            // 
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = global::game.Properties.Resources.PSX_20230323_135718;
            this.pictureBox.Location = new System.Drawing.Point(185, 44);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(384, 186);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(759, 643);
            this.Controls.Add(this.battlebox);
            this.Controls.Add(this.description);
            this.Controls.Add(this.dialoug);
            this.Controls.Add(this.attack);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.up);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button attack;
        private System.Windows.Forms.Label dialoug;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label battlebox;
        private System.Windows.Forms.Timer gametimer;
    }
}

