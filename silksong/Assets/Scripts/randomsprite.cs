using UnityEngine;

public class RandomSpriteAssigner : MonoBehaviour
{
    public Sprite[] possibleSprites; // Drag your two sprites here in Inspector

    void Start()
    {
        // Pick a random sprite from the array and assign it
        if (possibleSprites.Length > 0)
        {
            SpriteRenderer sr = GetComponent<SpriteRenderer>();
            sr.sprite = possibleSprites[Random.Range(0, possibleSprites.Length)];
        }
    }
}
