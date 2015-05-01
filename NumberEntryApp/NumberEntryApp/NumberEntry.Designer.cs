namespace NumberEntryApp
{
    partial class NumberEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.enterNumberTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.showNumberButton = new System.Windows.Forms.Button();
            this.showNumberListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sumResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number";
            // 
            // enterNumberTextBox
            // 
            this.enterNumberTextBox.Location = new System.Drawing.Point(130, 40);
            this.enterNumberTextBox.Name = "enterNumberTextBox";
            this.enterNumberTextBox.Size = new System.Drawing.Size(185, 20);
            this.enterNumberTextBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(347, 43);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // showNumberButton
            // 
            this.showNumberButton.Location = new System.Drawing.Point(332, 72);
            this.showNumberButton.Name = "showNumberButton";
            this.showNumberButton.Size = new System.Drawing.Size(110, 23);
            this.showNumberButton.TabIndex = 2;
            this.showNumberButton.Text = "Show All Number";
            this.showNumberButton.UseVisualStyleBackColor = true;
            this.showNumberButton.Click += new System.EventHandler(this.showNumberButton_Click);
            // 
            // showNumberListBox
            // 
            this.showNumberListBox.FormattingEnabled = true;
            this.showNumberListBox.Location = new System.Drawing.Point(130, 72);
            this.showNumberListBox.Name = "showNumberListBox";
            this.showNumberListBox.Size = new System.Drawing.Size(185, 134);
            this.showNumberListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sum Result";
            // 
            // sumResultTextBox
            // 
            this.sumResultTextBox.Location = new System.Drawing.Point(130, 218);
            this.sumResultTextBox.Name = "sumResultTextBox";
            this.sumResultTextBox.Size = new System.Drawing.Size(185, 20);
            this.sumResultTextBox.TabIndex = 4;
            // 
            // NumberEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 258);
            this.Controls.Add(this.showNumberListBox);
            this.Controls.Add(this.showNumberButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.sumResultTextBox);
            this.Controls.Add(this.enterNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NumberEntry";
            this.Text = "Number Entry UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enterNumberTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button showNumberButton;
        private System.Windows.Forms.ListBox showNumberListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sumResultTextBox;
    }
}

