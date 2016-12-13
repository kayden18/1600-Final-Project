using System;
public class LevelBase {

    public LevelBase () {
        Game.StartGame += RunLevel;
    }

    private void RunLevel()
    {
        Console.WriteLine("Hey Anthony");
    }

    public string StartMessage;
    public bool entranceOpen = true;
    public string[] environment;  
    public string[] objects;
    public void Enter (){
        Console.WriteLine(StartMessage);
    }
    public void Encounter (int i, string traveled){
            switch (i)
            {
                case 0:
                    Console.WriteLine("You've " + traveled + " into " + objects[i]);
                break;

                case 1:
                    Console.WriteLine("You've " + traveled + " into " + objects[i]);
                break;
    
                case 2:
                    Console.WriteLine("You've " + traveled + " into " + objects[i]);
                    Game.GameTimer();
                    Random randomNum = new Random();
                    Game.UnderWater.Encounter(randomNum.Next(0, Game.UnderWater.objects.Length), "swam");
                break;

                case 3:
                //Kills us and ends the game
                    Console.WriteLine("You've " + traveled + " into " + objects[i]);
                    GameStateMachine.currentGameState = GameStateMachine.GameStates.Died;
                break;

                default:
                    Console.WriteLine("Your path is clear");
                break;
            }    
    } 
}