using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.TryGetComponent<ObjectCollectable>(out var result)) 
            return;
        
        G.Instance.OnCollectableFound.Invoke(result.value);
        result.Collect();
    }    
}
