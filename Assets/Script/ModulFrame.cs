﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ModulFrame : MonoBehaviour
{
    //Bubblesort Module
    public Modul Bubblesort = null;

    public TextMeshPro hints = null;

    public TextMeshPro goal = null;

    public Container container = null;
    public void loadSection()
    {
        //Loading the actual Hint
        hints.SetText(Bubblesort.listOfHints[Bubblesort.stageOfLesson]);
        //Loading the Container
        Bubblesort.listOfInteractableObjects[0].initContainer();
        //Loading the goal
        goal.SetText(Bubblesort.listOfGoals[Bubblesort.stageOfLesson].GoalDescription);
    }

    public bool checkResult()
    {
        bool success = false;
        return success;
    }

    void initModule()
    {
        loadSection();
    }
    
    void redirectToMainMenu()
    {
        
    }
    
    //todo-bestimmten wie der Ablauf erfolgen soll
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
