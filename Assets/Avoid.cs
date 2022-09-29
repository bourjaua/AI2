using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class Avoid : MonoBehaviour
{
    public Rigidbody rb;
    public Movement movement;

    public float turnSpeed;
    public float turnForce;
    
    // Start is called before the first frame update
    void Start()
    {
       // rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        CheckForObject();
    }

    void CheckForObject()
    {
        RaycastHit hitInfo;
        
        
        if (Physics.Raycast(rb.transform.localPosition, transform.forward, out hitInfo, 5f,255)) 
        { 
            Debug.DrawRay(rb.transform.localPosition, transform.forward * hitInfo.distance, Color.blue);

            if (hitInfo.distance <= 1)
            {
                //movement.speed = 10f;
                rb.AddRelativeTorque(0, turnSpeed * 2, 0);
                transform.InverseTransformVector(hitInfo.transform.position);
            }

            else if (hitInfo.distance <= 3)
            {
                //movement.speed = 50f;
                rb.AddRelativeTorque(0, turnSpeed * 1.5f, 0);
                transform.InverseTransformVector(hitInfo.transform.position);
            }

            else if (hitInfo.distance <= 4)
            {
                //movement.speed = 100f;
                rb.AddRelativeTorque(0, turnSpeed, 0);
                transform.InverseTransformVector(hitInfo.transform.position);
            }
        }
        else
        {
            Debug.DrawRay(rb.transform.localPosition, transform.forward * hitInfo.distance, Color.green); 
            movement.speed = 200f;
        }

    }
}

