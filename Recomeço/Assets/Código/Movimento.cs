using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    float movimentoH;
    float movimentoV;
    private float velocidade = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        
        
        if (Input.GetKey(KeyCode.D))
        {
            movimentoH = 1f;
        } 
        else if (Input.GetKey(KeyCode.A))
        {
            movimentoH = -1f;
        }
        else
        {
            movimentoH = 0f;
        }
        transform.position += new Vector3(movimentoH, 0f, 0f) * velocidade * Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
        {
            movimentoV = 1f;
        } 
        else if (Input.GetKey(KeyCode.S))
        {
            movimentoV = -1f;
        }
        else
        {
            movimentoV = 0f;
        }
        
        transform.position += new Vector3(0f, movimentoV, 0f) * velocidade * Time.deltaTime;
    }
}