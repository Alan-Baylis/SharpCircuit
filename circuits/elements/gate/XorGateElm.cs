using System;
using System.Collections;
using System.Collections.Generic;

namespace Circuits {

	public class XorGateElm : OrGateElm {

		public XorGateElm(CirSim s) : base(s) {
			
		}
		
		public override String getGateName() {
			return "XOR gate";
		}

		public override bool calcFunction() {
			int i;
			bool f = false;
			for (i = 0; i != inputCount; i++) {
				f ^= getInput(i);
			}
			return f;
		}

	}
}