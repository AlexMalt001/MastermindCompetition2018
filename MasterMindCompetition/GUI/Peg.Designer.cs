namespace MasterMindCompetition.GUI {
	partial class Peg {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.pegOne = new System.Windows.Forms.PictureBox();
			this.backOne = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pegOne)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.backOne)).BeginInit();
			this.SuspendLayout();
			// 
			// pegOne
			// 
			this.pegOne.Image = global::MasterMindCompetition.Properties.Resources.redPeg;
			this.pegOne.Location = new System.Drawing.Point(5, 5);
			this.pegOne.Margin = new System.Windows.Forms.Padding(5);
			this.pegOne.Name = "pegOne";
			this.pegOne.Size = new System.Drawing.Size(30, 30);
			this.pegOne.TabIndex = 6;
			this.pegOne.TabStop = false;
			this.pegOne.Click += new System.EventHandler(this.pegOne_Click);
			// 
			// backOne
			// 
			this.backOne.Image = global::MasterMindCompetition.Properties.Resources.pegSpace;
			this.backOne.Location = new System.Drawing.Point(0, 0);
			this.backOne.Margin = new System.Windows.Forms.Padding(0);
			this.backOne.Name = "backOne";
			this.backOne.Size = new System.Drawing.Size(40, 40);
			this.backOne.TabIndex = 5;
			this.backOne.TabStop = false;
			// 
			// Peg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pegOne);
			this.Controls.Add(this.backOne);
			this.Name = "Peg";
			this.Size = new System.Drawing.Size(40, 40);
			((System.ComponentModel.ISupportInitialize)(this.pegOne)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.backOne)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pegOne;
		private System.Windows.Forms.PictureBox backOne;
	}
}
