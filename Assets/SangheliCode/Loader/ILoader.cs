using Cysharp.Threading.Tasks;
using UnityEngine;

public interface ILoader
{
    UniTask Load(Transform levelParent);
}
