using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera3pessoa : MonoBehaviour
{
    
    public Transform _transform;
    public Transform CameraTransform;
    Vector2 rotaçãoMouse;
    public int sensibilidade;

    void Update()
    {
        Vector2 ControleMouse = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        rotaçãoMouse = new Vector2(rotaçãoMouse.x + ControleMouse.x * sensibilidade * Time.deltaTime, rotaçãoMouse.y + ControleMouse.y * sensibilidade * Time.deltaTime);

        _transform.eulerAngles = new Vector3(_transform.eulerAngles.x, rotaçãoMouse.x, _transform.eulerAngles.z);
    
       rotaçãoMouse.y = Mathf.Clamp(rotaçãoMouse.y, -90, 90);

        CameraTransform.localEulerAngles = new Vector3(-rotaçãoMouse.y,
                                                       CameraTransform.localEulerAngles.y,
                                                        CameraTransform.localEulerAngles.z);

    }
}
