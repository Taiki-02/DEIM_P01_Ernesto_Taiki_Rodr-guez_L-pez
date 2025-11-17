using UnityEngine;

public class Mapatilemovimiento : MonoBehaviour
{
    public float speed = 5f;

    public float size;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(gameObject);


        }
        else if (collision.CompareTag("Clonacion"))
        {
            Levelgeneration.AddnewPiece(transform.position - new Vector3(0,size,0));
           


        }
    }
}
