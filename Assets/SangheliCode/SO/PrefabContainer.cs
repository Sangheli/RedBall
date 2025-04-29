using UnityEngine;
using UnityEngine.AddressableAssets;

[CreateAssetMenu(menuName = "Sangheli/PrefabContainer")]
public class PrefabContainer : ScriptableObject
{
   public AssetReference playerView;
   public AssetReference levelView;
   public AssetReference paralaxView;
}
