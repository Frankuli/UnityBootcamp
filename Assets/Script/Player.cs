using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public int damageRastrillo = 5;
    public int damageMartillo = 2;
    public int damageHoz = 7;
    public int damagePala = 3;
    public int damageGuitarra = 6;
    public int damageExtintor = 4;
    public int damageRegadera = 1;

    public int contZ = 0;

    public Image barraVida;
    public float datoVida;
    public Animator animator;

    [SerializeField] private string nombreArma;
    public List<string> inventario = new List<string>();

    public TextMeshProUGUI contadorZombies;

    public GameObject panelMuerte;

    public GameObject funcionTiempo;

    [SerializeField] private GameObject datosPlayer;
    public TextMeshProUGUI nombre;
    public TextMeshProUGUI recordPlayer;

    private void Start()
    {
        inventario.Add("Puño");

        datosPlayer = GameObject.Find("DatosJugador");
        nombre.text = datosPlayer.GetComponent<DatosPlayer>().nombrePlayer;
    }

    private void Update()
    {
        barraVida.fillAmount = datoVida;
        Muerte();
        Colores();
        Atacar();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Vida"))
        {
            IncrementarVida( collision.gameObject.GetComponent<DatosVida>().vida, collision);
            
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
        if (Input.GetButton("Fire1"))
        {
            //atacar
            animator.SetBool("isAttacking", true);
        }

        if (Input.GetButtonUp("Fire1"))
        {
            animator.SetBool("isAttacking", false);
        }
    }

    public void IncrementarVida(float n, Collision collision)
    {
        if (datoVida < 1)
        {
            datoVida += n;
            Destroy(collision.gameObject);
        }
        else if (datoVida > 1)
        {
            datoVida = 1;
        }
    }

    public void AtaqueEnemigo()
    {
        if (datoVida > 0)
        {
            datoVida -= 0.1f;
        }

    }

    public void IncrementarContZombie()
    {
        contZ++;
        contadorZombies.text = "Zombies: " + contZ;
    }
    
    public void Muerte()
    {
        if (datoVida <= 0)
        {
            panelMuerte.SetActive(true);
           // panelMuerte.GetComponent<Animator>().Play(1);
        }
    }

    public void Reinciar()
    {
        SceneManager.LoadScene(1);
    }

    public void Guardar()
    {
        if (datosPlayer.GetComponent<DatosPlayer>().zombiesPlayer < contZ )
        {
            datosPlayer.GetComponent<DatosPlayer>().zombiesPlayer = contZ;
        }

        if (datosPlayer.GetComponent<DatosPlayer>().diasPlayer  < funcionTiempo.GetComponent<FuncionTiempo>().dia )
        {
            datosPlayer.GetComponent<DatosPlayer>().diasPlayer = funcionTiempo.GetComponent<FuncionTiempo>().dia;
        }

        recordPlayer.text = "Redord: "+ funcionTiempo.GetComponent<FuncionTiempo>().dia + " Dia(s) y "+ contZ + " Zombies";
    }
}
