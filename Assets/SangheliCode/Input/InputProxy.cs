using System;

public class InputProxy
{
    public Action<float> OnMove;
    public Action<bool> OnJump;

    private bool _active;

    public void Init()
    {
        G.GameStateUpdate += OnGameState;
    }

    private void OnGameState(GameState state)
    {
        _active = state == GameState.Game;
    }

    public void OnLateUpdate()
    {
        if(!_active)
            return;

        OnMove.Invoke(GetMoveX());
        OnJump.Invoke(GetJumpValue());
    }

    private static float GetMoveX()
    {
        foreach (var x in G.inputProviders)
        {
            var result = x.ValueX;
            if (result == null) continue;
            return result.Value;
        }

        return 0;
    }

    private bool GetJumpValue()
    {
        foreach (var x in G.inputProviders)
        {
            var result = x.ValueJump;
            if (result == null) continue;
            return result.Value;
        }

        return false;
    }
}