using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Class for an learn modul
 */
public class Modul : MonoBehaviour
{
    public enum modulType
    {
        Bubble = 1, Insertion = 2
    }

    public modulType modul;
    
    //public Container prefabContainer = null;
    //Defines all the objectes needed for the actual Lesson
    //public List<Container> listOfInteractableObjects = new List<Container>();
    //Defines the actual stage of the Lesson
   // public int stageOfLesson = 0;
    //Defines the names of the sections
    //public List<string> listOfSections = new List<string>();
    //Hints for the actual lesson
    public List<string> listOfHints = new List<string>();
    //List of goals for each lesson
    //public List<Goal> listOfGoals = new List<Goal>();
    
    public void initModul(int modulType)
    {
        switch (modulType)
        {
            case 1:
                //Inits the hints for Bubble
                listOfHints.Add("Bubblesort is the easiest sorting " +
                                "alogrithm u simply change the neighbours");
                listOfHints.Add("Watch like the numbers get sorted by simply changing the neigbours");
                listOfHints.Add("Grab the bubbles with ur Hand and sort them");
                listOfHints.Add("Bubblesort is not the fastest sorting algorithm but it is easy to understand and implement in code");
                break;
            case 2:
                //Inits the hints for Sorting
                listOfHints.Add("Insertions is the easiest sorting " +
                                "alogrithm u simply change the neighbours");
                listOfHints.Add("Watch like the numbers get sorted by simply changing the neigbours");
                listOfHints.Add("Grab the bubbles with ur Hand and sort them");
                listOfHints.Add("Bubblesort is not the fastest sorting algorithm but it is easy to understand and implement in code");
                break;
            default:
                break;
        }
        
        
        //Inits the objects
        //listOfInteractableObjects.Add(prefabContainer);
        //Init the names
        //listOfSections.Add("Einführung");
        //listOfSections.Add("Automatisch sortieren");
        //listOfSections.Add("Selbst sortieren");
        //listOfSections.Add("Zeitliche Komponente");
        
        //Init the goals
        //listOfGoals.Add(new Goal("Read the text and grab next Next",0));
        //listOfGoals.Add(new Goal("Watch the bubbles get sorted",1));
        //listOfGoals.Add(new Goal("Sort the bubbles ge sorted from right to left ascending",1));
        //listOfGoals.Add(new Goal("Read the text and click finish",0));
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
