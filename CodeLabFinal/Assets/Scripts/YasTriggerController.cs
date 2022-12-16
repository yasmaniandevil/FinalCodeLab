using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YasTriggerController : MonoBehaviour
{

    public GameObject Button1;
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
