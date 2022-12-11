using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickandDestroy : MonoBehaviour
{

    public GameObject Weapon;
    public GameObject PickUpWeapon;
    public GameObject ClimbMountain;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if it gets the input of left click mouse
        if (Input.GetMouseButtonDown(0))
        {
            PickUpWeapon.SetActive(false);
            Destroy(Weapon);
            ClimbMountain.SetActive(true);
            //Destroy(PickUpWeapon);
        }

        //if pickupweapon is destroy then enable text
        /*if(PickUpWeapon = null)
        {
            ClimbMountain.SetActive(false);

        }*/
    }
}
