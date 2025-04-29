using TMPro;
using UnityEngine;

public class CanvasGameHud : MonoBehaviour
{
    [SerializeField] private TMP_Text textCollectibleCount;
    [SerializeField] private TMP_Text targetText;
    
    public void Init()
    {
        G.Instance.OnCollectableUpdate += OnCollectibleFound;
        targetText.text = $"{G.Instance.gameMode.WinCollectableValue}";
        OnCollectibleFound();
    }

    private void OnCollectibleFound()
    {
        textCollectibleCount.text = $"{G.Instance.collectibleCount}";
    }
}
