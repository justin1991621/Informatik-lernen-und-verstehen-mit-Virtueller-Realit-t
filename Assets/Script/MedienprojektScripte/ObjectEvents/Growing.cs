using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
public class Growing : MonoBehaviour
{
    public GameObject Flower;
    public bool IsGrowing = false;
    public bool FlowerIsDead = false;
    public bool FlowerIsInBadCondition = false;
    public int ActualTick = 0;
    public int GrowthEffectiveness = 0;
    public int WaterLevel = 1;
    public int SunLevel = 1;
    public MeshFilter PlantMesh;
    public float NumberOfGrowthTicks;
    public Flower FlowerScript;
    public VRTK_SnapDropZone PlantZone;
    public Achievement AchievementScript;
    public MeshRenderer[] FlowerRenderers;

    private float GrowthTickNormalized;
    private bool planted;



    // Start is called before the first frame update
    void Start()
    {
        TimeTickSystem.OnTick += TimeTickSystem_OnTick;
        PlantZone = GetComponent<VRTK_SnapDropZone>();
        GetComponent<VRTK_SnapDropZone>().ObjectSnappedToDropZone += new SnapDropZoneEventHandler(FlowerPlanted);
        GetComponent<VRTK_SnapDropZone>().ObjectUnsnappedFromDropZone += new SnapDropZoneEventHandler(FlowerUnPlanted);
        AchievementScript = GameObject.FindGameObjectWithTag("AchievmentController").GetComponent<Achievement>();
    }

    private void FlowerUnPlanted(object sender, SnapDropZoneEventArgs e)
    {
        IsGrowing = false;
        this.planted = false;
        setGrowthVisual();
    }

    private void FlowerPlanted(object sender, SnapDropZoneEventArgs e)
    {
        startGrowing(PlantZone.GetCurrentSnappedObject());
        this.planted = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Function for starting the growing
    void startGrowing(GameObject Plant)
    {
        // Getting the script of the flower
        FlowerScript = Plant.GetComponent<Flower>();
        // Setting up the needed components
        NumberOfGrowthTicks = FlowerScript.NumberOfGrowthTicks;
        FlowerRenderers = Plant.GetComponentsInChildren<MeshRenderer>();
        // Deactivate all renderers
        foreach (MeshRenderer Renderer in FlowerRenderers)
        {
            Renderer.enabled = false;
        }
        // Getting the PlantMesh of the flower
        // PlantMesh = PlantZone.GetCurrentSnappedObject().GetComponentInChildren<MeshFilter>();
        // Setting the first mesh for growing
        // PlantMesh.mesh = Growthstate1;
        // Setting is growing as true
        if (FlowerIsDead != true)
        {
            IsGrowing = true;
        }
    }

    private void setGrowthVisual()
    {
        /* FlowerRenderers:
         * ErdhaufenInit
         * ErdhaufenPlant
         * SmallPlant
         * HalfPlant
         * FullPlant
         * BlumentopfErde
         */
        FlowerRenderers[1].enabled = true; // ErdhaufenInit

        // At 30% the plant get a new mesh
        if (GrowthTickNormalized >= .3f)
        {
            FlowerRenderers[1].enabled = false; // ErdhaufenInit
            FlowerRenderers[2].enabled = true; // ErdhaufenPlant
            FlowerRenderers[3].enabled = true; // SmallPlant
        }
        // At 60% the plant get a new mesh
        if (GrowthTickNormalized >= .6f)
        {
            FlowerRenderers[3].enabled = false; // SmallPlant
            FlowerRenderers[4].enabled = true; // HalfPlant
        }
        // At 100% the plant is completly grown
        if (GrowthTickNormalized >= 1f)
        {
            FlowerRenderers[4].enabled = false; // HalfPlant
            FlowerRenderers[5].enabled = true; // FullPlant
        }
        // activate flower pot soil
        if (!planted)
        {
            FlowerRenderers[1].enabled = false; // ErdhaufenInit
            FlowerRenderers[2].enabled = false; // ErdhaufenPlant
            FlowerRenderers[6].enabled = true; // BlumentopfErde
        }
    }

    private void TimeTickSystem_OnTick(object sender, TimeTickSystem.OnTickEventArgs e)
    {
        if (IsGrowing)
        {
            // Get Sunlevel and Waterlevel of the plant
            SunLevel = 1;
            WaterLevel = 1;
            if (WaterLevel == 0)
            {
                FlowerIsInBadCondition = true;
                // Hier Farbe der Pflanze ändern
            }
            // Calculate the effectiveness of sun and water
            GrowthEffectiveness = (SunLevel + WaterLevel) / 2;
            // Adding the growthtick to the effectiveness for less effectiv growing
            ActualTick += 1 * GrowthEffectiveness;
            // Noramlize of the GrowthTick
            this.GrowthTickNormalized = ActualTick * 1f / NumberOfGrowthTicks;

            setGrowthVisual();

            //Plant is fully grown
            if (ActualTick >= NumberOfGrowthTicks)
            {
                if (WaterLevel == 0)
                {
                    FlowerIsDead = true;
                    FlowerScript.FlowerIsDead = true;
                }
                else
                {
                    FlowerScript.FullyGrown = true;
                }
                if (IsGrowing == true)
                {
                    IsGrowing = false;
                    AchievementScript.AddExp(10);
                }
                IsGrowing = false;
                ActualTick = 0;

            }
        }
    }
}
