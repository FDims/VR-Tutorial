using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    [SerializeField] RandomTargetSpawn plane;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        this.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        plane.spawnTarget();
    }
    private void OnTriggerExit(Collider other)
    {
        this.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
        Destroy(other.gameObject);
    }
}
