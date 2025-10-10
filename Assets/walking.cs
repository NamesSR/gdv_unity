using UnityEngine;

public class walking : MonoBehaviour

{
    public float moveSpeed = 5f;

    void Update()
    {
        // Get the horizontal input value
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate the movement amount
        float movement = horizontalInput * moveSpeed * Time.deltaTime;

        // Apply the movement to the player's position
        transform.Translate(Vector3.right * movement);
    }
}