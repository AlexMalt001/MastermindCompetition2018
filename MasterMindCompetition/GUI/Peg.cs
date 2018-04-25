using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterMindCompetition.Logic;
using MasterMindCompetition.Properties;

namespace MasterMindCompetition.GUI {
	public partial class Peg : UserControl {
		public int index;
		public delegate void pegClickHandler(Peg sender, int pegNumber);
		public event pegClickHandler onClick;//triggered when a peg is clicked (likely to change it. this is handled in the main form)
		private Colour colour = Colour.Red; //red is the default colour
		public Colour Colour {
			get { return colour; }
			set {
				pegOne.Image = getImageForColour(value); //update the image
				colour = value; //update the data representation
			}
		}

		private Bitmap getImageForColour(Colour c) { //get the image relating to each colour
			switch (c) {
				case Colour.Green:
					return Resources.greenPeg;
				case Colour.Red:
					return Resources.redPeg;
				case Colour.Blue:
					return Resources.bluePeg;
				case Colour.Orange:
					return Resources.orangePeg;
				case Colour.Yellow:
					return Resources.yellowPeg;
				case Colour.Pink:
					return Resources.pinkPeg;
				default:
					throw (new Exception("I have no idea how this happened")); //this should never be thrown
			}
		}


		public Peg(int _index) {
			index = _index;
			InitializeComponent();
		}

		private void pegOne_Click(object sender, EventArgs e) {
			onClick?.Invoke(this, index);
		}
	}
}
