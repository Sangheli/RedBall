using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class HoldButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public event Action<bool> OnHold;
    public void OnPointerDown(PointerEventData eventData) => OnHold?.Invoke(true);
    public void OnPointerUp(PointerEventData eventData) => OnHold?.Invoke(false);
}