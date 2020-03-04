using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using VRTK;
/**
 * Old Frame class
 */
public class ModulFrame : MonoBehaviour
{
    /*
    //Bubblesort Module
    public Modul Bubblesort = null;

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
    public void loadSection()
    {
        //Loading the section title
        section.SetText(Bubblesort.listOfSections[Bubblesort.stageOfLesson]);
        //Loading the actual Hint
        hints.SetText(Bubblesort.listOfHints[Bubblesort.stageOfLesson]);
        //Loading the Container
        Bubblesort.listOfInteractableObjects[0].initContainer();
        //Loading the goal
        goal.SetText(Bubblesort.listOfGoals[Bubblesort.stageOfLesson].GoalDescription);
    }
     * Listener für das graben der beiden Button erstellen
     * Dann die jeweiligen Funktionen ausführen
     *
     * Listener für dei Bubbles erstellen
     * vielleicht hier einfach die maximale Grabdistanz darf wert nicht überschreiten
     
    public void checkResult()
    {
        bool success = false;
        success = true;
        if (success == true)
        {
            this.Bubblesort.stageOfLesson = this.Bubblesort.stageOfLesson + 1;
        }
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
        nextButton.InteractableObjectUsed += new InteractableObjectEventHandler(NextButtonUsed);
        checkButton.InteractableObjectUsed += new InteractableObjectEventHandler(CheckButtonUsed);
        nextButton.InteractableObjectUnused += new InteractableObjectEventHandler(NextButtonUnused);
        checkButton.InteractableObjectUnused += new InteractableObjectEventHandler(CheckButtonUnused);
        //GetComponent<VRTK_InteractableObject>().InteractableObjectUnused += new InteractableObjectEventHandler(ObjectUnused);
        //GetComponent<VRTK_SnapDropZone>().ObjectSnappedToDropZone += new SnapDropZoneEventHandler();
        //GetComponent<VRTK_SnapDropZone>().ObjectUnsnappedFromDropZone += new SnapDropZoneEventHandler();
        initModule();
    }

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
    */
}
