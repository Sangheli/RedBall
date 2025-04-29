using System;

//Global Context
public static class G
{
    public static UIManager uiManager;
    public static InputManager inputManager;
    public static DataContainer dataContainer;
    public static BaseLevel baseLevel;
    
    public static Action<GameState> GameStateUpdate;
    public static Action<float> OnMove;
    public static Action<bool> OnJump;

    public static void Init()
    {
        uiManager.Init();
        baseLevel.Init();
        inputManager.Init();
    }
}
