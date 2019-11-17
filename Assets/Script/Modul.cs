using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Class for an learn modul
 */
public class Modul : MonoBehaviour
{
    public Container prefabContainer = null;
    //Defines all the objectes needed for the actual Lesson
    public List<Container> listOfInteractableObjects = new List<Container>();
    //Defines the actual stage of the Lesson
    public int stageOfLesson = 0;
    //Defines the names of the sections
    public List<string> listOfSections = new List<string>();
    //Hints for the actual lesson
    public List<string> listOfHints = new List<string>();
    //List of goals for each lesson
    public List<string> listOfGoals = new List<string>();
    
    void initModul()
    {
        //Inits the objects
        listOfInteractableObjects.Add(prefabContainer);
        //Init the names
        listOfSections.Add("Einführung");
        listOfSections.Add("Selber sortieren");
        listOfSections.Add("Selbst Programmieren");
        listOfSections.Add("Zeitliche Komponente");
        //Inits the hints 
        listOfHints.Add("");
        listOfHints.Add("");
        listOfHints.Add("");
        listOfHints.Add("");
        //Init the goals
        listOfGoals.Add("Read the text and click Next");
        listOfGoals.Add("Sort the Bubbles in the right order");
        listOfGoals.Add("Programm an Loop for sorting the bubbles");
        listOfGoals.Add("Read the text and click finish");
        
    }

    // Start is called before the first frame update
    void Start()
    {
        initModul();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
