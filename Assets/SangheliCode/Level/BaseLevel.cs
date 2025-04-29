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
      if (state == GameState.Load)
         Load();
   }
#pragma warning restore CS4014
   
   public async UniTaskVoid Load()
   {
      var levelView = await ResourceLoader.Load<LevelView>(G.dataContainer.prefabContainer.levelView);
      levelView.transform.SetParent(transform);
      
      var playerView = await ResourceLoader.Load<PlayerView>(G.dataContainer.prefabContainer.playerView);

      var playerController = new PlayerController();
      playerController.unitView = playerView;
      playerController.Init();

      G.cameraFollow.target = playerView.transform;

      var paralax = await ResourceLoader.Load<ParallaxBackground_0>(G.dataContainer.prefabContainer.paralaxView);
      paralax.transform.SetParent(G.cameraFollow.transform);
      paralax.Init();
      
      G.GameStateUpdate.Invoke(GameState.Start);
   }
}
