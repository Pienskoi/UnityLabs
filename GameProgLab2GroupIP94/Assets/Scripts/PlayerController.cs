using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private float jumpPower = 5f;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float groundedRadius = 0.5f;

    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        var move = new Vector3(horizontal, 0, vertical).normalized;
        
        _rb.velocity = new Vector3(move.x * speed, _rb.velocity.y, move.z * speed);
        
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            _rb.AddForce(Vector3.up * jumpPower, ForceMode.VelocityChange);
        }
    }

    private bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, groundedRadius, groundLayer, QueryTriggerInteraction.Ignore);
    }
}
