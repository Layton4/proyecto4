using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador_extra : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    private float rotationspeed = 100f;
    private float HorizontalInput;
    private float VerticalInput;


    private Rigidbody playerRigidBody;
    private GameObject Focal;


    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
        Focal = GameObject.Find("Focal");
    }

    void Update()
    {
        float VerticalInput = Input.GetAxis("Vertical");
        float HorizontalInput = Input.GetAxis("Horizontal");
        playerRigidBody.AddForce(transform.forward * speed * VerticalInput);
        playerRigidBody.AddForce(transform.right * speed * HorizontalInput);
    }
}
