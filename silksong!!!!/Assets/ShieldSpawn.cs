using UnityEngine;

public class ShieldSpawn : MonoBehaviour

{
    public GameObject Shield;
    public int ShieldTimer = 300;
    public bool isShielded = false;

    void Start()
    {
        Shield.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isShielded == false)
        {
            isShielded = true;
        }

        if (ShieldTimer > 0 && isShielded == true)
        {
            Shield.SetActive(true);
            ShieldTimer--;
        }

        if (ShieldTimer <= 0)
        {
            Shield.SetActive(false);
            isShielded = false;
            ShieldTimer = 300;
        }
    }
}