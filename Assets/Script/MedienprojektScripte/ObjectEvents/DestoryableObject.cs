using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestoryableObject : MonoBehaviour
{
    // Script for object who can be destroyed
    public AudioClip DestroyWithHammer;
    public AudioClip DestroyOnCompost;
    public AudioSource Source;
    // Sound for destrpying an object
    void OnCollisionEnter (Collision col)
    {
        // If collieded object is Hammer than destory the object with the script
        if(col.gameObject.name == "HammerPrefab"
            || col.gameObject.name == "KompostCollider")
        {
            Source.PlayOneShot(DestroyWithHammer,0.3f);
            Destroy(this.gameObject);
        }

        if (col.gameObject.name == "KompostCollider")
        {
            Source.PlayOneShot(DestroyOnCompost,0.3f);
            col.gameObject.GetComponent<Compost>().addJunk();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
