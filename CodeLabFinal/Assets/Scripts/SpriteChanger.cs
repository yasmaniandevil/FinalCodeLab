using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer; //calls sprite renderer in inspector
    public Sprite spriteReplacement; //calls new sprite in inspector



    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); //gets sprite renderer component
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpriteChange()
    {

        spriteRenderer.sprite = spriteReplacement; //public function that changes sprite

    }
}
