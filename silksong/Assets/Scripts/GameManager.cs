using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    private void Awake()
    {
        playerHealth.OnDeath += Lose;
    }
    private void OnDestroy()
    {
        playerHealth.OnDeath -= Lose;
    }
    public void Lose()
    {
        SceneManager.LoadScene("endscreen");
    }
}
