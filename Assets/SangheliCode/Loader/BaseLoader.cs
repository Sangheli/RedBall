using Cysharp.Threading.Tasks;

public class BaseLoader
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

   private async UniTaskVoid Load()
   {
      foreach (var x in G.loaders) await x.Load(G.parentLevel);
      G.GameStateUpdate.Invoke(GameState.Start);
   }
}
