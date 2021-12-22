using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVida : MonoBehaviour
{
    public GameObject prefabPizza;
    public GameObject prefabLata1;
    public GameObject prefabLata2;
    public GameObject prefabLata3;

    private GameObject pizzaInstanciada;
    private GameObject lata1Instanciada;
    private GameObject lata2Instanciada;
    private GameObject lata3Instanciada;

    [SerializeField] private int cantVidas = 5;
    public float maxX;
    public float minX;
    public float maxZ;
    public float minZ;

    public FuncionTiempo funcionTiempo;



    public void Spawn()
    {
        cantVidas *= funcionTiempo.dia;
        for (int i = 0; i < cantVidas; i++)
        {
            float randomXL1 = Random.Range(maxX, minX);
            float randomZL1 = Random.Range(maxZ, minZ);
            Vector3 positionL1 = new Vector3(randomXL1, 1, randomZL1);

            float randomXL2 = Random.Range(maxX, minX);
            float randomZL2 = Random.Range(maxZ, minZ);
            Vector3 positionL2 = new Vector3(randomXL2, 1, randomZL2);

            float randomXL3 = Random.Range(maxX, minX);
            float randomZL3 = Random.Range(maxZ, minZ);
            Vector3 positionL3 = new Vector3(randomXL3, 1, randomZL3);

            float randomX = Random.Range(maxX, minX);
            float randomZ = Random.Range(maxZ, minZ);
            Vector3 position = new Vector3(randomX, 1.5f, randomZ);

            prefabLata1.transform.position = positionL1;
            prefabLata2.transform.position = positionL2;
            prefabLata3.transform.position = positionL3;
            prefabPizza.transform.position = position;

            lata1Instanciada = Instantiate(prefabLata1);
            lata2Instanciada = Instantiate(prefabLata2);
            lata3Instanciada = Instantiate(prefabLata3);
            pizzaInstanciada = Instantiate(prefabPizza);

        }
    }
}
