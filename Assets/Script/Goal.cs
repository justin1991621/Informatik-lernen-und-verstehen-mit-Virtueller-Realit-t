using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal
{
    //Class for an goal of the section
    //There are 2 types of goals at the moment
    //Clicking the button for the next section
    //Getting the numbers sorted right
    private string goalDescription;

    public string GoalDescription => goalDescription;

    public int GoalDefinition => goalDefinition;

    private int goalDefinition;

    
    public Goal(string GoalDescription, int GoalDefinition)
    {
        goalDescription = GoalDescription;
        goalDefinition = GoalDefinition;
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
