
namespace Shotgun
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelPlayerBullet = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonShoot = new System.Windows.Forms.Button();
            this.buttonBlock = new System.Windows.Forms.Button();
            this.labelComputer = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelComputerbullet = new System.Windows.Forms.Label();
            this.buttonShotgun = new System.Windows.Forms.Button();
            this.pictureBoxGameOver = new System.Windows.Forms.PictureBox();
            this.buttonRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameOver)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shotgun.Properties.Resources.p8cin707g4z21_gif;
            this.pictureBox1.Location = new System.Drawing.Point(103, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Shotgun.Properties.Resources.istockphoto_1145833191_612x612;
            this.pictureBox2.Location = new System.Drawing.Point(1040, 238);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(332, 323);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // labelPlayerBullet
            // 
            this.labelPlayerBullet.AutoSize = true;
            this.labelPlayerBullet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerBullet.Location = new System.Drawing.Point(103, 155);
            this.labelPlayerBullet.Name = "labelPlayerBullet";
            this.labelPlayerBullet.Size = new System.Drawing.Size(195, 38);
            this.labelPlayerBullet.TabIndex = 2;
            this.labelPlayerBullet.Text = "Player bullet";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLoad.Location = new System.Drawing.Point(23, 627);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(150, 46);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonShoot
            // 
            this.buttonShoot.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonShoot.Location = new System.Drawing.Point(209, 627);
            this.buttonShoot.Name = "buttonShoot";
            this.buttonShoot.Size = new System.Drawing.Size(150, 46);
            this.buttonShoot.TabIndex = 6;
            this.buttonShoot.Text = "Shoot";
            this.buttonShoot.UseVisualStyleBackColor = true;
            this.buttonShoot.Click += new System.EventHandler(this.buttonShoot_Click);
            // 
            // buttonBlock
            // 
            this.buttonBlock.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBlock.Location = new System.Drawing.Point(397, 627);
            this.buttonBlock.Name = "buttonBlock";
            this.buttonBlock.Size = new System.Drawing.Size(150, 46);
            this.buttonBlock.TabIndex = 7;
            this.buttonBlock.Text = "Block";
            this.buttonBlock.UseVisualStyleBackColor = true;
            this.buttonBlock.Click += new System.EventHandler(this.buttonBlock_Click);
            // 
            // labelComputer
            // 
            this.labelComputer.AutoSize = true;
            this.labelComputer.Font = new System.Drawing.Font("Georgia", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelComputer.Location = new System.Drawing.Point(1040, 50);
            this.labelComputer.Name = "labelComputer";
            this.labelComputer.Size = new System.Drawing.Size(211, 43);
            this.labelComputer.TabIndex = 9;
            this.labelComputer.Text = "Computer";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxMessage.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMessage.Location = new System.Drawing.Point(397, 814);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(747, 167);
            this.textBoxMessage.TabIndex = 10;
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("Georgia", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlayer.Location = new System.Drawing.Point(103, 50);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(141, 43);
            this.labelPlayer.TabIndex = 11;
            this.labelPlayer.Text = "Player";
            // 
            // labelComputerbullet
            // 
            this.labelComputerbullet.AutoSize = true;
            this.labelComputerbullet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelComputerbullet.Location = new System.Drawing.Point(1040, 155);
            this.labelComputerbullet.Name = "labelComputerbullet";
            this.labelComputerbullet.Size = new System.Drawing.Size(248, 38);
            this.labelComputerbullet.TabIndex = 12;
            this.labelComputerbullet.Text = "Computer bullet";
            // 
            // buttonShotgun
            // 
            this.buttonShotgun.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonShotgun.Location = new System.Drawing.Point(209, 725);
            this.buttonShotgun.Name = "buttonShotgun";
            this.buttonShotgun.Size = new System.Drawing.Size(150, 46);
            this.buttonShotgun.TabIndex = 13;
            this.buttonShotgun.Text = "Shotgun";
            this.buttonShotgun.UseVisualStyleBackColor = true;
            this.buttonShotgun.Click += new System.EventHandler(this.buttonShotgun_Click);
            // 
            // pictureBoxGameOver
            // 
            this.pictureBoxGameOver.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBoxGameOver.Image = global::Shotgun.Properties.Resources._40908104_explosion_game_over_message_pixel_art_style_retro_vector_illustration;
            this.pictureBoxGameOver.Location = new System.Drawing.Point(612, 303);
            this.pictureBoxGameOver.Name = "pictureBoxGameOver";
            this.pictureBoxGameOver.Size = new System.Drawing.Size(276, 194);
            this.pictureBoxGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGameOver.TabIndex = 14;
            this.pictureBoxGameOver.TabStop = false;
            this.pictureBoxGameOver.Visible = false;
            // 
            // buttonRestart
            // 
            this.buttonRestart.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRestart.Location = new System.Drawing.Point(654, 515);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(184, 46);
            this.buttonRestart.TabIndex = 15;
            this.buttonRestart.Text = "Restart Game";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Visible = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 1076);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.pictureBoxGameOver);
            this.Controls.Add(this.buttonShotgun);
            this.Controls.Add(this.labelComputerbullet);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.labelComputer);
            this.Controls.Add(this.buttonBlock);
            this.Controls.Add(this.buttonShoot);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.labelPlayerBullet);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Shotgun";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameOver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelPlayerBullet;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonShoot;
        private System.Windows.Forms.Button buttonBlock;
        private System.Windows.Forms.Label labelComputer;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelComputerbullet;
        private System.Windows.Forms.Button buttonShotgun;
        private System.Windows.Forms.PictureBox pictureBoxGameOver;
        private System.Windows.Forms.Button buttonRestart;
    }
}

