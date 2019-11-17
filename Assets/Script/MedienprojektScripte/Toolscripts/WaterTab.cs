using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class WaterTab : MonoBehaviour
{
    public ParticleSystem WateringTabParticles;
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<VRTK_InteractableObject>().InteractableObjectUsed += new InteractableObjectEventHandler(ObjectUsed);
        GetComponent<VRTK_InteractableObject>().InteractableObjectUnused += new InteractableObjectEventHandler(ObjectUnused);
        WateringTabParticles = GetComponentInChildren<ParticleSystem>();
        WateringTabParticles.Stop();
    }

    private void ObjectUnused(object sender, InteractableObjectEventArgs e)
    {
        WateringTabParticles.Stop();
    }

    private void ObjectUsed(object sender, InteractableObjectEventArgs e)
    {
        Debug.Log("Used");
        WateringTabParticles.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
