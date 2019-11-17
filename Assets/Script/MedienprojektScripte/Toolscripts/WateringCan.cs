using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class WateringCan : MonoBehaviour
{
    public double FluidLevel = 0.0;
    public ParticleSystem WateringCanParticles;

    public void addWater(double Water)
    {
        this.FluidLevel = this.FluidLevel + Water;
    }

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<VRTK_InteractableObject>().InteractableObjectUsed += new InteractableObjectEventHandler(ObjectUsed);
        GetComponent<VRTK_InteractableObject>().InteractableObjectUnused += new InteractableObjectEventHandler(ObjectUnused);
        WateringCanParticles = GetComponentInChildren<ParticleSystem>();
        WateringCanParticles.Stop();
    }    

    // Update is called once per frame
    void Update()
    {
          
    }

    private void ObjectUsed(object sender, InteractableObjectEventArgs e)

    {
        if (FluidLevel > 0.0)
        {
            WateringCanParticles.Play();
        }
        else
        {
            //Show Tip wateringcan is empty
        }
    }

    private void ObjectUnused(object sender, InteractableObjectEventArgs e)
    {
        WateringCanParticles.Stop();
    }
}
