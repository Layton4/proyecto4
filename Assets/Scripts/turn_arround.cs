using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn_arround : MonoBehaviour
{
    private float speed = 40f;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
