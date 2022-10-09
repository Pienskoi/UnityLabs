using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private float jumpPower = 6.5f;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float groundedRadius = 0.3f;

    private Rigidbody2D _rb;
    private float _horizontal;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            _rb.velocity = new Vector2(_rb.velocity.x, jumpPower);
        }
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(_horizontal * speed, _rb.velocity.y);
    }
    
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, groundedRadius, groundLayer);
    }
}
