using UnityEngine;

public class EnterPoint : MonoBehaviour
{
    [SerializeField] private UIManager uiManager;
    [SerializeField] private DataContainer dataContainer;
    [SerializeField] private BaseLevel baseLevel;
    
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
        G.Init();
    }
}
