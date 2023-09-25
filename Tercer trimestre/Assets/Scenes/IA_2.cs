using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_2 : MonoBehaviour
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
    GameObject punto_camino1;
    GameObject punto_camino2;
    GameObject punto_camino3;
    public GameObject[] tabla;
    public int i;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        target = tabla[i];
        //Direccion de giro
        direccion = target.transform.position - transform.position;
        direccion.y = 0;
        rotacion = Quaternion.LookRotation(direccion.normalized, Vector3.up);

        //Progresion del giro

        transform.rotation = Quaternion.Lerp(transform.rotation, rotacion, giro * Time.deltaTime);

        //Nos movemos

        transform.Translate(transform.forward * velocidad * Time.deltaTime, Space.World);

        //Cambio de ruta normal
        /*
        if (Vector3.Distance(transform.position, target.transform.position) < rango)
        {
            if (target == punto_camino3)
            {
                target = punto_camino1;
            }
            else if(target == punto_camino2)
            {
                target = punto_camino3;
            }
            else if (target == punto_camino1)
            {
                target = punto_camino2;
            }
        }
        */
        //mediante tabla(en proceso)

        if (Vector3.Distance(transform.position, target.transform.position) < rango)
        {
            Debug.Log("tu madre");
            i += 1;

            if (i >= tabla.Length)
            {
                i = 0;
            }
        }
    }
}
