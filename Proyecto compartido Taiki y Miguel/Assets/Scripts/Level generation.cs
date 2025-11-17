using UnityEngine;
using System.Collections.Generic;

public class Levelgeneration : MonoBehaviour
{
    private static Levelgeneration instance;
    public List<GameObject> piece;

    private void Awake()
    {
        instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void AddnewPiece(Vector3 spawposition)
    {

        Instantiate(instance.piece[Random.Range(0,instance.piece.Count)], spawposition, Quaternion.identity);


    }
}
