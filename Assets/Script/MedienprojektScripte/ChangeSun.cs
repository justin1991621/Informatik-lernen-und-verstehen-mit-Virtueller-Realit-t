using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSun : MonoBehaviour
{
    // Script for changing the sun
    // Start is called before the first frame update
    public Material SunState1;
    public Material SunState2;
    public int time = 0;
    void Start()
    {
        //RenderSettings.skybox = SunState2; //Änder des Himmels Test
    }

    // Update is called once per frame
    void Update()
    {       

    }
}
