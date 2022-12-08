using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animals  //Inheritance 
{


    void Start()
    {
        AddValues();
        //Debug.Log("Name:" + animalName + " Speed:" + animalSpeed + " JumpForce:" + jumpForce); //check values

        animalRB = GetComponent<Rigidbody>();
    }


    void Update()
    {
        Move(transform, animalSpeed); // Abstraction 

        DestroyAnimal(gameObject, 8); // Abstraction 

    }

    void AddValues()
    {
        animalName = "Dog";
        animalSpeed = 3f;
        jumpForce = 4f;
    }

    public override void Jump(float _force)  //Polymorphism
    {
        animalRB.AddForce(Vector3.up * _force, ForceMode.Impulse);
        isGrounded = false;
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
