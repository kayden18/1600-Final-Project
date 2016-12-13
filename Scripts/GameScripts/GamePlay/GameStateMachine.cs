public class GameStateMachine{
    public enum GameStates{Start, Play, Walk, Fight, Help, End}
    public static GameStates currentGamestate = GameStates.Start;
}