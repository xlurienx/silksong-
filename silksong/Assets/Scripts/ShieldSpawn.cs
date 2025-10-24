using UnityEngine;

public class ShieldSpawn : MonoBehaviour

{
    public GameObject Shield; // referencing shield
    public int ShieldTimer = 300; // time allowed to have shield up
    public bool isShielded = false; // making shield accessible

    public Sprite spriteA; // Default sprite
    public Sprite spriteB; // Sprite to show after spacebar
    public float displayTime = 3f; // Time to show Sprite B

    private SpriteRenderer spriteRenderer;
    private bool isSwitching = false;
    private float timer = 0f;

    void Start()
    {
        Shield.SetActive(false); // shield is off on start of game

        // Get the SpriteRenderer attached to this GameObject
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = spriteA;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isShielded == false) // shield goes on w/ Space input
        {
            isShielded = true;
            spriteRenderer.sprite = spriteB;
            isSwitching = true;
        }

        if (ShieldTimer > 0 && isShielded == true) //shield initiation starts timer
        {
            Shield.SetActive(true);
            ShieldTimer--;
            spriteRenderer.sprite = spriteB;
            isSwitching = true;

        }

        if (ShieldTimer <= 0) // time runs out
        {
            Shield.SetActive(false); // shield goes inactive
            isShielded = false;
            ShieldTimer = 300; // timer set again for 300

            spriteRenderer.sprite = spriteA;
            isSwitching = false;

        }
    }
}