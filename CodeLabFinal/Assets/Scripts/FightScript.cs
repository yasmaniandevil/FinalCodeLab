using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightScript : MonoBehaviour
{
    public GameObject obj;
    public GameObject player;
    public void Fight()
    {
        obj.SetActive(false); //destroys scorpion
        player.GetComponent<WASD>().move = true; //allows player to move
    }
}
