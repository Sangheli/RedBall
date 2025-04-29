using Cysharp.Threading.Tasks;
using UnityEngine;

namespace SangheliCode.Level
{
    public class LoaderParalax : ILoader
    {
        public async UniTask Load(Transform levelParent)
        {
            var paralax = await ResourceLoader.Load<ParallaxBackground_0>(G.Instance.dataContainer.prefabContainer.paralaxView);
            paralax.transform.SetParent(G.Instance.cameraFollow.transform);
            paralax.Init();
        }
    }
}