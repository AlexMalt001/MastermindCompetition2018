namespace MasterMindCompetition.GUI.PVP {
	partial class CodemakerEntry {
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.submitButton = new System.Windows.Forms.Button();
			this.rowContainer = new System.Windows.Forms.Panel();
			this.enterCodeLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// submitButton
			// 
			this.submitButton.Location = new System.Drawing.Point(262, 105);
			this.submitButton.Margin = new System.Windows.Forms.Padding(5);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(75, 23);
			this.submitButton.TabIndex = 0;
			this.submitButton.Text = "Submit";
			this.submitButton.UseVisualStyleBackColor = true;
			this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
			// 
			// rowContainer
			// 
			this.rowContainer.Location = new System.Drawing.Point(12, 37);
			this.rowContainer.Name = "rowContainer";
			this.rowContainer.Size = new System.Drawing.Size(325, 60);
			this.rowContainer.TabIndex = 1;
			// 
			// enterCodeLabel
			// 
			this.enterCodeLabel.AutoSize = true;
			this.enterCodeLabel.Location = new System.Drawing.Point(12, 13);
			this.enterCodeLabel.Name = "enterCodeLabel";
			this.enterCodeLabel.Size = new System.Drawing.Size(72, 13);
			this.enterCodeLabel.TabIndex = 2;
			this.enterCodeLabel.Text = "Enter a Code:";
			// 
			// CodemakerEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 139);
			this.Controls.Add(this.enterCodeLabel);
			this.Controls.Add(this.rowContainer);
			this.Controls.Add(this.submitButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "CodemakerEntry";
			this.Text = "CodemakerEntry";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.Panel rowContainer;
		private System.Windows.Forms.Label enterCodeLabel;
	}
}