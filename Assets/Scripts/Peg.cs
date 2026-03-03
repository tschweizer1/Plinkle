using System.Collections.Generic;
using UnityEngine;

public class Peg : MonoBehaviour
{
    public List<Sprite> Sprites;
    private int currentSpriteNumber = 0;
    private SpriteRenderer spriteRenderer;

    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Sprites[currentSpriteNumber];
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            OnBallHit();
        }
    }

    private void OnBallHit()
    {
        if (currentSpriteNumber >= 2)
        {
            Destroy(gameObject);
        }
        else
        {
            ShowNextSprite();
        }
    }

    private void ShowNextSprite()
    {
        currentSpriteNumber++;
        spriteRenderer.sprite = Sprites[currentSpriteNumber];
    }
}
