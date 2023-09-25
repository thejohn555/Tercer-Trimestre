using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cORRUTINAS : MonoBehaviour
{
    public bool usandocorrutina;
    public GameObject tarhet;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.red;

        if (usandocorrutina == true)
        {
            StartCoroutine("Rango");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (usandocorrutina == false)
        {
            if (Vector3.Distance(transform.position, tarhet.transform.position) < 5)
            {

                gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            }
            else
            {
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            }
        }
        if (Input.GetKey(KeyCode.Space))
        {
            StopCoroutine("Rango");
        }
    }
    IEnumerator Rango()
    {
        while (true)
        {
            if(Vector3.Distance(transform.position, tarhet.transform.position) < 5)
            {

                gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            }
            else
            {
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            }
            yield return new WaitForSeconds(0.1f);
        }
      
    }
    

    
}
