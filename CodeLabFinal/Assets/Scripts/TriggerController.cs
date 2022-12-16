using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TriggerController : MonoBehaviour
{
    public GameObject Button1;
    public GameObject Button2;
    public GameObject displayText;

    public GameObject player;




    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("enter");
        if (collision.gameObject.CompareTag("Player"))
        {
            Button1.SetActive(true);
            //if button is clicked
            //gameobject weapon unenable

            Button2.SetActive(true);

            /*if (Input.GetButtonDown("Pickup"))
            {
                Debug.Log("Clicked button");
                Objects.SetActive(false);
            }*/
            displayText.SetActive(true);

            player.GetComponent<WASD>().move = false;

        }
    }

    public void StartMove()
    {
        player.GetComponent<WASD>().move = true;
    }

    public void DestroyTrigger()
    {
        Destroy(GetComponent<BoxCollider2D>());
    }
}
