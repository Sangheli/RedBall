using UnityEngine;

public class EnterPoint : MonoBehaviour
{
    [SerializeField] private UIManager uiManager;
    [SerializeField] private DataContainer dataContainer;
    [SerializeField] private BaseLevel baseLevel;
    [SerializeField] private InputManager inputManager;
    [SerializeField] private CameraFollow cameraFollow;
    
    private void Awake()
    {
        InitGlobalContext();
        G.GameStateUpdate.Invoke(GameState.Start);
    }

    private void InitGlobalContext()
    {
        G.dataContainer = dataContainer;
        G.uiManager = uiManager;
        G.baseLevel = baseLevel;
        G.inputManager = inputManager;
        G.cameraFollow = cameraFollow;
        G.Init();
    }
}
