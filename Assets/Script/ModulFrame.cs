using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.UNetWeaver;
using UnityEngine;
using VRTK;

public class ModulFrame : MonoBehaviour
{
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
    //todo
    /**
     * Listener für das graben der beiden Button erstellen
     * Dann die jeweiligen Funktionen ausführen
     *
     * Listener für dei Bubbles erstellen
     * vielleicht hier einfach die maximale Grabdistanz darf wert nicht überschreiten
     */
    public bool checkResult()
    {
        bool success = false;
        return success;
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
        initModule();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
