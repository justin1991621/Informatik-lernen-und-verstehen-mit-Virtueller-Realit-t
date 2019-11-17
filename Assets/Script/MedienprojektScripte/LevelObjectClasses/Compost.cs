using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compost : MonoBehaviour
{
    private float _size;
    private float _step = .05f;
    public float start = -1.45f;
    public float end = 0.0f;
    public GameObject compostObj;

    // Start is called before the first frame update
    void Start()
    {
        _size = start;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addJunk()
    {
        if (_size < end)
        {
            Debug.Log("Junk!");
            var transform = compostObj.transform;
            Vector3 newPos = new Vector3(transform.position.x, transform.position.y + _step, transform.position.z);
            transform.position = newPos;
            Debug.Log(transform.position.ToString());
            _size += _step;
        }
        
    }

    void OnCollisionEnter(Collision col)
    {
        /*
        Debug.Log("Collision compost!");
        if (col.gameObject.name.Contains("SeedBag"))
        {
            Debug.Log("Found Seedbag");
            Destroy(col.gameObject);
            addJunk();
        }
        */
    }
}
