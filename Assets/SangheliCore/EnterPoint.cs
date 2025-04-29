using SangheliCode;
using UnityEngine;

public class EnterPoint : MonoBehaviour
{
    [SerializeField] private MonoBehContainer monoBehContainer;
    
    private void Awake()
    {
        G.Init(monoBehContainer);
        G.GameStateUpdate.Invoke(GameState.Load);
    }
}
