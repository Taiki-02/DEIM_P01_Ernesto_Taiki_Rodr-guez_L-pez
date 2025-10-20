using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Playercontroler : MonoBehaviour
{
    public float speed = 5.5f;

    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.linearVelocityX = -speed;


        }
        else if (Input.GetKeyUp(KeyCode.A)) 
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Señal"))
        {
            Destroy(gameObject);


        }
    }


}
