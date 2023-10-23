using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTargetSpawn : MonoBehaviour
{
    [SerializeField] private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        spawnTarget();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawnTarget()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-2.5f,2.5f),0,Random.Range(-2.5f,2.5f));
        Instantiate(target,spawnPos,Quaternion.identity);
    }
}
