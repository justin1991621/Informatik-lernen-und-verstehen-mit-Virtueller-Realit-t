using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level
{
    public class Level : MonoBehaviour
    {
        //Data class for the level
        //Saves data for an unique level

        public string LevelName = "";
        public List<GameObject> ListOfObjects = new List<GameObject>();
        public List<GameObject> ListOfFlowerBed = new List<GameObject>();
        public enum Enviornment { Grasland, Desert, Swamp }
        public double Time = 00.00;
        public Enviornment ActualEnviornment = Enviornment.Grasland;

        public string GetLevelName()
        {
            return this.LevelName;
        }

        public void SetLevelName(string LevelName)
        {
            this.LevelName = LevelName;
        }

        //Place for List add and remove

        public Enviornment GetEnviornment()
        {
            return this.ActualEnviornment;
        }

        public void SetEnviornment(Enviornment Enviornment)
        {
            this.ActualEnviornment = Enviornment;
        }

        public double GetTime()
        {
            return this.Time;
        }

        public void SetTime(double Time)
        {
            this.Time = Time;
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
}
