using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosArma : MonoBehaviour
{
    public float damageRastrillo = 5;
    public float damageMartillo = 2;
    public float damageHoz = 7;
    public float damagePala = 3;
    public float damageGuitarra = 6;
    public float damageExtintor = 4;
    public float damageRegadera = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            Debug.Log("choco");
        }
    }
}
