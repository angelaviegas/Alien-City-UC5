using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform bocaDeCano;
    public GameObject tiroAzulPrefab;
    public GameObject tirolaranjaPrefab;
    private int tipoArma1 = 0;
        // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            Atirar();Debug.Log(tiroAzulPrefab); Debug.Log(tirolaranjaPrefab);
        }
    }
    private void Atirar()
    {
        tipoArma1++;
        switch (tipoArma1)
        {
            case 1:
                Instantiate(tiroAzulPrefab, bocaDeCano.position, bocaDeCano.rotation);
                break;
            case 2:
                Instantiate(tirolaranjaPrefab, bocaDeCano.position, bocaDeCano.rotation);
                break;
            default:
                tipoArma1 = 0;
                break;
        }
    }
}
   
