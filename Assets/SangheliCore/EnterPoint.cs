using SangheliCode;
using UnityEngine;

public class EnterPoint : MonoBehaviour
{
    [SerializeField] private MonoBehContainer monoBehContainer;
    
    private void Awake()
    {
        G.Instance = new G();
        G.Instance.Init(monoBehContainer);
        G.Instance.gameMode.Start();
    }

    private void LateUpdate()
    {
        G.Instance.OnLateUpdate();
    }
}
