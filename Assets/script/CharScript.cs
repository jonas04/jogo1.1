using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public int direction;
    public int speed;
    bool grounded = true;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        direction = 1;
        speed = 5;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        JumpFunction(grounded);
        controllerDirection();
        

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.S))
        {
            
            direction = 1;
            controllerDirection();
        }
         else if(Input.GetKeyDown(KeyCode.A))
        {
            
            direction = -1;
            controllerDirection();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            //Debug.Log("conditional"); ;
            Application.LoadLevel(1);
        }
    }

    void controllerDirection()
    {

        if(direction == -1)
        {
            spriteRenderer.flipX = true;
            transform.position += Vector3.left * speed * Time.deltaTime;

        }
        else if (direction == 1)
        {
            spriteRenderer.flipX = false;
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }

    void OnCollisionEnter2D(Collision2D ObjectCollision)
    {
        // muda a direção do objeto quando ele colide com a parede direita
        if (ObjectCollision.gameObject.name == "FirstWall")
        {
            direction = -1;
            rb.AddForce(Vector3.up * 300);
            controllerDirection();
        }
        else if (ObjectCollision.gameObject.name == "LeftWall")
        {
            direction = 1;
            controllerDirection();
        }
    }

    void JumpFunction(bool ground){

        if (!ground && rb.velocity.y == 0)//rb.velocity.y == 0
        { //Press Space button to jump
            //transform.position = new Vector3(transform.position.x,
            //    Mathf.PingPong(Time.time *2, 1), transform.position.z);
            //anim.SetTrigger(jumphash);
            this.grounded = true;
            //anim.SetTrigger("Jump");
        }

        if (Input.GetKey(KeyCode.Space) && ground)
        {
            //Debug.Log("oi");
            this.grounded = false;
            rb.AddForce(Vector3.up * 300);// transform.up*jumpPower);

            //anim.SetTrigger("Jump");
        }
       // this.grounded = true;
    }
}