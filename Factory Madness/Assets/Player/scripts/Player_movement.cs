using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    
    public float Speed = 5f;
    void Start()
    {
        
    }
 
    void Update()
    {
        movement();
    }

    void movement()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(1,0,0) * Time.deltaTime * Speed);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(-1,0,0) * Time.deltaTime * Speed);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(0,-1,0) * Time.deltaTime * Speed);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(0,1,0) * Time.deltaTime * Speed);
        }
    }
}
