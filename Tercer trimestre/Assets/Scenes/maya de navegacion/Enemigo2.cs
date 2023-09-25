using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]

public class Enemigo2 : MonoBehaviour
{

    public enum IAState
    {
        Idle,
        Patrol,
        Move,
        Attack,
        Return,
    }
    public IAState estadoActual = IAState.Idle;

    private NavMeshAgent navAgent;
    public GameObject refJugador;

    public float RangoVision;
    public float RangoAtaque;

    public Transform[] tablaRuta;
    public int indiceRuta;

    public float tiempoEspera;
    private float tiempoAcumulado;

    // Start is called before the first frame update
    void Start()
    {
        RangoAtaque = 2f;
        RangoVision = 10f;
        navAgent = GetComponent<NavMeshAgent>();

        tiempoEspera = 2f;
        tiempoAcumulado = 0f;
        indiceRuta = 0;
    }

    // Update is called once per frame
    void Update()
    {
        switch (estadoActual)
        {
            case IAState.Idle:

                navAgent.SetDestination(transform.position);

                tiempoAcumulado += Time.deltaTime;

                if (tiempoAcumulado > tiempoEspera)
                {
                    tiempoAcumulado = 0;
                    estadoActual = IAState.Patrol;
                }
                break;

            case IAState.Patrol:
                navAgent.SetDestination(tablaRuta[indiceRuta].position);
                if(Vector3.Distance(transform.position, tablaRuta[indiceRuta].position) < 2)
                {
                    indiceRuta++;
                    if (indiceRuta >= tablaRuta.Length)
                    {
                        indiceRuta = 0;
                    }
                }
                if (Vector3.Distance(transform.position, refJugador.transform.position) < RangoVision)
                {
                    estadoActual = IAState.Move;
                }
                break;

            case IAState.Move:
                navAgent.speed = 3;
                navAgent.SetDestination(refJugador.transform.position);

                if (Vector3.Distance(transform.position, refJugador.transform.position) < RangoAtaque)
                {
                    estadoActual = IAState.Attack;
                }
                if (Vector3.Distance(transform.position, refJugador.transform.position) > RangoVision)
                {
                    estadoActual = IAState.Return;
                }
                break;
            case IAState.Attack:
                
                Debug.Log("Atacar");

                navAgent.isStopped = true;

                if (Vector3.Distance(transform.position, refJugador.transform.position) > RangoAtaque)
                {
                    navAgent.isStopped = false;
                    estadoActual = IAState.Move;
                }
                break;
            case IAState.Return:
                navAgent.speed = 6;
                estadoActual = IAState.Idle;
                break;
        }
    }
}
