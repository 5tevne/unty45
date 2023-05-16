using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f; // velocidad de movimiento

    // Update is called once per frame
    void Update()
    {
        // mover hacia adelante con la tecla w
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        // mover hacia atras con la tecla s
        if (Input.GetKey(KeyCode.W))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }

        // mover hacia la izquierda con la tecla a
        if (Input.GetKey(KeyCode.D))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }

        // mover hacia la derecha con la tecla d
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        
    }
}
