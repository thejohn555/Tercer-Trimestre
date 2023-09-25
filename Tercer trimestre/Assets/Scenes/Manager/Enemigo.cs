using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private PlayerUsos target;

    public float vidaEnemigo;
    // Start is called before the first frame update
    void Start()
    {
        target = GameManager.dameReferencia.player;
        
        Debug.Log("El enemigo: " + gameObject.name + " tienes como objetivo a: " + target);

        GameManager.dameReferencia.NumeroEnemigos();

    }
    public void DanoEnemigo()
    {
        vidaEnemigo--;
        if (vidaEnemigo < 0)
        {
            GameManager.dameReferencia.EnemigoMuerto();
        }
    }
 }
