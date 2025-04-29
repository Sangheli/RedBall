using UnityEngine;
using UnityEngine.UI;

public class CanvasLose : MonoBehaviour
{
    [SerializeField] private Button buttonAction;

    private void Awake()
    {
        buttonAction.onClick.AddListener(OnAction);
    }

    private void OnAction()
    {
        G.Instance.GameStateUpdate.Invoke(GameState.Reload);
    }
}