using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Digable : MonoBehaviour
{
    // Script for an digable object
    void OnCollisionEnter(Collision col)
    {
        // If collieded object is shovel than object gets dig up
        if (col.gameObject.name == "ShovelPrefab")
        {
            // Object gets an new position 
            Transform DigPosition;
            DigPosition = gameObject.transform;
            DigPosition.position.Set(DigPosition.position.x, DigPosition.position.y, DigPosition.position.z);
            this.transform.position = DigPosition.position;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
