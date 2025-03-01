
namespace Calculator1
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
            this.lbNum1 = new System.Windows.Forms.Label();
            this.lbNum2 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNum1
            // 
            this.lbNum1.AutoSize = true;
            this.lbNum1.Location = new System.Drawing.Point(66, 52);
            this.lbNum1.Name = "lbNum1";
            this.lbNum1.Size = new System.Drawing.Size(29, 15);
            this.lbNum1.TabIndex = 0;
            this.lbNum1.Text = "Số a";
            // 
            // lbNum2
            // 
            this.lbNum2.AutoSize = true;
            this.lbNum2.Location = new System.Drawing.Point(66, 101);
            this.lbNum2.Name = "lbNum2";
            this.lbNum2.Size = new System.Drawing.Size(30, 15);
            this.lbNum2.TabIndex = 1;
            this.lbNum2.Text = "Số b";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(66, 151);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(47, 15);
            this.lbResult.TabIndex = 2;
            this.lbResult.Text = "Kết quả";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(131, 44);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(160, 23);
            this.txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(131, 93);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(160, 23);
            this.txtNum2.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(131, 143);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(160, 23);
            this.txtResult.TabIndex = 5;
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(216, 197);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(75, 23);
            this.btnCong.TabIndex = 6;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 265);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbNum2);
            this.Controls.Add(this.lbNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNum1;
        private System.Windows.Forms.Label lbNum2;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCong;
    }
}

