using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health; // heart variable
    public int numOfHearts; //changing heart variable

    public Image[] hearts; // images
    public Sprite fullHeart; // sprite variable
    public Sprite emptyHeart; // sprite variable

    // Update is called once per frame
    void Update()
    {
        if(health > numOfHearts) // to make sure player does not have more health than health containters
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++) //health loop, dependent on what i (health) equals 
        {
            if(i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }

            else
            {
                hearts[i].enabled = false;
            }
        }
        if (health <= 0) // change scene to restart game if health = 0
        {
            SceneManager.LoadScene("endscreen");
        }
    }

    void OnTriggerEnter2D(Collider2D other) // health -1 if contact w enemy
    {
        if (other.tag == "Enemy")
        {
            health -= 1;
        }
    }
}