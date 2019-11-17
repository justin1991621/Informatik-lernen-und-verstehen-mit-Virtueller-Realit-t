using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
public class ObjectSpawner : MonoBehaviour
{
    // Script for Spawning an object from the catalogue
    public GameObject NewLevelObject;
    public VRTK_SnapDropZone SpawnZone;
    void SpawnObject(LevelObject levelObject)
    {
        Vector3 NewPosition = this.gameObject.transform.position;
        NewPosition.y = NewPosition.y + 1;
        NewLevelObject.AddComponent<Rigidbody>();
        Instantiate(NewLevelObject,NewPosition, new Quaternion(0,0,0,0));
        // Snap the object to the spawnzone
        SpawnZone.ForceSnap(NewLevelObject);
    }

    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<VRTK_InteractableObject>().InteractableObjectUsed += new InteractableObjectEventHandler(ObjectUsed);
        GetComponent<VRTK_InteractableObject>().InteractableObjectUnused += new InteractableObjectEventHandler(ObjectUnused);
    }

    private void ObjectUnused(object sender, InteractableObjectEventArgs e)
    {
    }

    private void ObjectUsed(object sender, InteractableObjectEventArgs e)
    {
        LevelObject LevelObject1 = new LevelObject();
        LevelObject1.ObjectName = "Testobject";
        LevelObject1.ObjectPrefab = NewLevelObject;
        SpawnObject(LevelObject1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
