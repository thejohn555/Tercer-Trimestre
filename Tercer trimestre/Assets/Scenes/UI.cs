using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    int numero;
    public GameObject texto;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        texto.GetComponent<Text>().text = numero.ToString();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            numero++;
        }
    }


    public void PulsoBoton(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
}
