using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScrip : MonoBehaviour
{

    private float velocity;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        velocity = 5;
    }

    private void Update()
    {
        transform.position += Vector3.right * velocity * Time.fixedDeltaTime;
    }

    void OnCollisionEnter2D(Collision2D enemyCollision)
    {
        /*
        if (enemyCollision.gameObject.name == "FirstWall")
        {
            spriteRenderer.flipX = true;
            transform.position += Vector3.left * velocity * Time.fixedDeltaTime;
        }*/

        if (enemyCollision.gameObject.name == "floor" || enemyCollision.gameObject.name=="char")
        {
            
            Destroy(gameObject);
        }
    }
}
