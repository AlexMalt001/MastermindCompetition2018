namespace MasterMindCompetition.GUI {
	partial class CodeRow {
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
			this.backOne = new System.Windows.Forms.PictureBox();
			this.backFour = new System.Windows.Forms.PictureBox();
			this.backThree = new System.Windows.Forms.PictureBox();
			this.backTwo = new System.Windows.Forms.PictureBox();
			this.pegOne = new System.Windows.Forms.PictureBox();
			this.pegTwo = new System.Windows.Forms.PictureBox();
			this.pegThree = new System.Windows.Forms.PictureBox();
			this.pegFour = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.backOne)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.backFour)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.backThree)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.backTwo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pegOne)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pegTwo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pegThree)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pegFour)).BeginInit();
			this.SuspendLayout();
			// 
			// backOne
			// 
			this.backOne.Image = global::MasterMindCompetition.Properties.Resources.pegSpace;
			this.backOne.Location = new System.Drawing.Point(0, 0);
			this.backOne.Margin = new System.Windows.Forms.Padding(0);
			this.backOne.Name = "backOne";
			this.backOne.Size = new System.Drawing.Size(40, 40);
			this.backOne.TabIndex = 0;
			this.backOne.TabStop = false;
			// 
			// backFour
			// 
			this.backFour.Image = global::MasterMindCompetition.Properties.Resources.pegSpace;
			this.backFour.Location = new System.Drawing.Point(120, 0);
			this.backFour.Margin = new System.Windows.Forms.Padding(0);
			this.backFour.Name = "backFour";
			this.backFour.Size = new System.Drawing.Size(40, 40);
			this.backFour.TabIndex = 1;
			this.backFour.TabStop = false;
			// 
			// backThree
			// 
			this.backThree.Image = global::MasterMindCompetition.Properties.Resources.pegSpace;
			this.backThree.Location = new System.Drawing.Point(80, 0);
			this.backThree.Margin = new System.Windows.Forms.Padding(0);
			this.backThree.Name = "backThree";
			this.backThree.Size = new System.Drawing.Size(40, 40);
			this.backThree.TabIndex = 2;
			this.backThree.TabStop = false;
			// 
			// backTwo
			// 
			this.backTwo.Image = global::MasterMindCompetition.Properties.Resources.pegSpace;
			this.backTwo.Location = new System.Drawing.Point(40, 0);
			this.backTwo.Margin = new System.Windows.Forms.Padding(0);
			this.backTwo.Name = "backTwo";
			this.backTwo.Size = new System.Drawing.Size(40, 40);
			this.backTwo.TabIndex = 3;
			this.backTwo.TabStop = false;
			// 
			// pegOne
			// 
			this.pegOne.Image = global::MasterMindCompetition.Properties.Resources.redPeg;
			this.pegOne.Location = new System.Drawing.Point(5, 5);
			this.pegOne.Margin = new System.Windows.Forms.Padding(5);
			this.pegOne.Name = "pegOne";
			this.pegOne.Size = new System.Drawing.Size(30, 30);
			this.pegOne.TabIndex = 4;
			this.pegOne.TabStop = false;
			this.pegOne.Click += new System.EventHandler(this.pegOne_Click);
			// 
			// pegTwo
			// 
			this.pegTwo.Image = global::MasterMindCompetition.Properties.Resources.redPeg;
			this.pegTwo.Location = new System.Drawing.Point(45, 5);
			this.pegTwo.Margin = new System.Windows.Forms.Padding(5);
			this.pegTwo.Name = "pegTwo";
			this.pegTwo.Size = new System.Drawing.Size(30, 30);
			this.pegTwo.TabIndex = 5;
			this.pegTwo.TabStop = false;
			this.pegTwo.Click += new System.EventHandler(this.pegTwo_Click);
			// 
			// pegThree
			// 
			this.pegThree.Image = global::MasterMindCompetition.Properties.Resources.redPeg;
			this.pegThree.Location = new System.Drawing.Point(85, 5);
			this.pegThree.Margin = new System.Windows.Forms.Padding(5);
			this.pegThree.Name = "pegThree";
			this.pegThree.Size = new System.Drawing.Size(30, 30);
			this.pegThree.TabIndex = 6;
			this.pegThree.TabStop = false;
			this.pegThree.Click += new System.EventHandler(this.pegThree_Click);
			// 
			// pegFour
			// 
			this.pegFour.Image = global::MasterMindCompetition.Properties.Resources.redPeg;
			this.pegFour.Location = new System.Drawing.Point(125, 5);
			this.pegFour.Margin = new System.Windows.Forms.Padding(5);
			this.pegFour.Name = "pegFour";
			this.pegFour.Size = new System.Drawing.Size(30, 30);
			this.pegFour.TabIndex = 7;
			this.pegFour.TabStop = false;
			this.pegFour.Click += new System.EventHandler(this.pegFour_Click);
			// 
			// CodeRow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pegFour);
			this.Controls.Add(this.pegThree);
			this.Controls.Add(this.pegTwo);
			this.Controls.Add(this.pegOne);
			this.Controls.Add(this.backTwo);
			this.Controls.Add(this.backThree);
			this.Controls.Add(this.backFour);
			this.Controls.Add(this.backOne);
			this.Name = "CodeRow";
			this.Size = new System.Drawing.Size(160, 40);
			((System.ComponentModel.ISupportInitialize)(this.backOne)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.backFour)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.backThree)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.backTwo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pegOne)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pegTwo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pegThree)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pegFour)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox backOne;
		private System.Windows.Forms.PictureBox backFour;
		private System.Windows.Forms.PictureBox backThree;
		private System.Windows.Forms.PictureBox backTwo;
		private System.Windows.Forms.PictureBox pegOne;
		private System.Windows.Forms.PictureBox pegTwo;
		private System.Windows.Forms.PictureBox pegThree;
		private System.Windows.Forms.PictureBox pegFour;
	}
}
