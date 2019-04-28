using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int qtdEnemy;

    void Start(){
        qtdEnemy = 1;
        invocaEnemy();
    }

    void invocaEnemy(){
        //Chama a função que gera o 1 inimigo a cada 1 segundo.
        InvokeRepeating("GenerateNewEnemy", 2f, 0.2f);
    }

    void GenerateNewEnemy(){
        //Gerando inimigos em posições aleatórias
        float enemyxPosition = this.transform.position.x + Random.Range(-19, 19);
        Vector2 enemySpawner = new Vector2(enemyxPosition, this.transform.position.y - 1);
        GameObject enemy = Instantiate(enemyPrefab, enemySpawner, Quaternion.identity) as GameObject;
    }
}
