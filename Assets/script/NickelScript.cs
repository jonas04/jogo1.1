using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NickelScript : MonoBehaviour
{


    public GameObject MainController;


    private void Start()
    {   /*fazendo com que a classe nickel script reconheça a classe maincontroller para que cada vez que uma moeda seja tocada pelo jogador
        aumente a sua pontuação.*/
        MainController = GameObject.FindGameObjectWithTag("MainController");
    }

    void OnCollisionEnter2D(Collision2D NickelCollision)
    {

        if (NickelCollision.gameObject.name == "char")
        {
            //Adiciona um ponto
            gameObject.SetActive(false);
            //se o char colidir com a moeda é computado um ponto.
            MainController.GetComponent<MainControllerScript>().pointCount();
            //Destroy(gameObject);
        }
    }
}
