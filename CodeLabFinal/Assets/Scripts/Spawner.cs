using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    //so i can access and change in inspector
    public GameObject Prefab;
    public GameObject player;
    public float yOffset = 1;
    public float xOffset = 1;

    float playerPosX;
    float playerPosY;



    Vector2 playerPosition; //Vector 2 for player position

    // Start is called before the first frame update
    void Start()
    {
        
    }

public void Spawn()
    {
        
        //instantiates new prefab based off player position
        GameObject newPrefab = Instantiate(Prefab, playerPosition, player.transform.rotation);  
    }

    void Update()
    {
        playerPosX = player.transform.position.x - xOffset;
        playerPosY = player.transform.position.y + yOffset;
        //postion x and y of the player

        //creates player position variable to be used in other function
        playerPosition = new Vector2(playerPosX, playerPosY);

    }
}
