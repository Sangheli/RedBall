using System;
using System.Collections.Generic;
using SangheliCode;
using SangheliCode.Level;
using UnityEngine;

//Global Context
public static class G
{
    public static UIManager uiManager;
    public static InputManager inputManager;
    public static DataContainer dataContainer;
    public static BaseLoader baseLoader = new();
    public static Transform parentLevel;
    public static InputProxy inputProxy = new();
    
    public static Action<GameState> GameStateUpdate;
    public static CameraFollow cameraFollow;
    public static GameState currentGameState;
    
    public static readonly List<ILoader> loaders = new()
    {
        new LoaderLevel(),
        new LoaderPlayer(),
        new LoaderParalax()
    };

    public static readonly List<IInput> inputProviders = new() { };

    private static bool _active;

    public static void Init(MonoBehContainer container)
    {
        GameStateUpdate += OnGameState;
        SetManagers(container);
        InitManagers();
    }

    private static void OnGameState(GameState state)
    {
        currentGameState = state;
    }

    private static void SetManagers(MonoBehContainer container)
    {
        dataContainer = container.dataContainer;
        uiManager = container.uiManager;
        inputManager = container.inputManager;
        cameraFollow = container.cameraFollow;
        parentLevel = container.parentLevel;
        
        inputProviders.Add(uiManager.canvasGame);
        inputProviders.Add(inputManager);
    }

    private static void InitManagers()
    {
        inputProxy.Init();
        uiManager.Init();
        inputManager.Init();
        baseLoader.Init();
        _active = true;
    }

    public static void OnLateUpdate()
    {
        if(!_active) 
            return;
        
        inputProxy.OnLateUpdate();
    }
}
