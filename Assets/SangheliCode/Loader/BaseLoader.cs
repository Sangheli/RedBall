using Cysharp.Threading.Tasks;

public class BaseLoader
{
   public void Init()
   {
      G.Instance.GameStateUpdate += OnGameState;
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
      foreach (var x in G.Instance.loaders) await x.Load(G.Instance.parentLevel);
      G.Instance.GameStateUpdate.Invoke(GameState.Start);
   }
}
