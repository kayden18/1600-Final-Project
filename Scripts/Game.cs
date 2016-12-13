using System;
public class Game
{
    public static Action StartGame;
    public static bool canPlay = true;
    public Game()
    {
        Health.power = 100;
        Health.message = "You are getting stronger.";
        Ammo.message = "You have more ammo";
        Cave.StartMessage = "You have entered a cave.";
        UnderWater.objects = new string[] { "SeaWead", "Coral", "Fish", "Shark" };
    }

    private string gameState = "Start";
    private GameStateMachine.GameStates toEnum;
    public void Play()
    {
        
        switch (toEnum)
        {
            case GameStateMachine.GameStates.Start:
            
                Console.WriteLine("Please type in your name:");
                name = Console.ReadLine();
                Console.WriteLine("Your Player Name is " + name);

                Console.WriteLine("Play commands: Play, End, Help");

                gameState = Console.ReadLine();

                if(Enum.TryParse(gameState, out toEnum))
                    Play();

                break;
            
            case GameStateMachine.GameStates.Died:
                Console.WriteLine("You Died");
                GameStateMachine.currentGameState = GameStateMachine.GameStates.End;
                Play();
                break;

            case GameStateMachine.GameStates.End:
                Console.WriteLine("Game Over");
                Environment.Exit(0);
                break;

            case GameStateMachine.GameStates.Help:
                Console.WriteLine("What do you need help for. If you can't play this game, you have issues.");
                Play();
                break;

            case GameStateMachine.GameStates.Play:
                while (Game.canPlay)
                {
                    Cave.Enter();
                    Random randomNum = new Random();
                    Cave.Encounter(randomNum.Next(0, Cave.objects.Length), "walked");
                    GameTimer();
                    Play();
                }
                
                break;

            default:
                Console.WriteLine(" is not a valid option.");
                Play();
                break;
        }

       
    }

    public static void GameTimer()
    {
        System.Threading.Thread.Sleep(2000);
    }

    //Game Levels
    private LevelBase Cave = new CaveLevel();
    public static LevelBase UnderWater = new LevelBase();
    //Game PowerUps
    public PowerUpBase Health = new PowerUpBase();
    public PowerUpBase Ammo = new PowerUpBase();

    //Game Weapons
    private WeaponBase Gun = new WeaponBase();
    private WeaponBase Rifle = new WeaponBase();

    public string name;
    private int score;
}

/*
        After prompt the game for a name we:
        Enter a cave
        find Health.
        Meet a dragon. (need an enemy class)
        Pick weapon.
        Battle dragon. (Battle class)
        If we win: get Health and ammo
        if dragon wins: loose Health;
        */