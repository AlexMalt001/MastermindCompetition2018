namespace MasterMindCompetition.GUI {
    partial class MasterMindForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated Code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the Code editor.
        /// </summary>
        private void InitializeComponent() {
			this.containerPanel = new System.Windows.Forms.Panel();
			this.startButton = new System.Windows.Forms.Button();
			this.submitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// containerPanel
			// 
			this.containerPanel.AutoScroll = true;
			this.containerPanel.Location = new System.Drawing.Point(12, 12);
			this.containerPanel.Name = "containerPanel";
			this.containerPanel.Size = new System.Drawing.Size(233, 314);
			this.containerPanel.TabIndex = 7;
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(251, 12);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(212, 50);
			this.startButton.TabIndex = 8;
			this.startButton.Text = "Start Game";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// submitButton
			// 
			this.submitButton.Location = new System.Drawing.Point(251, 281);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(212, 45);
			this.submitButton.TabIndex = 9;
			this.submitButton.Text = "Submit Code";
			this.submitButton.UseVisualStyleBackColor = true;
			this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
			// 
			// MasterMindForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(475, 338);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.containerPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MasterMindForm";
			this.Text = "Mastermind";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterMindForm_FormClosing);
			this.ResumeLayout(false);

        }

		#endregion
		private System.Windows.Forms.Panel containerPanel;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Button submitButton;
	}
}

