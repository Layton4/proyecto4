using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    private float rotationspeed = 100f;
    private float HorizontalInput;
    private float VerticalInput;


    private Rigidbody playerRigidBody;
    private GameObject focalPoint;


    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    void Update()
    {
        float VerticalInput = Input.GetAxis("Vertical");
        float HorizontalInput = Input.GetAxis("Horizontal");
        playerRigidBody.AddForce(focalPoint.transform.forward * speed * VerticalInput);
        playerRigidBody.AddForce(focalPoint.transform.right * speed * HorizontalInput);

        /*HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");
        transform.Rotate(rotationspeed * Vector3.forward * Time.deltaTime * HorizontalInput);
        transform.Translate(speed * Vector3.right * Time.deltaTime * HorizontalInput);

        transform.Rotate(rotationspeed * Vector3.right * Time.deltaTime * VerticalInput);
        transform.Translate(speed * Vector3.forward * Time.deltaTime * VerticalInput);*/
    }
}
