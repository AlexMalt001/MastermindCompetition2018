using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindCompetition.GUI {
	interface IGamemode {
		void runGamemode();
		string Name { get; }
	}
}
