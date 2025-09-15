using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 4f;
    public bool canMove = true;



    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Shield")
        {
            speed *= -3f;
        }
        if (other.tag == "Delete")
        {
            Destroy(gameObject);
        }
        if (other.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("endscreen");
        }
    }
}