using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    // declaring speed of player and their rigidbody
    public float speed = 5;
    public Rigidbody2D rb;

    Vector2 input;

    void Update()
    {
    // either WASD or arrow keys work for top down movement
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
    // speed formula
        rb.MovePosition(rb.position + input.normalized * speed * Time.deltaTime);
    }
}
