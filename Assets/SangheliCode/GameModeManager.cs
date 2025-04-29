using SangheliCore;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SangheliCode
{
    public class GameModeManager : IGameMode
    {
        public int WinCollectableValue => 15;

        public void Init()
        {
            G.Instance.OnCollectableUpdate += OnCollectable;
            G.Instance.GameStateUpdate += OnGameState;
        }

        public void Start()
        {
            G.Instance.GameStateUpdate.Invoke(GameState.Load);
        }

        private void OnGameState(GameState state)
        {
            if(state == GameState.Reload)
                ReloadCurrentScene();
            
            if(state == GameState.Load)
                Time.timeScale = 1;
        }

        private void OnCollectable()
        {
            if (G.Instance.collectibleCount >= WinCollectableValue) 
                OnWin();
        }

        public void OnWin()
        {
            Time.timeScale = 0;
            G.Instance.GameStateUpdate.Invoke(GameState.Win);
        }

        public void OnLose()
        {
            Time.timeScale = 0;
            G.Instance.GameStateUpdate.Invoke(GameState.Lose);
        }

        private void ReloadCurrentScene()
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
    }
}