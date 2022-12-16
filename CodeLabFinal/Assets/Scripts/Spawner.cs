using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    //so i can access and change in inspector
    public GameObject stonePrefab;
    public GameObject player;
    public float constantOffset;
    

    Vector2 playerPosition; //Vector 2 for player position

    // Start is called before the first frame update
    void Start()
    {
        
    }

public void Spawn()
    {
        
        //instantiates new prefab based off player position
        GameObject newPrefab = Instantiate(stonePrefab, player.transform.position, player.transform.rotation);  
    }

    void Update()
    {
        float playerPosX = player.transform.position.x;
        float playerPosY = player.transform.position.y;
        //postion of x y and of of the player


        playerPosition = new Vector2(playerPosX, playerPosY + constantOffset);

    }
}
