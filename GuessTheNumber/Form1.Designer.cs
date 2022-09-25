
namespace GuessTheNumber
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
            this.newGameBtn = new System.Windows.Forms.Button();
            this.GuessBtn = new System.Windows.Forms.Button();
            this.guessInputTxb = new System.Windows.Forms.TextBox();
            this.resultsLbx = new System.Windows.Forms.ListBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newGameBtn
            // 
            this.newGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newGameBtn.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newGameBtn.Location = new System.Drawing.Point(16, 15);
            this.newGameBtn.Margin = new System.Windows.Forms.Padding(4);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(122, 40);
            this.newGameBtn.TabIndex = 0;
            this.newGameBtn.Text = "New game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // GuessBtn
            // 
            this.GuessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GuessBtn.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GuessBtn.Location = new System.Drawing.Point(16, 158);
            this.GuessBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GuessBtn.Name = "GuessBtn";
            this.GuessBtn.Size = new System.Drawing.Size(122, 40);
            this.GuessBtn.TabIndex = 1;
            this.GuessBtn.Text = "Guess";
            this.GuessBtn.UseVisualStyleBackColor = true;
            this.GuessBtn.Click += new System.EventHandler(this.GuessBtn_Click);
            // 
            // guessInputTxb
            // 
            this.guessInputTxb.Location = new System.Drawing.Point(16, 119);
            this.guessInputTxb.Margin = new System.Windows.Forms.Padding(4);
            this.guessInputTxb.Name = "guessInputTxb";
            this.guessInputTxb.Size = new System.Drawing.Size(398, 22);
            this.guessInputTxb.TabIndex = 2;
            this.guessInputTxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guessInputTxb_KeyPress);
            // 
            // resultsLbx
            // 
            this.resultsLbx.BackColor = System.Drawing.SystemColors.Control;
            this.resultsLbx.FormattingEnabled = true;
            this.resultsLbx.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.resultsLbx.ItemHeight = 16;
            this.resultsLbx.Location = new System.Drawing.Point(16, 206);
            this.resultsLbx.Margin = new System.Windows.Forms.Padding(4);
            this.resultsLbx.Name = "resultsLbx";
            this.resultsLbx.Size = new System.Drawing.Size(398, 148);
            this.resultsLbx.TabIndex = 3;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusLbl.Location = new System.Drawing.Point(13, 66);
            this.statusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(38, 20);
            this.statusLbl.TabIndex = 4;
            this.statusLbl.Text = "text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Your guess:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 377);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.resultsLbx);
            this.Controls.Add(this.guessInputTxb);
            this.Controls.Add(this.GuessBtn);
            this.Controls.Add(this.newGameBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guessing game";
            this.Load += new System.EventHandler(this.newGameBtn_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Button GuessBtn;
        private System.Windows.Forms.TextBox guessInputTxb;
        private System.Windows.Forms.ListBox resultsLbx;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label label1;
    }
}

