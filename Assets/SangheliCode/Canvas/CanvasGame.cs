using UnityEngine;

public class CanvasGame : MonoBehaviour, IInput
{
    [SerializeField] private HoldButton buttonLeft;
    [SerializeField] private HoldButton buttonRight;
    [SerializeField] private HoldButton buttonJump;

    public float? ValueX { get; private set; }
    public bool? ValueJump { get; private set; }

    private void Awake()
    {
        buttonLeft.OnHold += isHold => OnMove(-1, isHold);
        buttonRight.OnHold += isHold => OnMove(1, isHold);
        buttonJump.OnHold += isHold => OnJump(true, isHold);
    }

    private void OnMove(int direction, bool isHold) => ValueX = isHold ? direction : null;
    private void OnJump(bool state, bool isHold) => ValueJump = isHold ? state : null;
}
