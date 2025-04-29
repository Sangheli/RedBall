using System;
using System.Collections.Generic;
using SangheliCode;
using SangheliCode.Level;
using UnityEngine;

//Global Context
public class G
{
    public static G Instance;
    
    public UIManager uiManager;
    public InputManager inputManager;
    public DataContainer dataContainer;
    public BaseLoader baseLoader = new();
    public Transform parentLevel;
    public InputProxy inputProxy = new();
    
    public Action<GameState> GameStateUpdate;

    public CameraFollow cameraFollow;
    public GameState currentGameState;
    
    public readonly List<ILoader> loaders = new()
    {
        new LoaderLevel(),
        new LoaderPlayer(),
        new LoaderParalax()
    };

    public readonly List<IInput> inputProviders = new() { };

    private bool _active;

    public Action<int> OnCollectableFound;
    public Action OnCollectableUpdate;
    public int collectibleCount;
    
    public void Init(MonoBehContainer container)
    {
        GameStateUpdate += OnGameState;
        OnCollectableFound += OnCollectable;
        SetManagers(container);
        InitManagers();
    }

    private void OnCollectable(int value)
    {
        collectibleCount += value;
        OnCollectableUpdate.Invoke();
    }

    private void OnGameState(GameState state)
    {
        currentGameState = state;
    }

    private void SetManagers(MonoBehContainer container)
    {
        dataContainer = container.dataContainer;
        uiManager = container.uiManager;
        inputManager = container.inputManager;
        cameraFollow = container.cameraFollow;
        parentLevel = container.parentLevel;
        
        inputProviders.Add(uiManager.canvasGame);
        inputProviders.Add(inputManager);
    }

    private void InitManagers()
    {
        inputProxy.Init();
        uiManager.Init();
        inputManager.Init();
        baseLoader.Init();
        _active = true;
    }

    public void OnLateUpdate()
    {
        if(!_active) 
            return;
        
        inputProxy.OnLateUpdate();
    }
}
