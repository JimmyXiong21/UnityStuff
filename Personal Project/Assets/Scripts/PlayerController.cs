using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]public float speed = 10;
    
    public Rigidbody rb;
    public float horizontal;
    public float vertical;
    [SerializeField] public float turnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");


        rb.transform.Rotate(Vector3.up * horizontal * turnSpeed);
        rb.AddRelativeForce(Vector3.forward * vertical * speed, ForceMode.Force);


        


    }
}
