using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerInputActions _inputActions;

    private void Awake()
    {
        _inputActions = new PlayerInputActions();
    }

    private void OnEnable()
    {
        _inputActions.Enable();
    }
    
    private void OnDisable()
    {
        _inputActions.Disable();
    }
    
    public void Init()
    {
        _inputActions.Player.Jump.started += ctx => G.OnJump?.Invoke(true);
        _inputActions.Player.Jump.canceled += ctx => G.OnJump?.Invoke(false);
    }
    
    private void Update()
    {
        Vector2 move = _inputActions.Player.Move.ReadValue<Vector2>();
        G.OnMove?.Invoke(move.x);
    }
}