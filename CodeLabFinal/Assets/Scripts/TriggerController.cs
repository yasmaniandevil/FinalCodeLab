using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TriggerController : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject dynamiteButton;
    public GameObject swordButton;
    public GameObject displayText;

    public GameObject player;




     void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("enter");
        if (collision.gameObject.CompareTag("Player"))
        {
            button1.SetActive(true);
            //spawns the button on trigger 

            if (player.GetComponent<WASD>().chestInteracted == false) //spawns button if condition met
            {
                button2.SetActive(true);
            }
           

            /*if (Input.GetButtonDown("Pickup"))
            {
                Debug.Log("Clicked button");
                Objects.SetActive(false);
            }*/
            displayText.SetActive(true); //spawns text

            player.GetComponent<WASD>().move = false; //makes player stop being able to move

            if (player.GetComponent<WASD>().hasDynamite == true) 
            {
                dynamiteButton.SetActive(true);
            }
            if (player.GetComponent<WASD>().hasSword == true && player.GetComponent<WASD>().rockPassed == true)
            {
                swordButton.SetActive(true);
            }

        }
    }

    public void StartMove() //allows player to move
    {
        player.GetComponent<WASD>().move = true;
    }

    public void DestroyTrigger() //destroys trigger, allowing player to move
    {
        Destroy(GetComponent<BoxCollider2D>());
    }
}
