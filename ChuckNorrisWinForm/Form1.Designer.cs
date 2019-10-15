namespace ChuckNorrisWinForm
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
            this.btnGenerateJoke = new System.Windows.Forms.Button();
            this.DisplayJoke = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGenerateJoke
            // 
            this.btnGenerateJoke.Location = new System.Drawing.Point(118, 334);
            this.btnGenerateJoke.Name = "btnGenerateJoke";
            this.btnGenerateJoke.Size = new System.Drawing.Size(186, 47);
            this.btnGenerateJoke.TabIndex = 0;
            this.btnGenerateJoke.Text = "Chuck Norris Joke";
            this.btnGenerateJoke.UseVisualStyleBackColor = true;
            this.btnGenerateJoke.Click += new System.EventHandler(this.btnGenerateJoke_Click);
            // 
            // DisplayJoke
            // 
            this.DisplayJoke.FormattingEnabled = true;
            this.DisplayJoke.Location = new System.Drawing.Point(86, 88);
            this.DisplayJoke.Name = "DisplayJoke";
            this.DisplayJoke.Size = new System.Drawing.Size(244, 186);
            this.DisplayJoke.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 474);
            this.Controls.Add(this.DisplayJoke);
            this.Controls.Add(this.btnGenerateJoke);
            this.Name = "Form1";
            this.Text = "Chuck Norris Jokes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateJoke;
        private System.Windows.Forms.ListBox DisplayJoke;
    }
}

