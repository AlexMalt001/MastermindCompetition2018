using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterMindCompetition.Logic;

namespace MasterMindCompetition.GUI {
    public partial class MasterMindForm : Form, ICodemakerHostForm { //this must allows the display of all codemaker functions, hence the interface

        public MasterMindForm() {
            InitializeComponent();
        }


    }
}
