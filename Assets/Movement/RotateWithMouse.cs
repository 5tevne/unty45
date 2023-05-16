using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithMouse : MonoBehaviour
{
    public float sensitivity = 100.0f;
    public float minY = -60.0f;
    public float maxY = 60.0f;

    private float rotationY = 0.0f;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = -Input.GetAxis("Mouse Y");

        transform.Rotate(Vector3.up, mouseX * sensitivity * Time.deltaTime, Space.World);

        rotationY += mouseY * sensitivity * Time.deltaTime;
        rotationY = Mathf.Clamp(rotationY, minY, maxY);
        transform.localEulerAngles = new Vector3(rotationY, transform.localEulerAngles.y, 0);
    }
}