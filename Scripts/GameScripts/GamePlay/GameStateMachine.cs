public class GameStateMachine {
    public enum GameStates {Start, Play, Walk, Fight, Died, Help, End}
    public static GameStates currentGameState = GameStates.Start;

}