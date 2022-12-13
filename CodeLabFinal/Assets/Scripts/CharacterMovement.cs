using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    Rigidbody rb;
    Vector2 movePos;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        movePos = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        movePos.x += speed * Time.deltaTime;
    }
}
