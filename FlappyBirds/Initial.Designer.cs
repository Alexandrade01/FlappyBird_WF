
namespace FlappyBirds
{
    partial class Initial
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
            this.ground = new System.Windows.Forms.PictureBox();
            this.BtnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = global::FlappyBirds.Properties.Resources.floor;
            this.ground.Location = new System.Drawing.Point(-5, 513);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(655, 53);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 4;
            this.ground.TabStop = false;
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.MintCream;
            this.BtnStart.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnStart.Location = new System.Drawing.Point(242, 198);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(150, 65);
            this.BtnStart.TabIndex = 5;
            this.BtnStart.Text = "START";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // Initial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(642, 561);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.ground);
            this.MaximumSize = new System.Drawing.Size(658, 600);
            this.MinimumSize = new System.Drawing.Size(658, 600);
            this.Name = "Initial";
            this.Text = "Initial";
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Button BtnStart;
    }
}