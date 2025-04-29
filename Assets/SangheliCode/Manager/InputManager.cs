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
        ToggleInput(G.currentGameState == GameState.Game);
    }
    
    private void OnDisable()
    {
        ToggleInput(false);
    }
    
    public void Init()
    {
        G.GameStateUpdate += OnGameState;
        _inputActions.Player.Jump.started += ctx => G.OnJump?.Invoke(true);
        _inputActions.Player.Jump.canceled += ctx => G.OnJump?.Invoke(false);
    }
    
    private void OnGameState(GameState state)
    {
        ToggleInput(state == GameState.Game);
    }

    private void ToggleInput(bool state)
    {
        if (state)
        {
            _inputActions.Enable();
        }
        else
        {
            _inputActions.Disable();
        }
    }

    private void Update()
    {
        Vector2 move = _inputActions.Player.Move.ReadValue<Vector2>();
        G.OnMove?.Invoke(move.x);
    }
}