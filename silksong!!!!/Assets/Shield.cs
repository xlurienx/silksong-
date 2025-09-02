using UnityEngine;

public class Shield : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody2D rb;
    public GameObject shieldObject;

    Vector2 input;

    void Start()
    {
        if (shieldObject != null)
            shieldObject.SetActive(false);
    }

    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (shieldObject != null)
            {
                // Toggle shield visibility
                shieldObject.SetActive(!shieldObject.activeSelf);
            }
        }
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + input.normalized * speed * Time.deltaTime);
    }

}
