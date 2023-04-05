namespace AD_TakeHome_W6
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
            this.TB_Input = new System.Windows.Forms.TextBox();
            this.BTN_Play = new System.Windows.Forms.Button();
            this.WORDLE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Input
            // 
            this.TB_Input.Location = new System.Drawing.Point(133, 96);
            this.TB_Input.Name = "TB_Input";
            this.TB_Input.Size = new System.Drawing.Size(112, 20);
            this.TB_Input.TabIndex = 0;
            // 
            // BTN_Play
            // 
            this.BTN_Play.Location = new System.Drawing.Point(158, 140);
            this.BTN_Play.Name = "BTN_Play";
            this.BTN_Play.Size = new System.Drawing.Size(65, 23);
            this.BTN_Play.TabIndex = 1;
            this.BTN_Play.Text = "Play";
            this.BTN_Play.UseVisualStyleBackColor = true;
            this.BTN_Play.Click += new System.EventHandler(this.BTN_Play_Click);
            // 
            // WORDLE
            // 
            this.WORDLE.AutoSize = true;
            this.WORDLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WORDLE.Location = new System.Drawing.Point(111, 33);
            this.WORDLE.Name = "WORDLE";
            this.WORDLE.Size = new System.Drawing.Size(157, 37);
            this.WORDLE.TabIndex = 2;
            this.WORDLE.Text = "WORDLE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 244);
            this.Controls.Add(this.WORDLE);
            this.Controls.Add(this.BTN_Play);
            this.Controls.Add(this.TB_Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Input;
        private System.Windows.Forms.Button BTN_Play;
        private System.Windows.Forms.Label WORDLE;
    }
}

