using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json.Bson;
using TreeEditor;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;

public class Movement : MonoBehaviour
{
     Rigidbody rb;
     public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        rb.AddRelativeForce(0,0,speed);
        
    }



    public void ApplyForwardForce(float f)
    {
        rb.AddForceAtPosition(transform.forward * f, transform.position, ForceMode.Force);
        
    }


}
