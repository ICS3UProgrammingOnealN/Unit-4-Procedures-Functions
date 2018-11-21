namespace PassReferenceOneal
{
    partial class RassReferenceForm
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
            this.lblDecimal = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.txtDecimalNumber = new System.Windows.Forms.TextBox();
            this.nudRoundNumber = new System.Windows.Forms.NumericUpDown();
            this.btnRound = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoundNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimal.Location = new System.Drawing.Point(12, 58);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(202, 24);
            this.lblDecimal.TabIndex = 0;
            this.lblDecimal.Text = "Enter Decimal Number";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.Location = new System.Drawing.Point(12, 169);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(332, 24);
            this.lblRound.TabIndex = 1;
            this.lblRound.Text = "Enter the number you want to round to";
            // 
            // txtDecimalNumber
            // 
            this.txtDecimalNumber.Location = new System.Drawing.Point(289, 63);
            this.txtDecimalNumber.Name = "txtDecimalNumber";
            this.txtDecimalNumber.Size = new System.Drawing.Size(100, 20);
            this.txtDecimalNumber.TabIndex = 2;
            // 
            // nudRoundNumber
            // 
            this.nudRoundNumber.Location = new System.Drawing.Point(376, 173);
            this.nudRoundNumber.Name = "nudRoundNumber";
            this.nudRoundNumber.Size = new System.Drawing.Size(120, 20);
            this.nudRoundNumber.TabIndex = 3;
            // 
            // btnRound
            // 
            this.btnRound.Location = new System.Drawing.Point(16, 302);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(75, 23);
            this.btnRound.TabIndex = 4;
            this.btnRound.Text = "btnRound";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // RassReferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 350);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.nudRoundNumber);
            this.Controls.Add(this.txtDecimalNumber);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblDecimal);
            this.Name = "RassReferenceForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRoundNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.TextBox txtDecimalNumber;
        private System.Windows.Forms.NumericUpDown nudRoundNumber;
        private System.Windows.Forms.Button btnRound;
    }
}

