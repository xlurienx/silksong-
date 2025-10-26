using UnityEngine;

public class PlayerKnockback : MonoBehaviour
{
    public Rigidbody2D RB;
    public float knockbackForce = 3;
    public void Knockback(Vector2 direction)
    {
        RB.AddForce(direction.normalized * knockbackForce, ForceMode2D.Impulse);
        Debug.Log(direction);
    }
}
