using TMPro;
using UnityEngine;

public class CanvasGameHud : MonoBehaviour
{
    [SerializeField] private TMP_Text textCollectibleCount;
    
    public void Init()
    {
        G.Instance.OnCollectableUpdate += OnCollectibleFound;
        OnCollectibleFound();
    }

    private void OnCollectibleFound()
    {
        textCollectibleCount.text = $"{G.Instance.collectibleCount}";
    }
}
