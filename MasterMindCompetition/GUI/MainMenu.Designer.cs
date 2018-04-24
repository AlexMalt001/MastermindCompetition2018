namespace MasterMindCompetition.GUI {
	partial class MainMenuForm {
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
			this.gamemodeComboBox = new System.Windows.Forms.ComboBox();
			this.gamemodeLabel = new System.Windows.Forms.Label();
			this.startButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// gamemodeComboBox
			// 
			this.gamemodeComboBox.FormattingEnabled = true;
			this.gamemodeComboBox.Location = new System.Drawing.Point(105, 12);
			this.gamemodeComboBox.Name = "gamemodeComboBox";
			this.gamemodeComboBox.Size = new System.Drawing.Size(226, 21);
			this.gamemodeComboBox.TabIndex = 0;
			// 
			// gamemodeLabel
			// 
			this.gamemodeLabel.AutoSize = true;
			this.gamemodeLabel.Location = new System.Drawing.Point(12, 15);
			this.gamemodeLabel.Name = "gamemodeLabel";
			this.gamemodeLabel.Size = new System.Drawing.Size(64, 13);
			this.gamemodeLabel.TabIndex = 1;
			this.gamemodeLabel.Text = "Gamemode:";
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(226, 39);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(105, 23);
			this.startButton.TabIndex = 2;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// MainMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 70);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.gamemodeLabel);
			this.Controls.Add(this.gamemodeComboBox);
			this.Name = "MainMenuForm";
			this.Text = "Main Menu";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox gamemodeComboBox;
		private System.Windows.Forms.Label gamemodeLabel;
		private System.Windows.Forms.Button startButton;
	}
}