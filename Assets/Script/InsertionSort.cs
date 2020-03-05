using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertionSort : MonoBehaviour
{

    public Container container;
    
    public void step()
    {
        int n = 10, i, j, val, flag;
        for (i = 1; i < n; i++) {
            val = container.numbersForBubbles[i];
            flag = 0;
            for (j = i - 1; j >= 0 && flag != 1; ) {
                if (val < container.numbersForBubbles[j]) {
                    container.numbersForBubbles[j + 1] = container.numbersForBubbles[j];
                    j--;
                    container.numbersForBubbles[j + 1] = val;
                }
                else flag = 1;
            }
        }
    }

    public void sort()
    {
        
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
