using UnityEngine;

public class PlayerController
{
    public IUnit unitView;
    
    public void Init()
    {
        G.Instance.inputProxy.OnMove += OnMove;
        G.Instance.inputProxy.OnJump += OnJump;
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
