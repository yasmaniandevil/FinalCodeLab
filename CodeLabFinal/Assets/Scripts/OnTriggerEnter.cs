using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OnTriggerEnter : MonoBehaviour
{

    public GameObject Buttons;
    public GameObject Objects;

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

        } 

     

    }







}
