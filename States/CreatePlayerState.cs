using ConsoleRpg.Characters;
using ConsoleRpg.GUI;
using System.Collections;

namespace ConsoleRpg.States
{
    public class CreatePlayerState : BaseState
    {

        protected ArrayList _players;

        public CreatePlayerState(Stack<BaseState> states, ArrayList players)
        : base(states)
        {
            _players = players;
        }

        public void ProcessInput(int input)
        {
            switch (input)
            {
                case -1:
                    this.end = true;
                    break;
                case 1:
                    this.CreatePlayer();
                    break;
                case 3:
                    this.DeletePlayer();
                    break;
                default:
                    break;
            }        
        }


        override public void Update()
        {
            Gui.MenuTitle("Player Creator");
            Gui.MenuOption(1, "New Player");
            Gui.MenuOption(2, "Edit Player");
            Gui.MenuOption(3, "Delete Player");
            Gui.MenuOption(-1, "Go back");

            int input = Gui.GetInputInt("Type a number to choose");

            this.ProcessInput(input);
        }

        private void CreatePlayer()
        {
            String name = "";
            String description = "";
            Gui.GetInput("Input player name");
            name = Console.ReadLine();


            Gui.GetInput("Input player details");
            description = Console.ReadLine();

            this._players.Add(new Player(name, description));
            
            Gui.Notification("Player created");
        }

        private void DeletePlayer()
        {
            this._players.Clear();
            
            Gui.Notification("Players deleted");
        }

    }
}
