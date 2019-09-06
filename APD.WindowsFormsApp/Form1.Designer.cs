namespace APD.WindowsFormsApp
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
            this.domainTextBox = new System.Windows.Forms.TextBox();
            this.domainLabel = new System.Windows.Forms.Label();
            this.getIpButton = new System.Windows.Forms.Button();
            this.myIpLabel = new System.Windows.Forms.Label();
            this.deadlockButton = new System.Windows.Forms.Button();
            this.asynchronousWaitButton = new System.Windows.Forms.Button();
            this.synchronousWaitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // domainTextBox
            // 
            this.domainTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.domainTextBox.Location = new System.Drawing.Point(98, 12);
            this.domainTextBox.Name = "domainTextBox";
            this.domainTextBox.Size = new System.Drawing.Size(266, 29);
            this.domainTextBox.TabIndex = 0;
            this.domainTextBox.Text = "https://api.ipify.org";
            // 
            // domainLabel
            // 
            this.domainLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.domainLabel.Location = new System.Drawing.Point(12, 15);
            this.domainLabel.Name = "domainLabel";
            this.domainLabel.Size = new System.Drawing.Size(80, 23);
            this.domainLabel.TabIndex = 1;
            this.domainLabel.Text = "Domain:";
            // 
            // getIpButton
            // 
            this.getIpButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.getIpButton.Location = new System.Drawing.Point(258, 134);
            this.getIpButton.Name = "getIpButton";
            this.getIpButton.Size = new System.Drawing.Size(106, 37);
            this.getIpButton.TabIndex = 2;
            this.getIpButton.Text = "Get my IP";
            this.getIpButton.UseVisualStyleBackColor = true;
            this.getIpButton.Click += new System.EventHandler(this.getIpButton_Click);
            // 
            // myIpLabel
            // 
            this.myIpLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.myIpLabel.Location = new System.Drawing.Point(10, 239);
            this.myIpLabel.Name = "myIpLabel";
            this.myIpLabel.Size = new System.Drawing.Size(354, 23);
            this.myIpLabel.TabIndex = 3;
            this.myIpLabel.Text = "My public IP is:";
            // 
            // deadlockButton
            // 
            this.deadlockButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.deadlockButton.Location = new System.Drawing.Point(258, 177);
            this.deadlockButton.Name = "deadlockButton";
            this.deadlockButton.Size = new System.Drawing.Size(106, 37);
            this.deadlockButton.TabIndex = 4;
            this.deadlockButton.Text = "Deadlock!";
            this.deadlockButton.UseVisualStyleBackColor = true;
            this.deadlockButton.Click += new System.EventHandler(this.deadlockButton_Click);
            // 
            // asynchronousWaitButton
            // 
            this.asynchronousWaitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.asynchronousWaitButton.Location = new System.Drawing.Point(146, 91);
            this.asynchronousWaitButton.Name = "asynchronousWaitButton";
            this.asynchronousWaitButton.Size = new System.Drawing.Size(218, 37);
            this.asynchronousWaitButton.TabIndex = 4;
            this.asynchronousWaitButton.Text = "Asynchronous wait";
            this.asynchronousWaitButton.UseVisualStyleBackColor = true;
            this.asynchronousWaitButton.Click += new System.EventHandler(this.asynchronousWaitButton_Click);
            // 
            // synchronousWaitButton
            // 
            this.synchronousWaitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.synchronousWaitButton.Location = new System.Drawing.Point(146, 48);
            this.synchronousWaitButton.Name = "synchronousWaitButton";
            this.synchronousWaitButton.Size = new System.Drawing.Size(218, 37);
            this.synchronousWaitButton.TabIndex = 5;
            this.synchronousWaitButton.Text = "Synchronous wait";
            this.synchronousWaitButton.UseVisualStyleBackColor = true;
            this.synchronousWaitButton.Click += new System.EventHandler(this.synchronousWaitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 355);
            this.Controls.Add(this.synchronousWaitButton);
            this.Controls.Add(this.asynchronousWaitButton);
            this.Controls.Add(this.deadlockButton);
            this.Controls.Add(this.myIpLabel);
            this.Controls.Add(this.getIpButton);
            this.Controls.Add(this.domainLabel);
            this.Controls.Add(this.domainTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label domainLabel;
        private System.Windows.Forms.TextBox domainTextBox;
        private System.Windows.Forms.Label myIpLabel;
        private System.Windows.Forms.Button deadlockButton;
        private System.Windows.Forms.Button getIpButton;
        private System.Windows.Forms.Button asynchronousWaitButton;
        private System.Windows.Forms.Button synchronousWaitButton;
    }
}