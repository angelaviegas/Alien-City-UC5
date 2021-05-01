using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    // Start is called before the first frame update
        public Transform bocaDeCano;
        public GameObject tiroPrefab;
  

    // Update is called once per frame
    private void Update () 
    {
        if (Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            Atirar();
        }
        
    }
    private void Atirar() 
    { 
        Instantiate (tiroPrefab,bocaDeCano.position,bocaDeCano.rotation);
    }
}
