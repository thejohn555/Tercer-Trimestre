using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambiodeescana : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Cambio de escana 2");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            SceneManager.LoadSceneAsync(2);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Additive);

            //Application.LoadLevelAdditive(2);
        }
    }
}
