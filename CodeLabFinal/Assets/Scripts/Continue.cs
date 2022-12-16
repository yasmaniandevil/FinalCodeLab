using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Continue : MonoBehaviour
{
    public GameObject obj;
    public GameObject player;

    public void ContinueFunction()
    {
        obj.GetComponent<TriggerController>().DestroyTrigger(); //gets function from trigger controller script
        player.GetComponent<WASD>().move = true; //gets variable from WASD script
        player.GetComponent<WASD>().chestInteracted = true; //gets variable from WASD script
    }
}
