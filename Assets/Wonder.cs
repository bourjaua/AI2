using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class Wonder : MonoBehaviour
{
    public float perlinNoise;
    Rigidbody rb;
    public int offset;
    

    public int turnForce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        perlinNoise = Mathf.PerlinNoise(Time.time, 0) * 2 - 1;

        rb.AddRelativeTorque(0,perlinNoise * turnForce,0);

    }
}
