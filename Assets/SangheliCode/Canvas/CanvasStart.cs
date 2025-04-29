using UnityEngine;
using UnityEngine.UI;

public class CanvasStart : MonoBehaviour
{
    [SerializeField] private Button buttonPlay;

    private void Awake()
    {
        buttonPlay.onClick.AddListener(OnPlay);
    }

    private void OnPlay()
    {
        G.Instance.GameStateUpdate.Invoke(GameState.Game);
    }
}
