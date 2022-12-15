using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{

    //public GameObject Stone;
    public GameObject objToSpawn;
    public Transform SpawnerHolder;
    public GameObject Wall;
    // Start is called before the first frame update
    void Start()
    {
        //Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            
            Debug.Log("Clicked");
            //Destroy(Wall);

            Instantiate(objToSpawn, transform.position, transform.rotation);
        }
    }

    /*void Spawn()
    {
        Instantiate(objToSpawn, transform.position, Quaternion.identity);
    }*/
}
