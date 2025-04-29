using UnityEngine;

public class EnterPoint : MonoBehaviour
{
    [SerializeField] private UIManager uiManager;
    
    private void Awake()
    {
        InitGlobalContext();
        G.GameStateUpdate.Invoke(GameState.Start);
    }

    private void InitGlobalContext()
    {
        G.UIManager = uiManager;
        G.Init();
    }
}
