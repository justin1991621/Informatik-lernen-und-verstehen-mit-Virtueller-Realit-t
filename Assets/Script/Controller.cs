using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VRTK;
using VRTK.Controllables;
using VRTK.Controllables.PhysicsBased;
/**
 * Controller for the container class
 */
public class Controller : MonoBehaviour
{
    public Container container = null;
    public VRTK_PhysicsSlider slider;
    public VRTK_InteractableObject showHintButton;
    public VRTK_InteractableObject autoSortButton;
    public VRTK_InteractableObject restartButton;
    public GameObject text;
    public void showHints()
    {
        container.showHints();
    }

    public void autoSort()
    {
        container.autoSort();
    }

    public void restart()
    {
        container.restart();
    }

    public void restartWithNewNumber(int number)
    {
        container.restartWithNewNumber(number);
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        showHintButton.InteractableObjectUsed += new InteractableObjectEventHandler(HintButtonUses);
        autoSortButton.InteractableObjectUsed += new InteractableObjectEventHandler(AutoSortButtonUses);
        restartButton.InteractableObjectUsed += new InteractableObjectEventHandler(RestartButtonUses);
        slider.ValueChanged += new ControllableEventHandler(ChangeSortNumber);
    }

    private void ChangeSortNumber(object sender, ControllableEventArgs e)
    {
        container.numberOfNumbers = Convert.ToInt32(slider.GetStepValue(slider.GetValue()));
    }

    private void RestartButtonUses(object sender, InteractableObjectEventArgs e)
    {
        restart();
    }

    private void AutoSortButtonUses(object sender, InteractableObjectEventArgs e)
    {
        autoSort();
    }

    private void HintButtonUses(object sender, InteractableObjectEventArgs e)
    {
        showHints();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
