using ConsoleRpg.States;
using System.Collections;

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
        private ArrayList players;

        private void InitVariables()
        {
            this.end = false;
            this.states = new Stack<BaseState>();
        }

        private void InitPlayers()
        {
            this.players = new ArrayList();
        }

        private void InitStates()
        {
            this.states = new Stack<BaseState>();
            this.states.Push(new MainMenuState(this.states, this.players));

        }

        public Game()
        {
            this.InitVariables();
            this.InitPlayers();
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
