using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_1 : MonoBehaviour
{
    GameObject target;
    float tiempoacumulado;
    Vector3 direccion;
    Quaternion rotacion;
    public float giro;
    public float rango;
    public float velocidad;
    bool atacando;
    public float Tiempoataques;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Target");
        tiempoacumulado = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Direccion de giro
        direccion = target.transform.position - transform.position;
        direccion.y = 0;
        rotacion = Quaternion.LookRotation(direccion.normalized, Vector3.up);

        //Progresion del giro

        transform.rotation = Quaternion.Lerp(transform.rotation, rotacion, giro * Time.deltaTime);
        
        //nos movemos cuando no estamos en rango de ataque

        if (Vector3.Distance(transform.position, target.transform.position) > rango)
        {
            transform.Translate(transform.forward * velocidad * Time.deltaTime, Space.World);
        }

        //Para atacar

        if(Vector3.Distance(transform.position, target.transform.position) < rango && atacando == false)
        {
            Debug.Log("Atacando");
            atacando = true;
        }
        //Tiempo de espera

        if (atacando == true)
        {
            tiempoacumulado += Time.deltaTime;

            if(tiempoacumulado>= Tiempoataques)
            {
                atacando = false;
                tiempoacumulado = 0;
            }
        }
    }
}
