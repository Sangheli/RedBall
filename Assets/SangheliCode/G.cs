using System;

//Global Context
public static class G
{
    public static UIManager uiManager;
    public static InputManager inputManager = new();
    public static DataContainer dataContainer;

    public static Action<GameState> GameStateUpdate;
    public static BaseLevel baseLevel;

    public static void Init()
    {
        uiManager.Init();
        baseLevel.Init();
    }
}
