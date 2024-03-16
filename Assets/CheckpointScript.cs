using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    public GameObject previousCheckpoint;
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!previousCheckpoint.activeSelf || previousCheckpoint.name == "LapPoint")
        {
            self.SetActive(false);
        }
    }
}
