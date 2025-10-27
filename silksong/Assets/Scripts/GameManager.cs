using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Health playerHealth;
    public Health shoreHealth;
    private void Awake()
    {
        playerHealth.OnDeath += Lose;
        shoreHealth.OnDeath += Lose;
    }
    private void OnDestroy()
    {
        playerHealth.OnDeath -= Lose;
        shoreHealth.OnDeath -= Lose;
    }
    public void Lose()
    {
        SceneManager.LoadScene("endscreen");
    }
}
