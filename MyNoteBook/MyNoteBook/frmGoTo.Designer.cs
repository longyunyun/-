namespace MyNoteBook
{
    partial class frmGoTo
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
            this.txtLine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn转到 = new System.Windows.Forms.Button();
            this.btn取消 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(25, 25);
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(320, 28);
            this.txtLine.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "行号（L）：";
            // 
            // btn转到
            // 
            this.btn转到.Location = new System.Drawing.Point(152, 59);
            this.btn转到.Name = "btn转到";
            this.btn转到.Size = new System.Drawing.Size(92, 32);
            this.btn转到.TabIndex = 2;
            this.btn转到.Text = "转到";
            this.btn转到.UseVisualStyleBackColor = true;
            this.btn转到.Click += new System.EventHandler(this.btn转到_Click);
            // 
            // btn取消
            // 
            this.btn取消.Location = new System.Drawing.Point(250, 59);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(95, 32);
            this.btn取消.TabIndex = 3;
            this.btn取消.Text = "取消";
            this.btn取消.UseVisualStyleBackColor = true;
            this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
            // 
            // frmGoTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 94);
            this.Controls.Add(this.btn取消);
            this.Controls.Add(this.btn转到);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGoTo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "转到指定行";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn转到;
        private System.Windows.Forms.Button btn取消;
    }
}