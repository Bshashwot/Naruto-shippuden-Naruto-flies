using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public float jumpForce = 6f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(0, jumpForce);
        }
    }
}