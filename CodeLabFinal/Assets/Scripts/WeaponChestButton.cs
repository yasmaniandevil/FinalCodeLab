using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WeaponChestButton : MonoBehaviour
{
    public GameObject chest;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    public void ChangeChest() //when button pressed, will call functions to change script of chest and player
    {
        chest.GetComponent<SpriteChanger>().SpriteChange(); 
        player.GetComponent<WASD>().SwordEquipped();
    }
}
