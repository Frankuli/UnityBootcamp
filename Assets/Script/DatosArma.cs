using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosArma : MonoBehaviour
{
    public int damage;
    public AudioSource audio;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            audio.Play();
            Debug.Log("choco");
            collision.gameObject.GetComponent<Seguir>().vida -= damage;
        }
    }
}
