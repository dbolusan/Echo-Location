using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Impatience : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    
    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public float timeRemaining = 30f;
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else {
            spriteRenderer.sprite = newSprite;
        }
    }
}