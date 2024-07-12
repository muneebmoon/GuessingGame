namespace GuessingGame
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
            this.checkbtn = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hintbtn = new System.Windows.Forms.Button();
            this.hintlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.attemptCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkbtn
            // 
            this.checkbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbtn.Location = new System.Drawing.Point(388, 192);
            this.checkbtn.Name = "checkbtn";
            this.checkbtn.Size = new System.Drawing.Size(124, 44);
            this.checkbtn.TabIndex = 0;
            this.checkbtn.Text = "Check";
            this.checkbtn.UseVisualStyleBackColor = true;
            this.checkbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // input
            // 
            this.input.AcceptsReturn = true;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(185, 197);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(197, 35);
            this.input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Guess what number is in mind?";
            // 
            // hintbtn
            // 
            this.hintbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintbtn.Location = new System.Drawing.Point(185, 259);
            this.hintbtn.Name = "hintbtn";
            this.hintbtn.Size = new System.Drawing.Size(91, 48);
            this.hintbtn.TabIndex = 3;
            this.hintbtn.Text = "Hint";
            this.hintbtn.UseVisualStyleBackColor = true;
            this.hintbtn.Click += new System.EventHandler(this.hintbtn_Click);
            // 
            // hintlabel
            // 
            this.hintlabel.AutoSize = true;
            this.hintlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintlabel.Location = new System.Drawing.Point(282, 269);
            this.hintlabel.Name = "hintlabel";
            this.hintlabel.Size = new System.Drawing.Size(0, 29);
            this.hintlabel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Attempt:";
            // 
            // attemptCount
            // 
            this.attemptCount.AutoSize = true;
            this.attemptCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attemptCount.Location = new System.Drawing.Point(501, 38);
            this.attemptCount.Name = "attemptCount";
            this.attemptCount.Size = new System.Drawing.Size(0, 25);
            this.attemptCount.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(185, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(408, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number must be between 1 -100 and an integer number!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 355);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.attemptCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hintlabel);
            this.Controls.Add(this.hintbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.checkbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkbtn;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hintbtn;
        private System.Windows.Forms.Label hintlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label attemptCount;
        private System.Windows.Forms.Label label3;
    }
}

