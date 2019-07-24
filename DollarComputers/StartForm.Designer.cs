namespace DollarComputers
{
    partial class StartForm
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
            this.startNewOrderBtn = new System.Windows.Forms.Button();
            this.loadSavedOrderBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startNewOrderBtn
            // 
            this.startNewOrderBtn.Location = new System.Drawing.Point(178, 138);
            this.startNewOrderBtn.Name = "startNewOrderBtn";
            this.startNewOrderBtn.Size = new System.Drawing.Size(120, 23);
            this.startNewOrderBtn.TabIndex = 0;
            this.startNewOrderBtn.Text = "&Start new order";
            this.startNewOrderBtn.UseVisualStyleBackColor = true;
            this.startNewOrderBtn.Click += new System.EventHandler(this.startNewOrderBtn_Click);
            // 
            // loadSavedOrderBtn
            // 
            this.loadSavedOrderBtn.Location = new System.Drawing.Point(178, 167);
            this.loadSavedOrderBtn.Name = "loadSavedOrderBtn";
            this.loadSavedOrderBtn.Size = new System.Drawing.Size(120, 23);
            this.loadSavedOrderBtn.TabIndex = 1;
            this.loadSavedOrderBtn.Text = "&Load saved order";
            this.loadSavedOrderBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(178, 196);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(120, 23);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.loadSavedOrderBtn);
            this.Controls.Add(this.startNewOrderBtn);
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startNewOrderBtn;
        private System.Windows.Forms.Button loadSavedOrderBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}