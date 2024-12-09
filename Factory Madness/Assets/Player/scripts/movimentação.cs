using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentação : MonoBehaviour
{
    
    public float speed = 5f;

    [HideInInspector]
    public float InputX, InputZ;

    
    void Update()
    {
        InputX = Input.GetAxis("Horizontal");
        InputZ = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(InputX, 0, InputZ) * Time.deltaTime * speed);
    }
}
