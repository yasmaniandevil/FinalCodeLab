using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    public GameObject Buttons;

    public GameObject player;



    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("enter");
        if (other.gameObject.CompareTag("Player"))
        {
            Buttons.SetActive(true);
            //if button is clicked
            //gameobject weapon unenable



            /*if (Input.GetButtonDown("Pickup"))
            {
                Debug.Log("Clicked button");
                Objects.SetActive(false);
            }*/

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
