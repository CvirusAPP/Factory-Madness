using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{

    [HideInInspector]
    public Animator anim;
    public float Speed = 5f;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
 
    void Update()
    {
        movement();
    }

    void movement()

    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0,0,-1) * Time.deltaTime * Speed);
            anim.SetBool("Front", true);
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("Front", false);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0,0,1) * Time.deltaTime * Speed);
            anim.SetBool("Back", true);
        }
        if(Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("Back", false);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(1,0,0) * Time.deltaTime * Speed);
            anim.SetBool("Left", true);
        }
        if(Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("Left", false);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(-1,0,0) * Time.deltaTime * Speed);
            anim.SetBool("Right", true);
        }
        if(Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("Right", false);
        }
    }
    
}

