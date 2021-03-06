using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class Seguir : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private NavMeshAgent enemigo;
    [SerializeField] private Animator animator;

    private bool zombieContado = false;

    public TextMeshProUGUI contadorZombies;

    public bool isDeath = false;
    public int vida = 10;


    void Start()
    {
        player = GameObject.Find("PlayerRemy");
        enemigo = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        if (vida <= 0)
        {
            isDeath = true;
            animator.SetBool("isDeath", true);
            Destroy(gameObject, 5);
            if (!zombieContado)
            {
                player.GetComponent<Player>().IncrementarContZombie();
                zombieContado = true;
            }

        }

        if (!isDeath)
        {
            enemigo.SetDestination(player.transform.position);
            if (enemigo.remainingDistance < 0.9f)
            {
                animator.SetBool("isClose", true);
            }
            else
            {
                animator.SetBool("isClose", false);
            }

        }
    }
}
