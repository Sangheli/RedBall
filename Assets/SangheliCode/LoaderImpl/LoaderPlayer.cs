using Cysharp.Threading.Tasks;
using UnityEngine;

namespace SangheliCode.Level
{
    public class LoaderPlayer : ILoader
    {
        public async UniTask Load(Transform levelParent)
        {
            var playerView = await ResourceLoader.Load<PlayerView>(G.dataContainer.prefabContainer.playerView);

            var playerController = new PlayerController();
            playerController.unitView = playerView;
            playerController.Init();
            
            G.cameraFollow.target = playerView.transform;
        }
    }
}