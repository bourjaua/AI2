using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Neighbours : MonoBehaviour
{
    private Rigidbody rb;
    public List<GameObject> neighbours = new List<GameObject>();
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    

    private void CalculateMove()
    {
        throw new NotImplementedException();
    }


    
    public void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Neighbours>() != null)
            neighbours.Add(other.gameObject);
    }
    
    public void OnTriggerExit(Collider other)
    {
        if(other.GetComponent<Neighbours>() != null)
            neighbours.Remove(other.gameObject);
    }
    
    /*
    void FixedUpdate()
    {
        // Some are Torque, some are Force
        rb.AddTorque(CalculateMove());
    }

    public override Vector3 CalculateMove(List<Transform> neighbours)
        {
            if (neighbours.Count == 0)
                return transform.forward;

            Vector3 alignmentMove = Vector3.zero;

            // Average of all neighbours directions
            foreach (Transform item in neighbours)
            {
                alignmentMove += (Vector3)item.transform.transform.forward;
            }

            alignmentMove /= neighbours.Count;

            return alignmentMove;
        }
    */
    }
