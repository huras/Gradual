using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    [SerializeField]
    float velocidade_no_chão = 8;
    [SerializeField]
    Transform Nós, eixoX, eixoY;

    [SerializeField]
    float horizontalSpeed = 2.0f;
    [SerializeField]
    float verticalSpeed = 2.0f;

    void Update()
    {
        Andar();

        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        eixoX.Rotate(-v, 0, 0);
        eixoY.Rotate(0, h, 0);
    }

    void Andar()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 quantidadeDeMovimento = velocidade_no_chão * eixoY.forward;
            Nós.Translate(quantidadeDeMovimento);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 quantidadeDeMovimento = velocidade_no_chão * -eixoY.right;
            Nós.Translate(quantidadeDeMovimento);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 quantidadeDeMovimento = velocidade_no_chão * eixoY.right;
            Nós.Translate(quantidadeDeMovimento);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Vector3 quantidadeDeMovimento = velocidade_no_chão * -eixoY.forward;
            Nós.Translate(quantidadeDeMovimento);
        }
    }//Anda com o bicho

}
