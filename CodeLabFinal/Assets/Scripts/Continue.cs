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
        obj.GetComponent<TriggerController>().DestroyTrigger();
        player.GetComponent<WASD>().move = true;
    }
}
