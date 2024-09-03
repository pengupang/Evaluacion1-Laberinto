using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoCamara : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        var ejeXmouse = Input.GetAxis("Mouse X");
        var  rotacion = new Vector3 (0,ejeXmouse,0);
        transform.Rotate(rotacion);
    }
}
