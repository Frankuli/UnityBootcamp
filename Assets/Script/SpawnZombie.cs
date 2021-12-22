using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombie : MonoBehaviour
{
    public GameObject prefabZombie;
    private GameObject zombieInstanciado;

    [SerializeField] private int cantZombies = 10;
    public float maxX;
    public float minX;
    public float maxZ;
    public float minZ;

    public FuncionTiempo funcionTiempo;


    
    public void Spawn()
    {
        cantZombies *= funcionTiempo.dia;
        for (int i = 0; i < cantZombies; i++)
        {
            float randomX = Random.Range(maxX, minX);
            float randomZ = Random.Range(maxZ, minZ);
            Vector3 position = new Vector3(randomX, 10, randomZ);

            prefabZombie.transform.position = position;
            zombieInstanciado = Instantiate(prefabZombie);

        }
    }
}
