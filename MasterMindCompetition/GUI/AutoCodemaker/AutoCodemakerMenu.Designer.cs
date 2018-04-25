namespace MasterMindCompetition.GUI.AutoCodemaker {
	partial class AutoCodemakerMenu {
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
			this.maxGuessesBox = new System.Windows.Forms.NumericUpDown();
			this.maxGuessesLabel = new System.Windows.Forms.Label();
			this.codeLengthLabel = new System.Windows.Forms.Label();
			this.codeLengthBox = new System.Windows.Forms.NumericUpDown();
			this.startButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.maxGuessesBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.codeLengthBox)).BeginInit();
			this.SuspendLayout();
			// 
			// maxGuessesBox
			// 
			this.maxGuessesBox.Location = new System.Drawing.Point(92, 14);
			this.maxGuessesBox.Name = "maxGuessesBox";
			this.maxGuessesBox.Size = new System.Drawing.Size(180, 20);
			this.maxGuessesBox.TabIndex = 0;
			// 
			// maxGuessesLabel
			// 
			this.maxGuessesLabel.AutoSize = true;
			this.maxGuessesLabel.Location = new System.Drawing.Point(12, 16);
			this.maxGuessesLabel.Name = "maxGuessesLabel";
			this.maxGuessesLabel.Size = new System.Drawing.Size(74, 13);
			this.maxGuessesLabel.TabIndex = 1;
			this.maxGuessesLabel.Text = "Max Guesses:";
			// 
			// codeLengthLabel
			// 
			this.codeLengthLabel.AutoSize = true;
			this.codeLengthLabel.Location = new System.Drawing.Point(12, 42);
			this.codeLengthLabel.Name = "codeLengthLabel";
			this.codeLengthLabel.Size = new System.Drawing.Size(71, 13);
			this.codeLengthLabel.TabIndex = 2;
			this.codeLengthLabel.Text = "Code Length:";
			// 
			// codeLengthBox
			// 
			this.codeLengthBox.Location = new System.Drawing.Point(92, 40);
			this.codeLengthBox.Name = "codeLengthBox";
			this.codeLengthBox.Size = new System.Drawing.Size(180, 20);
			this.codeLengthBox.TabIndex = 3;
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(197, 66);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(75, 23);
			this.startButton.TabIndex = 4;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// AutoCodemakerMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 100);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.codeLengthBox);
			this.Controls.Add(this.codeLengthLabel);
			this.Controls.Add(this.maxGuessesLabel);
			this.Controls.Add(this.maxGuessesBox);
			this.Name = "AutoCodemakerMenu";
			this.Text = "Auto-Codemaker Menu";
			((System.ComponentModel.ISupportInitialize)(this.maxGuessesBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.codeLengthBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown maxGuessesBox;
		private System.Windows.Forms.Label maxGuessesLabel;
		private System.Windows.Forms.Label codeLengthLabel;
		private System.Windows.Forms.NumericUpDown codeLengthBox;
		private System.Windows.Forms.Button startButton;
	}
}