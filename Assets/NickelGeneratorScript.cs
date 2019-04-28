using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NickelGeneratorScript : MonoBehaviour
{

    public GameObject nickelPrefab;
    // Start is called before the first frame update
    void Start()
    {
        createNickel();
    }

    // Update is called once per frame
    void createNickel()
    {
        
        InvokeRepeating("createNewNickel", 1.0f, 2.0f);
    }

    void createNewNickel()
    {

        float nickel_y_Position = this.transform.position.y + Random.Range(2,3);
        //Gerando inimigos em posições aleatórias
        float nickelxPosition = this.transform.position.x + Random.Range(-11, 11);
        Vector2 nickelSpawner = new Vector2(nickelxPosition, nickel_y_Position);

        GameObject nickel = Instantiate(nickelPrefab, nickelSpawner, Quaternion.identity) as GameObject;
    }

}
