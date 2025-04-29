using Cysharp.Threading.Tasks;
using UnityEngine;

public class BaseLevel : MonoBehaviour
{
   public void Init()
   {
      G.GameStateUpdate += OnGameState;
   }

#pragma warning disable CS4014
   private void OnGameState(GameState state)
   {
      if (state == GameState.Start)
         Load();
   }
#pragma warning restore CS4014
   
   public async UniTaskVoid Load()
   {
      await ResourceLoader.Load<PlayerView>(G.dataContainer.prefabContainer.playerView);
   }
}
