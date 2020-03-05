using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using VRTK.UnityEventHelper;
/**
 * modul for Bubblesort
 */
public class BubbleSort : MonoBehaviour
{
    private int i = 0;
    private int j = 0;
    //Order of the array
    private bool order = false;
    //Boolean for the tick
    private bool tick;
    public Container container;
    //Step for the bubblesort
    public void step()
    {
        Debug.Log("Step");
        Debug.Log(i);
        Debug.Log(j);
        if (i == container.numberOfNumbers - 1)
        {
            order = container.rightOrder();
            i = 0;
        }
        j++;
        stepInner();
    }
    //Step for the inner loop
    public void stepInner()
    {
        int temp;
        if (container.numbersForBubbles[i] > container.numbersForBubbles[i + 1])
        {
            temp = container.numbersForBubbles[i + 1];
            container.numbersForBubbles[i + 1] = container.numbersForBubbles[i];
            container.numbersForBubbles[i] = temp;
            container.switchPoitions(i, i + 1);
        }
        i++;
    }
    //Sort function for bubblesort
    public void sort()
    {
        step();
    }
    //Function for an valid sort
    public void validSort()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        TimeTickSystem.OnTick += TimeTickSystem_OnTick; 
    }

    private void GrabObject(object sender, ObjectInteractEventArgs e)
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void TimeTickSystem_OnTick(object sender, TimeTickSystem.OnTickEventArgs e)
    {
        tick = !tick;
    }
    
    
}
