using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager Referencia;

    public static GameManager dameReferencia
    {
        get
        {
            if(Referencia == null)
            {
                Referencia = GameObject.Find("GameManager").GetComponent<GameManager>();
            }
            return Referencia;
        }
    }

    public PlayerUsos player;

    public int numeroEnemigos;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.Find("Player").GetComponent<PlayerUsos>();
    }
    public void JugadorMuerto()
    {
        Debug.Log("El jugador ha muerto");
    }
    public void EnemigoMuerto()
    {
        numeroEnemigos--;

        if (numeroEnemigos <= 0)
        {
            Debug.Log("Has matado a todos los enemigos");
        }
    }
    public void NumeroEnemigos()
    {
        numeroEnemigos++;
    }
}
