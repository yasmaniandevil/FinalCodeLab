using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YasContinue : MonoBehaviour
{
    public GameObject obj;
    public GameObject player;

    public void ContinueFunction()
    {
        obj.GetComponent<YasTriggerController>().DestroyTrigger();
        player.GetComponent<WASD>().move = true;
    }
}
