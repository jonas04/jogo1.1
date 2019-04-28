using UnityEngine;
using System.Collections;

public class SpawnPlatf : MonoBehaviour
{

    public int maxPlatforms = 20;
    public GameObject platform;

    private Vector3 originPosition;

    void Start(){
        //originPosition.y = originPosition.y - 1; 
        originPosition = transform.position;
        Debug.Log("Variable origin" + originPosition);
        Spawn();
    }

    void Spawn()
    {
        float y = 0;
        for (int i = 0; i < maxPlatforms; i++)
        {
            
            Vector3 randomPosition = originPosition + new Vector3(1.0f, 0.0f, 0.0f);
            Instantiate(platform, randomPosition, Quaternion.identity);
            originPosition = randomPosition;
            Debug.Log("Variable origin" + originPosition);
        }
    }

}