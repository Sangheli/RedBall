using SangheliCore;
using UnityEngine.SceneManagement;

namespace SangheliCode
{
    public class GameModeManager : IGameMode
    {
        public int WinCollectableValue => 15;

        public void Init()
        {
            G.Instance.OnCollectableUpdate += OnCollectable;
        }

        private void OnCollectable()
        {
            if (G.Instance.collectibleCount >= WinCollectableValue) 
                OnWin();
        }

        public void OnWin()
        {
            ReloadCurrentScene();
        }

        public void OnLose()
        {
            ReloadCurrentScene();
        }

        private void ReloadCurrentScene()
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
    }
}