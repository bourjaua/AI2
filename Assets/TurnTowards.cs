using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTowards : MonoBehaviour
{
    public Transform target;
    public int turnSpeed;

    Rigidbody rb;
    // Start is called before the first frame update
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 point = transform.InverseTransformPoint(target.transform.position);
        rb.AddRelativeTorque(0, point.x * turnSpeed, 0);
    }
}
