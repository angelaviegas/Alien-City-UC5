using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidade = 15f;
    private Rigidbody2D rb2d;
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = transform.right * velocidade;
        DestruirTiroPorTempo();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
    private void DestruirTiroPorTempo()
    {
        Destroy(gameObject, 2f);
    }

}
