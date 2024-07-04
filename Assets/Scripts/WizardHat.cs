
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardHat : MonoBehaviour
{

    private Collider2D hatCollider;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        hatCollider = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPickup()
    {
        hatCollider.enabled = false;
        spriteRenderer.sortingOrder = 10;
    }
}
