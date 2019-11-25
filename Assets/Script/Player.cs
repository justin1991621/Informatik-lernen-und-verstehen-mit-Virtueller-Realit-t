using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Name of the player
    public string nameOfPlayer = null;
    //Completed modulues for the actual player
    public List<Modul> completedModuls = new List<Modul>();
    //List of modules which are not complete
    public List<Modul> uncompletedModuls = new List<Modul>();

    public void initPlayer(string playerName, string password)
    {
        //Loading of the Modules from Database or Save File
        nameOfPlayer = playerName;
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
