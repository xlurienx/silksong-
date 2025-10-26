using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float speed = 4f; // speed of enemy
    

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); // speed formula for only moving from right to left
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Shield") // enemy bounces other direction
        {
            speed *= -3f;
        }
       
        if (other.tag == "Player") // If touches player
        {
            PlayerHealth playerHealth = other.gameObject.GetComponent<PlayerHealth>(); // grabs the players health
            playerHealth.TakeDamage(1);
            PlayerKnockback playerKnockback = other.gameObject.GetComponent<PlayerKnockback>(); // grabes the players Knockback
            playerKnockback.Knockback(playerKnockback.transform.position - transform.position); //Knocks the player back away from enemy
            Destroy(gameObject);
        }

    }
}