using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using VRTK;
using Random = UnityEngine.Random;
/**
 * Container class for the objects
 */
public class Container : MonoBehaviour
{
    public VRTK_SnapDropZone drop1;
    public VRTK_SnapDropZone drop2;
    public VRTK_SnapDropZone drop3;
    public VRTK_SnapDropZone drop4;
    public VRTK_SnapDropZone drop5;
    public VRTK_SnapDropZone drop6;
    public VRTK_SnapDropZone drop7;
    public VRTK_SnapDropZone drop8;

    public VRTK_SnapDropZone storageZone;

    public VRTK_InteractableObject fruit1;
    public VRTK_InteractableObject fruit2;
    public VRTK_InteractableObject fruit3;
    public VRTK_InteractableObject fruit4;
    public VRTK_InteractableObject fruit5;
    public VRTK_InteractableObject fruit6;
    public VRTK_InteractableObject fruit7;
    public VRTK_InteractableObject fruit8;

    public BubbleSort bubbleSort;

    public InsertionSort insertionSort;

    public Modul modul;

    public GameObject TitleContainer;
    public GameObject HintContainer;
    public GameObject ResultContainer;
    public GameObject NumberContainer;
    //Zones where the player can drop the bubbles
    public List<VRTK_SnapDropZone> dropZones = new List<VRTK_SnapDropZone>();

    public List<VRTK_InteractableObject> InteractableObjects
    {
        get => interactableObjects;
        set => interactableObjects = value;
    }

    public List<int> NumbersForBubbles
    {
        get => numbersForBubbles;
        set => numbersForBubbles = value;
    }

    public List<VRTK_InteractableObject> interactableObjects = new List<VRTK_InteractableObject>();
    //Number for the bubbles
    public List<int> numbersForBubbles = new List<int>();

    public int numberOfNumbers = 4;

    private bool tick;
    //Text Containers for the Bubbles
    //public List<TextMeshPro> containerTextNumbers = new List<TextMeshPro>();
    //public int numberOfSortingObjects;
    //Init for the container
    public void initContainer()
    {
        //Delete the Array
        numbersForBubbles.Clear();

        //Setting the Textcontainer to default
        TitleContainer.GetComponent<MeshRenderer>().enabled = true;
        ResultContainer.GetComponent<MeshRenderer>().enabled = false;
        HintContainer.GetComponent<MeshRenderer>().enabled = false;
        NumberContainer.GetComponent<TextMeshPro>().SetText(numberOfNumbers.ToString());
        
        //Adding the numbers to the bubbles
        for (int i = 0; i < interactableObjects.Count; i++)
        {

            if (i >= numberOfNumbers)
            {
                foreach (MeshRenderer mesh in interactableObjects[i].GetComponentsInChildren<MeshRenderer>())
                {
                    mesh.enabled = false;
                }
                dropZones[i].enabled = false;
            }
            else
            {
                dropZones[i].enabled = true;
                foreach (MeshRenderer mesh in interactableObjects[i].GetComponentsInChildren<MeshRenderer>())
                {
                    mesh.enabled = true;
                }
                float x = Random.Range(10, 20);
                numbersForBubbles.Add((int) x);
                Vector3 scale = new Vector3();
                scale.x = x/10;
                scale.y = x/10;
                scale.z = x/10;
                interactableObjects[i].GetComponent<Transform>().SetGlobalScale(scale);
            }
        }
        //Initiate the Text Components for showing the right numbers
        //int count = 0;
        //foreach (TextMeshPro textMeshPro in GetComponentsInChildren<TextMeshPro>())
        //{
         //   textMeshPro.SetText(numbersForBubbles[count].ToString());
          //  containerTextNumbers.Add(textMeshPro);
           // count++;
       //}
    }

    //Function will be called with every move the player does
    //Function will determinate if the player has done the challenge right an wins the section
    public bool rightOrder()
    {
        bool success = false;
        for (int i = 0; i < numberOfNumbers - 1; i++)
        {
            if (numbersForBubbles[i] <= numbersForBubbles[i + 1] || i == numberOfNumbers)
            {
                success = true;
            }
            else
            {
                success = false;
                return success;
            }
        }

        HintContainer.GetComponent<MeshRenderer>().enabled = false;
        ResultContainer.GetComponent<MeshRenderer>().enabled = true;

        return success;
    }
    //Function for switing the position between 2 Bubble
    //Bubble 1 will be changed with bubble 2
    public void switchPoitions(int bubble1, int bubble2)
     {
         //Unsap the first Object
         dropZones[bubble2].ForceUnsnap();
         //Snapping the first Object in the Storage Zone
         storageZone.ForceSnap(interactableObjects[bubble1].gameObject);
         //Unsnap the second object
         dropZones[bubble1].ForceUnsnap();
         //Snapping the first Object in the first zone
         dropZones[bubble1].ForceSnap(interactableObjects[bubble2].gameObject);
         //Setting the Storage Zone to Clear
         storageZone.ForceUnsnap();
         //Snapping the first object to the other zone
         dropZones[bubble2].ForceSnap(interactableObjects[bubble1].gameObject);
     }
    //Function for showing the hints
    public void showHints()
    {
        HintContainer.GetComponent<MeshRenderer>().enabled = !HintContainer.GetComponent<MeshRenderer>().enabled;
    }
    //Function for the autosorting
    public void autoSort()
    {
        switch (modul.modul)
        {
            case Modul.modulType.Bubble:
                bubbleSort.sort();
                break;
            case Modul.modulType.Insertion:
                insertionSort.sort();
                break;
        }
    }
    //Restarting of the sorting
    public void restart()
    {
        initContainer();
    }
    //Restarting with an new number
    public void restartWithNewNumber(int number)
    {
        numberOfNumbers = number;
        NumberContainer.GetComponent<TextMeshPro>().SetText(number.ToString());
        initContainer();
    }

    void Start()
    {
        dropZones.Add(drop1);
        dropZones.Add(drop2);
        dropZones.Add(drop3);
        dropZones.Add(drop4);
        dropZones.Add(drop5);
        dropZones.Add(drop6);
        dropZones.Add(drop7);
        dropZones.Add(drop8);
        
        interactableObjects.Add(fruit1);
        interactableObjects.Add(fruit2);
        interactableObjects.Add(fruit3);
        interactableObjects.Add(fruit4);
        interactableObjects.Add(fruit5);
        interactableObjects.Add(fruit6);
        interactableObjects.Add(fruit7);
        interactableObjects.Add(fruit8);
        
        initContainer();
        
        TimeTickSystem.OnTick += TimeTickSystem_OnTick;
    }

    private void TimeTickSystem_OnTick(object sender, TimeTickSystem.OnTickEventArgs e)
    {
        tick = !tick;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
