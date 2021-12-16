using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Image barraVida;
    public float datoVida = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Vida"))
        {
            IncrementarVida();
        }
        else if (collision.gameObject.CompareTag("Enemigo"))
        {
            AtaqueEnemigo();
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

    private void Update()
    {
        barraVida.fillAmount = datoVida;
        if (datoVida < 0.4f)
        {
            barraVida.color = Color.red;
        }
        else
        {
            barraVida.color = Color.green;
        }
    }
}
