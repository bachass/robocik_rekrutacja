using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class logicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int laps = 0;
    public Text scoreText;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void addLap()
    {
        laps++;
        scoreText.text = laps.ToString();
    }
}
