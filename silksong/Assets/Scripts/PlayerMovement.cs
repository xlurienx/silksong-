using System.Collections;

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // declaring speed of player and their rigidbody
    public float speed = 5;
    public Rigidbody2D rb;

    private bool canDash = true;
    private bool isDashing;
    private float dashingPower = 15f; // speed
    private float dashingTime = 0.2f; // time period of dash
    private float dashingCooldown = 1f; // dash cooldown (1 second)
    public float MaxSpeed = 5; // Player's Max speed

    Vector2 input;

    void Update()
    {
        if (isDashing) 
        {
            return;
        }

        // either WASD or arrow keys work for top down movement
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash)
        {
            StartCoroutine(Dash());
        }
    }
    private void FixedUpdate()
    {
        if (isDashing)
        {
            return;
        }
        // speed formula
        // rb.MovePosition(rb.position + input.normalized * speed * Time.deltaTime); 
        rb.AddForce(input.normalized * speed);
        if (rb.linearVelocity.magnitude > MaxSpeed)
        {
            rb.linearVelocity = Vector2.ClampMagnitude(rb.linearVelocity, MaxSpeed); // This will cap the player's max speed if exceeded.
        }

    }

    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;

        // save current input direction
        Vector2 dashDirection = input.normalized;

        // apply dash velocity
        rb.linearVelocity = dashDirection * dashingPower;

        // wait during dash
        yield return new WaitForSeconds(dashingTime);

        // stop dash movement
        rb.linearVelocity = Vector2.zero;

        isDashing = false;

        // wait for cooldown
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;
    }
}
