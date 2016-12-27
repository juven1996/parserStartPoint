namespace TestWebParser
{
    partial class Parser
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
            this.goButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.linkTextBox = new System.Windows.Forms.TextBox();
            this.getPageButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.parseSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.argumentTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(93, 135);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 34);
            this.goButton.TabIndex = 6;
            this.goButton.Text = "GO";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Link :";
            // 
            // linkTextBox
            // 
            this.linkTextBox.Location = new System.Drawing.Point(93, 15);
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.Size = new System.Drawing.Size(336, 22);
            this.linkTextBox.TabIndex = 8;
            // 
            // getPageButton
            // 
            this.getPageButton.Location = new System.Drawing.Point(93, 43);
            this.getPageButton.Name = "getPageButton";
            this.getPageButton.Size = new System.Drawing.Size(110, 35);
            this.getPageButton.TabIndex = 9;
            this.getPageButton.Text = "Get Page";
            this.getPageButton.UseVisualStyleBackColor = true;
            this.getPageButton.Click += new System.EventHandler(this.getPageButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status : ";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(90, 226);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Parse By: ";
            // 
            // parseSelectionComboBox
            // 
            this.parseSelectionComboBox.DisplayMember = "Tag Name";
            this.parseSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parseSelectionComboBox.FormattingEnabled = true;
            this.parseSelectionComboBox.Location = new System.Drawing.Point(94, 95);
            this.parseSelectionComboBox.Name = "parseSelectionComboBox";
            this.parseSelectionComboBox.Size = new System.Drawing.Size(121, 24);
            this.parseSelectionComboBox.TabIndex = 13;
            // 
            // argumentTextBox
            // 
            this.argumentTextBox.Location = new System.Drawing.Point(222, 96);
            this.argumentTextBox.Name = "argumentTextBox";
            this.argumentTextBox.Size = new System.Drawing.Size(207, 22);
            this.argumentTextBox.TabIndex = 14;
            // 
            // Parser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 266);
            this.Controls.Add(this.argumentTextBox);
            this.Controls.Add(this.parseSelectionComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.getPageButton);
            this.Controls.Add(this.linkTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.goButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Parser";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region private variables
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox linkTextBox;
        private System.Windows.Forms.Button getPageButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label statusLabel;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox parseSelectionComboBox;
        private System.Windows.Forms.TextBox argumentTextBox;
    }
}

