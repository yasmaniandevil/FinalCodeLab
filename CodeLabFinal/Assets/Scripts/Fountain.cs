using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fountain : MonoBehaviour
{
    public GameObject fountain;
    // Start is called before the first frame update
    public void ChangeFountian() //when button pressed, will call functions to change sprite of fountain
    {
        fountain.GetComponent<SpriteChanger>().SpriteChange();
    }
}
