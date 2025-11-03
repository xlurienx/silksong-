using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public string Level1Scene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    public void ChangeScene()
    {
    // loads the scene on button press
        SceneManager.LoadScene(Level1Scene);
    }
}
