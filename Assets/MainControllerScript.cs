using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MainControllerScript : MonoBehaviour
{
    public Text scoreText;
    int pontos = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + pontos;
        
    }
    public void pointCount()
    {
        pontos++;
    }
}
