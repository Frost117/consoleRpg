using ConsoleRpg.GUI;
using ConsoleRpg.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpg
{
    class Game
    {

        private bool end;
        public bool End
        {
            get { return this.end; }
            set { this.end = value; }
        }

        private Stack<BaseState> states;

        private void InitVariables()
        {
            this.end = false;
            this.states = new Stack<BaseState>();
        }

        private void InitStates()
        {
            this.states = new Stack<BaseState>();
            this.states.Push(new MainMenuState(this.states));
            this.states.Push(new GameState(this.states));

        }

        public Game()
        {
            this.InitVariables();
            this.InitStates();
        }

        public void Run()
        {
            while (this.states.Count > 0)
            {
				this.states.Peek().Update();

				if (this.states.Peek().RequestEnd())
                {
					this.states.Pop();
				}
			}

            Console.WriteLine("Game ended");
        }
    }
}
