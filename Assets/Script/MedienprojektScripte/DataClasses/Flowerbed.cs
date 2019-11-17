using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Flowerbed
{
    public class Flowerbed : MonoBehaviour
    {
        //Data class for flowerbed 
        //Saves the data for one flowerbed

        public Vector3 Position = new Vector3(0, 0, 0);
        public enum Soil { Earth, Sand }
        public List<GameObject> ListOfFlowers = new List<GameObject>();


        // Start is called before the first frame update
        void Start()
        {
            Position = gameObject.transform.position;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}