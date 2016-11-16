namespace WindowsFormsApplication6
{
    partial class HelloUser
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnClickMe = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Please enter your name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(118, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnClickMe
            // 
            this.btnClickMe.Location = new System.Drawing.Point(12, 90);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(118, 23);
            this.btnClickMe.TabIndex = 2;
            this.btnClickMe.Text = "Click Me";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(12, 116);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(118, 83);
            this.lblResult.TabIndex = 3;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 48);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(113, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Please enter your age:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(12, 64);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(118, 20);
            this.txtAge.TabIndex = 5;
            // 
            // HelloUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnClickMe);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "HelloUser";
            this.Text = "Hello User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
    }
}

