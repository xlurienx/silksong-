using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody2D rb;

    Vector2 input;

    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + input.normalized * speed * Time.deltaTime);
    }
}
