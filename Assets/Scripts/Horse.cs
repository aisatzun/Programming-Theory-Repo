using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : Animals
{
   
    void Start()
    {
        addValues();
        Debug.Log("Name:" + animalName + " Speed:" + animalSpeed + " JumpForce:" + jumpForce);

        animalRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move(transform,animalSpeed);
    }

    void addValues()
    {
        animalName = "Horse";
        animalSpeed = 4f;
        jumpForce = 4f;
    }

    private void OnMouseDown()
    {
        if (isGrounded)
        {
            Jump(jumpForce);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

}
