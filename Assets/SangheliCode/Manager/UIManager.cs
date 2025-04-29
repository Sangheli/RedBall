using UnityEngine;

public class UIManager : MonoBehaviour
{
   [SerializeField] public CanvasLoading canvasLoading;
   [SerializeField] public CanvasStart canvasStart;
   [SerializeField] public CanvasGame canvasGame;
   [SerializeField] public CanvasWin canvasWin;
   [SerializeField] public CanvasLose canvasLose;

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
