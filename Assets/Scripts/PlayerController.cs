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

    public bool hasPowerUp = false;
    private float powerUpForce = 80f;
    private int powerUpTime = 6;

    public GameObject[] powerUpIndicators;
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

    private void OnTriggerEnter(Collider othercollider)
    {
        if(othercollider.gameObject.CompareTag("powerUp"))
        {
            hasPowerUp = true;
            Destroy(othercollider.gameObject);
            StartCoroutine(powerUpCountdown());
        }
    }
    private void OnCollisionEnter(Collision othercollider)
    {
        if(othercollider.gameObject.CompareTag("enemy") && hasPowerUp == true)
        {
            Rigidbody enemyRigidbody = othercollider.gameObject.GetComponent<Rigidbody>();
            Vector3 direction = (othercollider.gameObject.transform.position - transform.position).normalized;
            enemyRigidbody.AddForce(direction * powerUpForce, ForceMode.Impulse);
            
        }
    }
    private IEnumerator powerUpCountdown()
    {
        for (int i = 0; i <powerUpIndicators.Length; i ++)
        {
            powerUpIndicators[i].SetActive(true);
            yield return new WaitForSeconds(2);
            powerUpIndicators[i].SetActive(false);
        }
        yield return new WaitForSeconds(powerUpTime);
        Debug.Log("No te queda poder");
        hasPowerUp = false;
        
    }

}
