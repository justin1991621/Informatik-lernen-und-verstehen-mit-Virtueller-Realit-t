using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

abstract public class Flower : MonoBehaviour
{ 
    //Text Mesh for the seed name
    public TextMeshPro textMesh;
    //Flowername
    public string Flowername;
    //Actual growth tick
    public int ActualTick = 0;
    //Number of ticks for the fully grown plant
    public int NumberOfGrowthTicks = 0;
    //Boolean if the plant ist growing
    public bool IsGrowing = false;
    //Object for the mesh
    public MeshFilter PlantMesh;

    //Meshes for the growthstates
    public Mesh GrowthState1;
    public Mesh GrowthState2;
    public Mesh GrowthState3;
    public Mesh GrowthStateMax;

    //Gameobjekt for the plants
    private GameObject PlantObject;

    //Contructor for the plants
    public Flower(Vector3 position, string Flowername, int NumberOfGrowthTicks)
    {
        this.NumberOfGrowthTicks = NumberOfGrowthTicks;
        this.Flowername = Flowername;
        PlantObject = new GameObject("Plant");
        PlantObject.AddComponent<MeshFilter>().mesh = GrowthState1;
        PlantObject.AddComponent<MeshRenderer>();
        PlantObject.transform.position = position;
        TimeTickSystem.OnTick += TimeTickSystem_OnTick;
    }

    private void TimeTickSystem_OnTick(object sender, TimeTickSystem.OnTickEventArgs e)
    {
       if (IsGrowing)
        {
            ActualTick += 1;

            float GrowthTickNormalized = ActualTick * 1f / NumberOfGrowthTicks;
            if (GrowthTickNormalized >= .3f) PlantMesh.mesh = GrowthState2;
            if (GrowthTickNormalized >= .6f) PlantMesh.mesh = GrowthState3;
            if (GrowthTickNormalized >=  1f) PlantMesh.mesh = GrowthStateMax;


            if (ActualTick >= NumberOfGrowthTicks)
            {
                //Plant is fully grown
                IsGrowing = false;
            }
        }
    }

    // Start is called before the first frame update
    public void changeSeedName()
    {
        textMesh = GetComponentInChildren<TextMeshPro>();
        textMesh.SetText(Flowername);
    }


       
    void Start()
    {
        changeSeedName();
        PlantMesh = GetComponent<MeshFilter>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
