using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

public static class ResourceLoader
{
   public static async UniTask<T> Load<T>(AssetReference reference) where T : Object
   {
      var task = reference.InstantiateAsync();
      await task.Task;
      var result = task.Result;
      return result.GetComponent<T>();
   }
}
