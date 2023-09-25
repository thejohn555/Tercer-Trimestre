using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablas : MonoBehaviour
{
    public GameObject[] Objetivos;
    float distancia;
    GameObject objetivoOK;

    // Start is called before the first frame update
    void Start()
    {
        Objetivos = GameObject.FindGameObjectsWithTag("Tarjet");

        distancia = Vector3.Distance(transform.position, Objetivos[0].transform.position);

        objetivoOK = Objetivos[0];

        for (int i= 0; i < Objetivos.Length; i++)
        {
            Objetivos[i].GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < Objetivos.Length; i++)
        {
            if (Vector3.Distance(transform.position, Objetivos[i].transform.position) <= distancia)
            {
                distancia = Vector3.Distance(transform.position, Objetivos[i].transform.position);

                objetivoOK = Objetivos[i];

            }
        }
        for (int i = 0; i < Objetivos.Length; i++)
        {

            Objetivos[i].GetComponent<MeshRenderer>().material.color = Color.green;
        
        }

        objetivoOK.GetComponent<MeshRenderer>().material.color = Color.red;

        for (int i = 0; i < Objetivos.Length; i++)
        {
            distancia = Vector3.Distance(transform.position, Objetivos[0].transform.position);

            if (Vector3.Distance(transform.position, Objetivos[i].transform.position) <= distancia)
            {
                distancia = Vector3.Distance(transform.position, Objetivos[i].transform.position);

                objetivoOK = Objetivos[i];

            }

        }
    }
}
