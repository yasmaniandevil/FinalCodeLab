using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    //reference game objects
    public GameObject player;
    //will be the border blocking the camera
    public float vBorder;
    public float hBorder;

    public float constantOffset; //will make camera position center of character and not bottom

    Vector3 playerPosition; //Vector3 for player position
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float playerPosX = player.transform.position.x;
        float playerPosY = player.transform.position.y; //playerPosX and Y references the position of the player character

        playerPosition = new Vector3(playerPosX, playerPosY + constantOffset, -10); //makes playerPosition the position of the player, but adds offset so it is not the bottom of the player

        transform.position = playerPosition; //makes camera position player position with offset

        if (transform.position.y < hBorder) //if camera height is less than the border
        {
            transform.position = new Vector3(playerPosX, hBorder, -10); //then the camera height will stay at border height
        }
        if (transform.position.x > vBorder) //same thing, but with width
        {
            transform.position = new Vector3(vBorder, playerPosY + constantOffset, -10);
        }
   
    }
}
