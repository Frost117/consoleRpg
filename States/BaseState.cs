using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpg.States
{
	public class BaseState
	{
		protected Stack<BaseState> states;
		protected bool end = false;
		public BaseState(Stack<BaseState> states) 
		{
			this.states = states;
		}

		public bool RequestEnd()
		{
			return this.end;
		}
		
		virtual public void Update()
		{

		}
	}
}
