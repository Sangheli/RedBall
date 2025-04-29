using SangheliCode.Objects;
using UnityEngine;

namespace SangheliCode.Unit
{
    public class LoseWallDetector : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D other)
        {
            if (!other.TryGetComponent<ObjectLoseWall>(out var result)) 
                return;
            
            G.Instance.GameMode.OnLose();
        }
    }
}