using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwordDisplay : MonoBehaviour
{
    public Sword Sword;
    public SpriteRenderer spriteRenderer;
    public Image artwork;

    public static int damage;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (Sword != null && Sword.artwork != null)
        {
            spriteRenderer.sprite = Sword.artwork;
            damage = Sword.attack;
        }
    }

  
}
