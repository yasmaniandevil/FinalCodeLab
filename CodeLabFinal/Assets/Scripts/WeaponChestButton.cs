using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WeaponChestButton : MonoBehaviour
{
    public GameObject chest;
    public GameObject player;

    public TextMeshProUGUI displayText;
    public string changeText;

    public void ChangeChest() //when button pressed, will call functions to change script of chest and player
    {
        chest.GetComponent<SpriteChanger>().SpriteChange();
        player.GetComponent<WASD>().SwordEquipped();
        ChangeText();
    }

    public void ChangeText()
    {
        displayText.text = changeText;
    }


}
