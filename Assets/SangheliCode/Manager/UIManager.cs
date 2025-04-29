using UnityEngine;

public class UIManager : MonoBehaviour
{
   [SerializeField] private CanvasLoading canvasLoading;
   [SerializeField] private CanvasStart canvasStart;
   [SerializeField] private CanvasGame canvasGame;
   [SerializeField] private CanvasWin canvasWin;
   [SerializeField] private CanvasLose canvasLose;

   public void Init()
   {
      G.GameStateUpdate += SetGameState;
   }

   private void SetGameState(GameState state)
   {
      canvasLoading.gameObject.SetActive(state == GameState.Load);
      canvasStart.gameObject.SetActive(state == GameState.Start);
      canvasGame.gameObject.SetActive(state == GameState.Game);
      canvasWin.gameObject.SetActive(state == GameState.Win);
      canvasLose.gameObject.SetActive(state == GameState.Lose);
   }
}
