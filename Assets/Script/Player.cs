using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Image barraVida;
    public float datoVida = 1;
    public Animator animator;

    [SerializeField] private string nombreArma;
    public List<string> inventario = new List<string>();

    private void Start()
    {
        inventario.Add("Puño");    
    }

    private void Update()
    {
        barraVida.fillAmount = datoVida;
        Colores();
        Atacar();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Vida"))
        {
            IncrementarVida();
        }
      
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            AtaqueEnemigo();
        }

        if (collision.gameObject.CompareTag("Arma"))
        {
            nombreArma = collision.gameObject.name;
            TomarArma(collision);
        }
    }

    public void TomarArma(Collision collision)
    {
        inventario.Add(nombreArma);
        Destroy(collision.gameObject);
    }

    public void Colores()
    {
        if (datoVida < 0.4f)
        {
            barraVida.color = Color.red;
        }
        else
        {
            barraVida.color = Color.green;
        }
    }

    public void Atacar()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //atacar
            animator.SetBool("isAttacking", true);
        }

        if (Input.GetButtonUp("Fire1"))
        {
            animator.SetBool("isAttacking", false);
        }
    }

    public void IncrementarVida()
    {
        datoVida = 1;
    }

    public void AtaqueEnemigo()
    {
        if (datoVida > 0)
        {
            datoVida -= 0.1f;
        }

    }
}
