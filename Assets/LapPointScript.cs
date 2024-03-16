using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapPointScript : MonoBehaviour
{
    public GameObject checkpoint1;
    public GameObject checkpoint2;
    public GameObject checkpoint3;
    public logicScript logic;
    
    private void OnTriggerEnter(Collider other)
    {
        if (!checkpoint1.activeSelf && !checkpoint2.activeSelf && !checkpoint3.activeSelf)
        {
            logic.addLap();
            checkpoint1.SetActive(true);
            checkpoint2.SetActive(true);
            checkpoint3.SetActive(true);
        }
        
    }
}
