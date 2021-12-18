using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Seguir : MonoBehaviour
{
    public GameObject player;
    public NavMeshAgent enemigo;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        enemigo.SetDestination(player.transform.position);

    }
}
