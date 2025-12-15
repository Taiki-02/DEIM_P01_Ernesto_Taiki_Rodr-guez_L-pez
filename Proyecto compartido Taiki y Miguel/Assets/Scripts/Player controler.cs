using NUnit.Framework;
using System;
using System.Drawing;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Playercontroler : MonoBehaviour
{
    public float speed = 5.5f;

    private Rigidbody2D rb;

    private bool salto;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        screenbordermovement();
        //Fingermovement();

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.linearVelocityX = -speed;


        }
        else if (Input.GetKeyUp(KeyCode.A))
        {


            rb.linearVelocityX = 0;

        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.linearVelocityX = speed;


        }
        else if (Input.GetKeyUp(KeyCode.D))
        {


            rb.linearVelocityX = 0; 

        }
        ////Codigo de moviviemto Izquierda
        //if (Input.GetKey(KeyCode.A))
        //{

        //    //transform.Translate(-speed * Time.deltaTime, 0, 0);
        //    rb.linearVelocityX = -speed;



        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Moneda"))
        {
            Destroy(collision.gameObject);

            print("+10 puntos");

        }

        if (collision.gameObject.CompareTag("PlataformaSalto"))
        {

            salto = true;
            
            


        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Señal"))
        {
            Destroy(gameObject);


        }

        if (collision.gameObject.CompareTag("PlataformaSalto"))
        {
            



        }

    }

    private void Fingermovement()
    {

        //Comprueba si toca la pantalla
        if (Input.touchCount > 0)
        {
            float fingerMovementX = Input.touches[0].deltaPosition.x;

            rb.linearVelocityX = fingerMovementX * speed;
        }
        else
        {


            rb.linearVelocityX = 0;



        }





    }





    private void screenbordermovement()
    {
        //Comprueba si toca la pantalla
        if (Input.touchCount > 0)
        {
            float touchscreenPositionX = Input.touches[0].position.x;
            float screenCenter = Screen.width / 2;

            if (touchscreenPositionX > screenCenter)
            {

                rb.linearVelocityX = speed;



            }
            else
            {


                rb.linearVelocityX = -speed;



            }

        }
        else
        {


            rb.linearVelocityX = 0;



        }

    }
}
