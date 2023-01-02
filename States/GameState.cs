using ConsoleRpg.Characters;
using ConsoleRpg.GUI;

namespace ConsoleRpg.States
{
    public class GameState 
		: BaseState
	{

        protected Player _character;

        public GameState(Stack<BaseState> states, Player activeCharacter) 
			: base(states)
		{
			_character = activeCharacter;
		}

        public void ProcessInput(int input)
        {
            switch (input)
            {
                case -1:
                    this.end = true;
                    break;
                case 1:
                    Console.WriteLine(_character.PlayerInformation());
                    break;
                case 2: 
                    Console.WriteLine(_character.DetailedPlayerInformation());
                    break;
                default:
                    break;
            }
        }

        override public void Update()
		{
            Gui.MenuTitle("Game State");
            Gui.MenuOption(1, "Character information");
            Gui.MenuOption(2, "Get detailed character info");
            Gui.MenuOption(-1, "Go back\n");
			
			int number = Gui.GetInputInt("Write a number to choose.");

            this.ProcessInput(number);
		}
	}
}
