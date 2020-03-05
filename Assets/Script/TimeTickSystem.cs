using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Class for the timetick system
 */
public class TimeTickSystem : MonoBehaviour
{

    public class OnTickEventArgs : EventArgs
    {
        public int Tick;
    }

    public static event EventHandler<OnTickEventArgs> OnTick;

    private const float TickMax = 1f;

    public int Tick;
    private float TickTimer; 

    // Start is called before the first frame update
    void Start()
    {
        Tick = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        TickTimer += Time.deltaTime;
        if (TickTimer >= TickMax)
        {
            TickTimer -= TickMax;
            Tick++;
            if (OnTick != null) OnTick(this, new OnTickEventArgs { Tick = Tick });
        }
    }
}
