using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_camera : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 200f;
    void Start()
    {
        
    }
    void Update()
    {
        float horizontalInputMouse = Input.GetAxis("Mouse X");
        //float HorizontalInput = Input.GetAxis("Horizontal"); //para mover la cámara con las teclas
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * horizontalInputMouse);
        //transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * HorizontalInput);
    }
}
