using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : Animals //Inheritance 
{

    
    void Start()
    {
        addValues();
        //Debug.Log("Name:" + animalName + " Speed:" + animalSpeed + " JumpForce:" + jumpForce); //check values

        animalRB = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        Move(transform,animalSpeed); 

        DestroyAnimal(gameObject, 10); 
    }

    void addValues()
    {
        animalName = "Cow";
        animalSpeed = 2f;
        jumpForce = 2f;
    }

    private void OnMouseDown()
    {
        if (isGrounded)
        {
            Jump(jumpForce);
            isGrounded=false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}
