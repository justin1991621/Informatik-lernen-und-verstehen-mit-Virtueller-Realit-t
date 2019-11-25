using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using VRTK;
using Random = UnityEngine.Random;

public class Container : MonoBehaviour
{
    public VRTK_SnapDropZone bubble1;
    public VRTK_SnapDropZone bubble2;
    public VRTK_SnapDropZone bubble3;
    public VRTK_SnapDropZone bubble4;
    //Zones where the player can drop the bubbles
    public List<VRTK_SnapDropZone> dropZones = new List<VRTK_SnapDropZone>();
    //Number for the bubbles
    public List<int> numbersForBubbles = new List<int>();
    //Text Containers for the Bubbles
    public List<TextMeshPro> containerTextNumbers = new List<TextMeshPro>();

    public void initContainer()
    {
        //Adding the numbers to the bubbles
        for (int i = 0; i < 5; i++)
        {
            int x = Random.Range(1, 10);
            numbersForBubbles.Add(x);   
        }

        //Initiate the Text Components for showing the right numbers
        int count = 0;
        foreach (TextMeshPro textMeshPro in GetComponents<TextMeshPro>())
        {
            textMeshPro.SetText(numbersForBubbles[count].ToString());
            containerTextNumbers.Add(textMeshPro);
            count++;
        }
        dropZones.Add(bubble1);
        dropZones.Add(bubble2);
        dropZones.Add(bubble3);
        dropZones.Add(bubble4);
    }
    
    //Function for getting new NUmbers
    public void shuffleNumbers()
    {
        for (int i = 0; i < 5; i++)
        {
            int x = Random.Range(1, 10);
            numbersForBubbles[i] = x;
        }
    }

    //Function will be called with every move the player does
    //Function will determinate if the player has done the challenge right an wins the section
    public bool rightOrder()
    {
        bool success = false;
        for (int i = numbersForBubbles.Count; i < numbersForBubbles.Count + 1 ; i++)
        {
            if (numbersForBubbles[i] < numbersForBubbles[i + 1] || i == numbersForBubbles.Count)
            {
                success = true;
            }
            else
            {
                success = false;
            }
        }
        return success;
    }
    
    //Function for switing the position between 2 Bubble
    //Bubble 1 will be changed with bubble 2
    public void switchPoitions(int bubble1, int bubble2)
     {
        GameObject bubble1Object = dropZones[bubble1].GetCurrentSnappedObject();
        GameObject bubble2Object = dropZones[bubble2].GetCurrentSnappedObject();
        dropZones[bubble2].ForceSnap(bubble1Object);
        dropZones[bubble1].ForceSnap(bubble2Object);

        int number1 = numbersForBubbles[bubble1];
        int number2 = numbersForBubbles[bubble2];

        numbersForBubbles[bubble1] = number2;
        numbersForBubbles[bubble2] = number1;
     }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
