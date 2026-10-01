using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float destroyBound;
    void Start()
    {
        // Calculate the left edge of the screen in world coordinates
        Camera mainCamera = Camera.main;
        if (mainCamera != null)
        {
            // Adding -2f padding so it disappears off-screen before being destroyed
            destroyBound = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x - 2f;
        } else
        {
            destroyBound = -15f; // Fallback value
        }
    }

    // Update is called once per frame
    void Update()
    {
      // Move pipe left
      transform.position += Vector3.left * (moveSpeed * Time.deltaTime);  

      // Destroy the pipe if it goes off-screen
      if (transform.position.x < destroyBound)
      {
        Destroy(gameObject);
      }
    }
}