using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoWomp : MonoBehaviour
{   
    [SerializeField] private float velocidad;
    private Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var  ejeX = Input.GetAxis("Horizontal");
        var ejeY = Input.GetAxis("Vertical");

        var vectorMovimiento = new Vector3(ejeX,0,ejeY);
        transform.Translate(vectorMovimiento * Time.deltaTime * velocidad);
        
        if(Input.GetKeyDown(KeyCode.Space)){
            var Impulso = new Vector3(0,1,0);
            rigidBody.AddForce(Impulso,ForceMode.Impulse);
        }
    }
}
