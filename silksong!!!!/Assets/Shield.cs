using UnityEngine;

public class ShowObjectOnInput : MonoBehaviour
{
    public GameObject targetObject; // The object to show
    public KeyCode activationKey = KeyCode.E; // Set which key to press

    void Start()
    {
        // Optional: hide the object at the start
        if (targetObject != null)
        {
            targetObject.SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(activationKey))
        {
            if (targetObject != null)
            {
                targetObject.SetActive(true);
            }
        }
    }
}