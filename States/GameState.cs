using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpg.States
{
	public class GameState 
		: BaseState
	{
		public GameState(Stack<BaseState> states) 
			: base(states)
		{
			
		}
		override public void Update()
		{

			Console.WriteLine("Write a number.");
			int number = Convert.ToInt32(Console.ReadLine());

			if (number <= 0)
			{
				this.end = true;
			}
		}
	}
}
