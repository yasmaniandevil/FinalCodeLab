using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour
{
    public float speed = 0.1f; 
    public KeyCode leftKey = KeyCode.A;
    public KeyCode rightKey = KeyCode.D;
    
    //all booleans referenced in other scripts
    public bool move;
    public bool hasSword;
    public bool hasDynamite;
    public bool chestInteracted;
    public bool rockPassed;
  
 

    // Start is called before the first frame update
    void Start()
    {
        move = true; //sets boolean to true or false 
        hasSword = false;
        hasDynamite = false;
        chestInteracted = false;
        rockPassed = false;


}

    // Update is called once per frame
    void Update()
    {
        if (move == true) //if this is true, then player can use keys to move
        {
            Vector3 position = transform.position;

            if (Input.GetKey(leftKey))
            {
                position.x -= speed;
            
            }

            if (Input.GetKey(rightKey))
            {
                position.x += speed;
            }

            transform.position = position;
        }
    }

    public void SwordEquipped() //when called will call sprite change script to change sprite
    {
        hasSword = true; 
        hasDynamite = true;
        chestInteracted = true;
        if (hasSword == true) //chnages sprite if condition met
        {
            GetComponent<SpriteChanger>().SpriteChange();
        }
    }
}
