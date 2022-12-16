using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMovement : MonoBehaviour
{

    public GameObject objMove;
    public float speed = 2;
    public GameObject obstacle;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        //creating vector 2 called new pos, thats where it currently is

        newPos.x -= speed;
        //x position plus how fast 

        transform.position = newPos;
        //transform the actual position


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Hello");
            Destroy(obstacle); //will destroy object hit
            Destroy(objMove); //will destory object shot

            player.GetComponent<WASD>().rockPassed = true;
        }
     
    }
}
