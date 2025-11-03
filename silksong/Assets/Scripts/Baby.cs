using UnityEngine;

public class Baby : MonoBehaviour
{
    public Animator animator;
    public Sprite IdleSprite;
    public SpriteRenderer SpriteRenderer;
    public bool Idle;
    public Vector2 MoveDirection;
    private void Start()
    {
        if(Idle)
        {
            animator.enabled = false;
            SpriteRenderer.sprite= IdleSprite;

        }
    }
    private void Update()
    {
        if(!Idle)
        {
            transform.Translate(MoveDirection*Time.deltaTime,Space.World);
        }
    }
}
