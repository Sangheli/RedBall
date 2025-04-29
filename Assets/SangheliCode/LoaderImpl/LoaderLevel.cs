using Cysharp.Threading.Tasks;
using UnityEngine;

namespace SangheliCode.Level
{
    public class LoaderLevel : ILoader
    {
        public async UniTask Load(Transform levelParent)
        {
            var levelView = await ResourceLoader.Load<LevelView>(G.dataContainer.prefabContainer.levelView);
            levelView.transform.SetParent(levelParent);
        }
    }
}