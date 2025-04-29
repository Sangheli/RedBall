using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerView : MonoBehaviour, IUnit
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 10f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float groundCheckRadius = 0.2f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private CircleCollider2D circleCollider;
    
    private void OnValidate()
    {
        rb ??= GetComponent<Rigidbody2D>();
        circleCollider ??= GetComponent<CircleCollider2D>();
    }

    public void Move(float value)
    {
        Vector2 velocity = rb.linearVelocity;
        velocity.x = value * moveSpeed;
        rb.linearVelocity = velocity;
    }

    public void Jump()
    {
        if (IsGrounded())
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    private bool IsGrounded()
    {
        var down = Vector2.down * (circleCollider.radius);
        Vector2 position = (Vector2)transform.position + down;
        return Physics2D.OverlapCircle(position, groundCheckRadius, groundLayer);
    }
}
