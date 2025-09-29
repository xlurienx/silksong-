using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 4f; // speed of enemy
    public bool canMove = true;

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
        if (other.tag == "Delete") // rids of enemy prefab
        {
            Destroy(gameObject);
        }
        if (other.tag == "Enemy") // deletes enemy tag
        {
            Destroy(gameObject);
        }
        if (other.tag == "Player") //loads the end screen
        {
            SceneManager.LoadScene("endscreen");
        }
    }
}