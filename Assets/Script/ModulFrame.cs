using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using VRTK;

public class ModulFrame : MonoBehaviour
{
    //Bubblesort Module
    public Modul Bubblesort = null;
    public Modul Quicksort = null;

    public TextMeshPro hints = null;

    public TextMeshPro goal = null;

    public TextMeshPro section = null;
    
    public Container container = null;

    public VRTK_SnapDropZone nextButtonZone = null;
    public VRTK_InteractableObject nextButton = null;
    public TextMeshPro nextButtonText = null;
    public VRTK_SnapDropZone checkButtonZone = null;
    public VRTK_InteractableObject checkButton = null;
    public TextMeshPro checkButtonText = null;
    public void loadSection(Modul modul)
    {
        //Loading the section title
        section.SetText(modul.listOfSections[modul.stageOfLesson]);
        //Loading the actual Hint
        hints.SetText(modul.listOfHints[modul.stageOfLesson]);
        //Loading the Container
        modul.listOfInteractableObjects[0].initContainer();
        //Loading the goal
        goal.SetText(modul.listOfGoals[modul.stageOfLesson].GoalDescription);
    }
    public bool checkResult()
    {
        bool success = false;
        success = true;
        return success;
    }

    public void showBubbleSort()
    {
        
    }

    public void showQuickSort()
    {
        
    }

    public void switchBubbles()
    {
        
    }

    public bool checkTurn()
    {
        bool valid = false;
        return valid;
    }

    void initModule()
    {
        Bubblesort.initModul();
        loadSection();
    }
    
    void redirectToMainMenu()
    {
        
    }
    void Start()
    {
        //Muss die Intialisierung der beiden Module erarbeiten (Unity Tags für jeden Sortieralgorithmus
        nextButton.InteractableObjectUsed += new InteractableObjectEventHandler(NextButtonUsed);
        checkButton.InteractableObjectUsed += new InteractableObjectEventHandler(CheckButtonUsed);
        nextButton.InteractableObjectUnused += new InteractableObjectEventHandler(NextButtonUnused);
        checkButton.InteractableObjectUnused += new InteractableObjectEventHandler(CheckButtonUnused);
        //GetComponent<VRTK_InteractableObject>().InteractableObjectUnused += new InteractableObjectEventHandler(ObjectUnused);
        //GetComponent<VRTK_SnapDropZone>().ObjectSnappedToDropZone += new SnapDropZoneEventHandler();
        //GetComponent<VRTK_SnapDropZone>().ObjectUnsnappedFromDropZone += new SnapDropZoneEventHandler();
        initModule();
    }
    //Muss erkennen von welchen Modul gerade ein Trigger ausgeführt wurde
    private void CheckButtonUnused(object sender, InteractableObjectEventArgs e)
    {
       checkButtonZone.ForceSnap(checkButton.gameObject);
    }

    private void NextButtonUnused(object sender, InteractableObjectEventArgs e)
    {
       nextButtonZone.ForceSnap(nextButton.gameObject);
    }

    private void CheckButtonUsed(object sender, InteractableObjectEventArgs e)
    {
        checkResult();
    }

    private void NextButtonUsed(object sender, InteractableObjectEventArgs e)
    {
        this.Bubblesort.stageOfLesson = this.Bubblesort.stageOfLesson + 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
