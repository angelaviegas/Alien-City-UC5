using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	private Animator anim;
	private Rigidbody2D rb2d;

	public SpriteRenderer sr2d;
	public Transform posPe;
	public int tipoArma = 0;
	[HideInInspector] public bool tocaChao = false;
	[HideInInspector] public bool jump;
	//public int situacao;
	public float Velocidade;
	public float ForcaPulo = 1000f;
	[HideInInspector] public bool viradoDireita = true;

	public Image vida;

	void Start()
	{
		anim = GetComponent<Animator>();
		rb2d = GetComponent<Rigidbody2D>();
		sr2d = GetComponent<SpriteRenderer>();
	}
	// Update is called once per frame
	void Update()
	{
		tocaChao = Physics2D.Linecast(transform.position, posPe.position, 1 << LayerMask.NameToLayer("Chao"));
		if (Input.GetKeyDown("space"))
		{
			if (tocaChao)
			{
				jump = true;
			}
			if (jump)
		{
			anim.SetTrigger("pula");
			rb2d.AddForce(new Vector2(0f, ForcaPulo));
			jump = false;
		}
		}
		//Implementar Pulo Aqui! 

		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
		{
			anim.SetTrigger("corre");
			viradoDireita = true;
			transform.position += transform.right * Time.deltaTime;
			sr2d.flipX = false;
		}
		else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
		{
			anim.SetTrigger("corre");
			viradoDireita = false;
			transform.position -= transform.right * Time.deltaTime;
			sr2d.flipX = true;
		}
		else
		{
			anim.SetTrigger("parado");
		}

	}
	/*
	void FixedUpdate()
	{
		float translationY = 0;
		float translationX = Input.GetAxis("Horizontal") * Velocidade;
		transform.Translate(translationX, translationY, 0);
		transform.Rotate(0, 0, 0);
		if (translationX != 0 && tocaChao)
		{
			anim.SetTrigger("corre");
		}
		else
		{
			anim.SetTrigger("parado");
		}
		
	}
		//Programar o pulo Aqui! 
		/*
		if (translationX > 0 && !viradoDireita) 
		{
			Flip ();
		}
		else if (translationX < 0 && viradoDireita) 
		{
			Flip();
		}

	}
	void Flip()
	{
		viradoDireita = !viradoDireita;
		Vector3 escala = transform.localScale;
		escala.x *= -1;
		transform.localScale = escala;
	}
*/	
}
