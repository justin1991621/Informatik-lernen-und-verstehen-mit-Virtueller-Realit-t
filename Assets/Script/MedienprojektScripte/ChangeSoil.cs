using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Flowerbed
{
    public class ChangeSoil : MonoBehaviour
    {
        public Material Earth;
        public Material Sand;
        public List<Material> SoilMaterials = new List<Material>();
        public List<GameObject> ListOfFlowerBeds = new List<GameObject>();
        public int soil;

        public void changeSoil(Flowerbed.Soil Soil, int FlowerBedNumber)
        {
            soil = (int)Soil;
            Renderer Rend = ListOfFlowerBeds[FlowerBedNumber].GetComponentInChildren<Renderer>();
            Rend.sharedMaterial = SoilMaterials[soil]; 
        }

        // Start is called before the first frame update
        void Start()
        {
            SoilMaterials.Add(Earth);
            SoilMaterials.Add(Sand);
            GameObject[] Returnlist = GameObject.FindGameObjectsWithTag("Flowerbed");
            foreach (GameObject gameObject in Returnlist)
            {
                ListOfFlowerBeds.Add(gameObject);
            }
            //changeSoil(Flowerbed.Soil.Sand, 0); Test für Änderung des Bodens
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
