using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    void Start()
    {
        
    }
void OntriggerEnter(Collider other)
{
    Destroy(gameObject);
    Destroy(other.gameObject);
}
    void Update()
    {

    }
}


