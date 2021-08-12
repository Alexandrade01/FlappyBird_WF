
namespace FlappyBirds
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
            this.components = new System.ComponentModel.Container();
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gamerTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            this.SuspendLayout();
            // 
            // bird
            // 
            this.bird.Image = global::FlappyBirds.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(138, 246);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(64, 64);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // pipeDown
            // 
            this.pipeDown.Image = global::FlappyBirds.Properties.Resources.pipe;
            this.pipeDown.Location = new System.Drawing.Point(444, 339);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(120, 190);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 2;
            this.pipeDown.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::FlappyBirds.Properties.Resources.floor;
            this.ground.Location = new System.Drawing.Point(-11, 515);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(655, 53);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::FlappyBirds.Properties.Resources.pipe2;
            this.pipeTop.Location = new System.Drawing.Point(311, -9);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(120, 190);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 4;
            this.pipeTop.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Score: ";
            // 
            // gamerTimer
            // 
            this.gamerTimer.Enabled = true;
            this.gamerTimer.Interval = 20;
            this.gamerTimer.Tick += new System.EventHandler(this._gamerTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(642, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeDown);
            this.Controls.Add(this.bird);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(658, 600);
            this.MinimumSize = new System.Drawing.Size(658, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this._gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this._gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipeDown;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer gamerTimer;
    }
}

