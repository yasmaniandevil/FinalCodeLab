using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbScript : MonoBehaviour
{
    public GameObject obj;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Climb()
    {
        player.transform.position = new Vector2(-35, 5); //changes location of player past the ice
        obj.GetComponent<TriggerController>().DestroyTrigger(); //destroys the trigger
        player.GetComponent<WASD>().move = true; //allows player to move again
        player.GetComponent<WASD>().rockPassed = true; //will make a button not appear
    }
}
