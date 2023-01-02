using ConsoleRpg.Characters;
using ConsoleRpg.GUI;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleRpg.States
{
    public class MainMenuState : BaseState
	{
		protected ArrayList _players;
		protected Player _activePlayer;

        public MainMenuState(Stack<BaseState> states, ArrayList players) 
			: base(states)
		{
            _players = players;
			_activePlayer = null;
        }

		public void ProcessInput(int input)
		{
			switch (input)
			{
				case -1:
					this.end = true;
					break;

				case 1:
					this.StartNewGame();
					break;

				case 2:
                    this.states.Push(new CreatePlayerState(this.states, _players));
					break;

                case 3:
					this.SelectPlayer();
                    break;

                default:
					break;
			}
		}

		override public void Update()
		{
			if(_activePlayer != null)
			{
                Gui.Notification(_activePlayer.Banner() + "\n");
            }
				

            Gui.MenuTitle("Main menu");
            Gui.MenuOption(1, "New Game");
            Gui.MenuOption(2, "Create Player");
            Gui.MenuOption(3, "Select Player");
            Gui.MenuOption(-1, "Exit");

			int input = Gui.GetInputInt("Choose an option");

			this.ProcessInput(input);
		}

		public void StartNewGame()
		{
			if (_activePlayer == null)
			{
				Gui.Notification("There is no player selected. Select one to start the game");
			}
			else
			{
                this.states.Push(new GameState(this.states, _activePlayer));
            }
			
		}

		public void SelectPlayer()
		{
			if (_players.Count >= 1)
			{
                for (int i = 0; i < _players.Count; i++)
                {
                    Console.WriteLine(i + ": " + ((Player)_players[i]).GetName());
                }

                int choice = Gui.GetInputInt("Player selection");

                try
                {
                    _activePlayer = (Player)_players[choice];
                }
                catch (Exception msg)
                {
                    Gui.Notification(msg.Message);
                }

                if (_activePlayer != null)
                {
                    Gui.Notification($"{_activePlayer.GetName()} has been selected\n");
                }
                
			}

			else
			{
                Console.WriteLine("No players available\n");
            }
        }
	}
}
