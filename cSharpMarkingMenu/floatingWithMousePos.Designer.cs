namespace cSharpMarkingMenu
{
    partial class FloatingWithMousePos
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
            this.lblUp = new System.Windows.Forms.Label();
            this.lblUpRight = new System.Windows.Forms.Label();
            this.lblMidRight = new System.Windows.Forms.Label();
            this.lblMidLeft = new System.Windows.Forms.Label();
            this.lblUpLeft = new System.Windows.Forms.Label();
            this.lblDownRight = new System.Windows.Forms.Label();
            this.lblDownMid = new System.Windows.Forms.Label();
            this.lblDownLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUp
            // 
            this.lblUp.AutoSize = true;
            this.lblUp.BackColor = System.Drawing.Color.Black;
            this.lblUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblUp.ForeColor = System.Drawing.Color.White;
            this.lblUp.Location = new System.Drawing.Point(201, 14);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(67, 29);
            this.lblUp.TabIndex = 33;
            this.lblUp.Text = "copy";
            // 
            // lblUpRight
            // 
            this.lblUpRight.AutoSize = true;
            this.lblUpRight.BackColor = System.Drawing.Color.Black;
            this.lblUpRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblUpRight.ForeColor = System.Drawing.Color.White;
            this.lblUpRight.Location = new System.Drawing.Point(352, 50);
            this.lblUpRight.Name = "lblUpRight";
            this.lblUpRight.Size = new System.Drawing.Size(51, 29);
            this.lblUpRight.TabIndex = 35;
            this.lblUpRight.Text = "twit";
            // 
            // lblMidRight
            // 
            this.lblMidRight.AutoSize = true;
            this.lblMidRight.BackColor = System.Drawing.Color.Black;
            this.lblMidRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMidRight.ForeColor = System.Drawing.Color.White;
            this.lblMidRight.Location = new System.Drawing.Point(388, 201);
            this.lblMidRight.Name = "lblMidRight";
            this.lblMidRight.Size = new System.Drawing.Size(69, 29);
            this.lblMidRight.TabIndex = 36;
            this.lblMidRight.Text = "undo";
            // 
            // lblMidLeft
            // 
            this.lblMidLeft.AutoSize = true;
            this.lblMidLeft.BackColor = System.Drawing.Color.Black;
            this.lblMidLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMidLeft.ForeColor = System.Drawing.Color.White;
            this.lblMidLeft.Location = new System.Drawing.Point(14, 201);
            this.lblMidLeft.Name = "lblMidLeft";
            this.lblMidLeft.Size = new System.Drawing.Size(63, 29);
            this.lblMidLeft.TabIndex = 37;
            this.lblMidLeft.Text = "redo";
            // 
            // lblUpLeft
            // 
            this.lblUpLeft.AutoSize = true;
            this.lblUpLeft.BackColor = System.Drawing.Color.Black;
            this.lblUpLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblUpLeft.ForeColor = System.Drawing.Color.White;
            this.lblUpLeft.Location = new System.Drawing.Point(50, 50);
            this.lblUpLeft.Name = "lblUpLeft";
            this.lblUpLeft.Size = new System.Drawing.Size(109, 29);
            this.lblUpLeft.TabIndex = 38;
            this.lblUpLeft.Text = "google it";
            // 
            // lblDownRight
            // 
            this.lblDownRight.AutoSize = true;
            this.lblDownRight.BackColor = System.Drawing.Color.Black;
            this.lblDownRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDownRight.ForeColor = System.Drawing.Color.White;
            this.lblDownRight.Location = new System.Drawing.Point(352, 352);
            this.lblDownRight.Name = "lblDownRight";
            this.lblDownRight.Size = new System.Drawing.Size(70, 29);
            this.lblDownRight.TabIndex = 39;
            this.lblDownRight.Text = "mute";
            // 
            // lblDownMid
            // 
            this.lblDownMid.AutoSize = true;
            this.lblDownMid.BackColor = System.Drawing.Color.Black;
            this.lblDownMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDownMid.ForeColor = System.Drawing.Color.White;
            this.lblDownMid.Location = new System.Drawing.Point(201, 388);
            this.lblDownMid.Name = "lblDownMid";
            this.lblDownMid.Size = new System.Drawing.Size(75, 29);
            this.lblDownMid.TabIndex = 40;
            this.lblDownMid.Text = "paste";
            // 
            // lblDownLeft
            // 
            this.lblDownLeft.AutoSize = true;
            this.lblDownLeft.BackColor = System.Drawing.Color.Black;
            this.lblDownLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDownLeft.ForeColor = System.Drawing.Color.White;
            this.lblDownLeft.Location = new System.Drawing.Point(50, 352);
            this.lblDownLeft.Name = "lblDownLeft";
            this.lblDownLeft.Size = new System.Drawing.Size(91, 29);
            this.lblDownLeft.TabIndex = 41;
            this.lblDownLeft.Text = "refresh";
            // 
            // FloatingWithMousePos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::cSharpMarkingMenu.Properties.Resources.JoystickOutline_fw;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.lblDownLeft);
            this.Controls.Add(this.lblDownMid);
            this.Controls.Add(this.lblDownRight);
            this.Controls.Add(this.lblUpLeft);
            this.Controls.Add(this.lblMidLeft);
            this.Controls.Add(this.lblMidRight);
            this.Controls.Add(this.lblUpRight);
            this.Controls.Add(this.lblUp);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FloatingWithMousePos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "floatingWithMousePos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.floatingWithMousePos_Load);
            this.DoubleClick += new System.EventHandler(this.floatingWithMousePos_DoubleClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.floatingWithMousePos_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.floatingWithMousePos_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUp;
        private System.Windows.Forms.Label lblUpRight;
        private System.Windows.Forms.Label lblMidRight;
        private System.Windows.Forms.Label lblMidLeft;
        private System.Windows.Forms.Label lblUpLeft;
        private System.Windows.Forms.Label lblDownRight;
        private System.Windows.Forms.Label lblDownMid;
        private System.Windows.Forms.Label lblDownLeft;
    }
}