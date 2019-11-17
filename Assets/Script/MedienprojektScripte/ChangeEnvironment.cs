using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level
{
    public class ChangeEnvironment : MonoBehaviour
    {
        //Changes the environment of the actual level
        public Material Grasland;
        public Material Desert;
        public Material Swamp;
        public List<Material> LevelMaterials = new List<Material>();
        public GameObject LevelEnvironment;
        public int environment;

        public void changeEnvironment(Level.Enviornment Enviornment)
        {
            environment = (int)Enviornment;
            Renderer Rend = LevelEnvironment.GetComponent<Renderer>();
            Rend.sharedMaterial = LevelMaterials[environment];
        }
    
    // Start is called before the first frame update
        void Start()
        {
            LevelMaterials.Add(Grasland);
            LevelMaterials.Add(Desert);
            LevelMaterials.Add(Swamp);
            LevelEnvironment = GameObject.FindGameObjectWithTag("Environment");
            //changeEnvironment(Level.Enviornment.Swamp); //Test für ändern der Umgebung
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
