using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideScript : MonoBehaviour
{
    public GameObject obj;
    public GameObject player;
    public GameObject button;

    public float speed;

    public bool hide;
    public float timer;


    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        hide = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (hide == true)
        {
            player.SetActive(false); //will hide the player
            timer += Time.deltaTime; //timer will start
            Vector2 newPos = obj.transform.position; 
            //creating vector 2 called new pos, referencing current location

            newPos.x += speed;
            //adds speed to x position every frame

            obj.transform.position = newPos; //scorpion will move
            //transforms the position
        }


        if (timer > 4) //when timeer passes 4 seconds
        {

            player.SetActive(true); //player is back
            player.GetComponent<WASD>().move = true; //player can movve
            button.SetActive(false); //button is gone   
        }
    }

    public void Hide()
    {
        hide = true; //will start timer
    }
}
