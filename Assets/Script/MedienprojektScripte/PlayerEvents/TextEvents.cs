using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using VRTK;
using System;

public class TextEvents : MonoBehaviour
{
    // The Class will create an new textmessage for the player over his left hand
    // Start is called before the first frame update

    public GameObject TextMessage;
    public int ShowDuration = 0;
    public TextMeshPro TextMeshPro;
    public Transform TextPosition;
    public GameObject LeftController;
    public bool ShowTextMessage = false;
    public int ActualDuration = 0;
    public void ShowMessage(string Message, int ShowDurationInTicks)
    {
        ShowTextMessage = true;
        ShowDuration = ShowDurationInTicks;
        LeftController = VRTK_DeviceFinder.GetControllerLeftHand();
    }

    void Start()
    {
        TimeTickSystem.OnTick += TimeTickSystem_OnTick;
        ShowMessage("Hallo Du Da", 20);
    }

    private void TimeTickSystem_OnTick(object sender, TimeTickSystem.OnTickEventArgs e)
    {
        if (ShowTextMessage == true)
        {            
            ActualDuration += 1;
        }
        if (ActualDuration >= ShowDuration)
        {
            ShowTextMessage = false;

        }
        
    }

    // Update is called once per frame
    void Update()
    {       
    }

}
