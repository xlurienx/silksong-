using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 4f;
    private bool canMove;

    public Transform shieldCheck;
    public float shieldCheckRadius;
    public LayerMask whatIsShield;

    void Update()
    {
        canMove = Physics2D.OverlapCircle(shieldCheck.position, shieldCheckRadius, whatIsShield);

        if (canMove)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Shield")
        {
            speed *= -3f;
        }
        if (other.tag == "Shore")
        {
            Destroy(gameObject);
        }
        if (other.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}