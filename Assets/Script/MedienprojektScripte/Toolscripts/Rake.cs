using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Rake : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<VRTK_InteractableObject>().InteractableObjectUsed += new InteractableObjectEventHandler(ObjectUsed);
        GetComponent<VRTK_InteractableObject>().InteractableObjectUnused += new InteractableObjectEventHandler(ObjectUnused);
    }

    private void ObjectUnused(object sender, InteractableObjectEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void ObjectUsed(object sender, InteractableObjectEventArgs e)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
