using UnityEngine;

public class InputManager : MonoBehaviour, IInput
{
    private PlayerInputActions _inputActions;

    public float? ValueX { get; private set; }
    public bool? ValueJump { get; private set; }
    
    private void Awake()
    {
        _inputActions = new PlayerInputActions();
    }

    private void OnEnable()
    {
        if(G.Instance == null)
            return;
        
        ToggleInput(G.Instance.currentGameState == GameState.Game);
    }
    
    private void OnDisable()
    {
        if(G.Instance == null)
            return;
        
        ToggleInput(false);
    }
    
    public void Init()
    {
        G.Instance.GameStateUpdate += OnGameState;
        _inputActions.Player.Jump.started += ctx => OnJump(true);
        _inputActions.Player.Jump.canceled += ctx => OnJump(false);
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
        ValueX = move.x;
    }

    private void OnJump(bool state) => ValueJump = state;
}