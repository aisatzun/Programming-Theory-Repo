using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    private string _AnimalName; //Encapsulation
    public string animalName
    {
        get { return _AnimalName; }
        set { _AnimalName = value; }
    }
    private float _AnimalSpeed; //Encapsulation
    public float animalSpeed
    {
        get { return _AnimalSpeed; }
        set
        {
            if (value>0f)  //animalSpeed cant negative value
            {
                _AnimalSpeed = value;
            }

        }
    }
    private float _JumpForce; //Encapsulation
    public float jumpForce
    {
        get { return _JumpForce; }
        set
        {
            if (value>0f)
            {
                _JumpForce = value;
            }
        }
    }
    public Rigidbody animalRB;
    public bool isGrounded;

    public virtual void Jump(float _force)
    {
        animalRB.AddForce(Vector3.up * _force, ForceMode.Impulse);       
    }

    protected virtual void Move(Transform _transform,float _speed)
    {
        _transform.position += new Vector3(1,0,0)*_speed*Time.deltaTime;
    }

    public void DestroyAnimal(GameObject _gameObject, float dTime)
    {
        Destroy(_gameObject,dTime);
    }
}
