namespace PlayGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startButton = new System.Windows.Forms.Button();
            this.countdownLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.DimGray;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.startButton.FlatAppearance.BorderSize = 4;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("mono 07_66", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(201, 108);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(296, 118);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Begin Game";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // countdownLabel
            // 
            this.countdownLabel.AutoSize = true;
            this.countdownLabel.Font = new System.Drawing.Font("mono 07_65", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel.ForeColor = System.Drawing.Color.White;
            this.countdownLabel.Location = new System.Drawing.Point(178, 238);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(0, 31);
            this.countdownLabel.TabIndex = 1;
            this.countdownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(675, 376);
            this.Controls.Add(this.countdownLabel);
            this.Controls.Add(this.startButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Arcade Central";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label countdownLabel;
    }
}

