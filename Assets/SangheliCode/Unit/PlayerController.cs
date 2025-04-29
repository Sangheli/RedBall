using UnityEngine;

public class PlayerController
{
    public IUnit unitView;
    
    public void Init()
    {
        G.OnMove += OnMove;
        G.OnJump += OnJump;
    }

    void OnMove(float value)
    {
        unitView.Move(value);
    }

    void OnJump(bool jump)
    {
        if(jump)
            unitView.Jump();
    }
}
