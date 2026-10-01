using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float jumpForce = 10f;
    [SerializeField]
    // private float moveSpeed = 5f;
    private Rigidbody2D rb;

    private InputAction jumpAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpAction = InputSystem.actions.FindAction("Jump");

    }

    // Update is called once per frame
    void Update()
    {
        if(jumpAction.WasPressedThisFrame()){
            rb.linearVelocity= new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }
    
}