using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject AlexAI;

    public float numberToSpawn = 10;
    // Start is called before the first frame update
    void Start()
    {
        //for (int i = 0, i < numberToSpawn; i++)
        {
            Instantiate(AlexAI);
           
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
