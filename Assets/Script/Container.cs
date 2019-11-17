using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using VRTK;

public class Container : MonoBehaviour
{
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
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
