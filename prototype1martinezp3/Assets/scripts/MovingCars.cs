using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCars : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Move the vehicle forward
    void Update()
    {
       transform.Translate(Vector3.forward * Time.deltaTime * 20); 
    }
}
