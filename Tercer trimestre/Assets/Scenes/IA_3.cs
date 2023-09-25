using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_3 : MonoBehaviour
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
    public GameObject bala;
    public GameObject salidabala;
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
        
        rotacion = Quaternion.LookRotation(direccion.normalized, Vector3.up);

        transform.GetChild(0).rotation = Quaternion.Lerp(transform.GetChild(0).rotation, rotacion, giro * Time.deltaTime);

        direccion.y = 0;

        rotacion = Quaternion.LookRotation(direccion.normalized, Vector3.up);

        transform.rotation = Quaternion.Lerp(transform.rotation, rotacion, giro * Time.deltaTime);
        if (Vector3.Distance(transform.position, Input.mousePosition) < rango && atacando == false)
        {
            GameObject.Instantiate(bala, salidabala.transform.position, transform.GetChild(0).rotation);
            atacando = true;
        }
        if (atacando == true)
        {
            tiempoacumulado += Time.deltaTime;
            if(tiempoacumulado> Tiempoataques)
            {
                atacando = false;
                tiempoacumulado = 0;
            }
        }

    }
}
