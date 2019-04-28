using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class mainController : MonoBehaviour
{
    public Text scoreText;
    public int ponto;
    // Start is called before the first frame update
    void Start()
    {
        ponto = 5;
        scoreText.text = "Score: "+ ponto;
        //Debug.Log("Hello");
    }

    // Update is called once per frame
    void Update()
    {
        //scoreText.text = "Score: " + ponto;
       // pointCount();
    }

   

    
}
