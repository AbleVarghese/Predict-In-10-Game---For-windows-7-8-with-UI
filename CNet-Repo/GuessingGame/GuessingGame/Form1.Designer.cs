namespace GuessingGame
{
    partial class GuessingGameWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLives = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lives:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLives);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblScore);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(351, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Location = new System.Drawing.Point(65, 44);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(0, 13);
            this.lblLives.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(65, 18);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 13);
            this.lblScore.TabIndex = 1;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnStartGame.Location = new System.Drawing.Point(51, 349);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(241, 60);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(351, 108);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(229, 111);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Message";
            // 
            // GuessingGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 422);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.groupBox1);
            this.Name = "GuessingGameWindow";
            this.Text = "Predict In 10 ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLives;
    }
}

