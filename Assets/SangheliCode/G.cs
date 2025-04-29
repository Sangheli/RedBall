using System;

//Global Context
public static class G
{
    public static UIManager UIManager;
    public static InputManager InputManager = new();

    public static Action<GameState> GameStateUpdate;

    public static void Init()
    {
        UIManager.Init();
    }
}
