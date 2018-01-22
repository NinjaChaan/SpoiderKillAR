using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiveScript : MonoBehaviour
{

    public GameObject spawnPoint;
    public GameObject spider;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        var spooky = Instantiate(spider, spawnPoint.transform.position, Quaternion.identity);
        spooky.transform.parent = transform.parent;
    }
}
