using UnityEngine;
using UnityEngine.InputSystem;

public class jump: MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    public float jumpForce = 10f;

    private Rigidbody2D rb;

    private InputAction jumpAction;
    public AudioSource s;
    public ScoreManager scoreManager;

    void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            jumpAction = InputSystem.actions.FindAction("Jump");
        }
        // Update is called once per frame
        void Update()
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            // Jump
            bool spacePressed = Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame;
            bool jumpPressed = jumpAction != null && jumpAction.WasPressedThisFrame();

            if (spacePressed || jumpPressed) {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            s.Play();
        }
        
        }
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Trigger"))
            {
                scoreManager.AddScore();
            }
        }

}