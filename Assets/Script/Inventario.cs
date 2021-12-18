using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public Player player;


    public string armaActiva = "Puño";
    public int pos = 0;

    public List<Sprite> imagenesArmas = new List<Sprite>();
    public Image imagenArma;

    public string nombre;
    public GameObject guitarra;
    public GameObject regadera;
    public GameObject hoz;
    public GameObject matafuego;
    public GameObject martillo;
    public GameObject pala;
    public GameObject rastrillo;
    //  public GameObject puño;


    private void Start()
    {
        guitarra.SetActive(false);
        regadera.SetActive(false);
        hoz.SetActive(false);
        matafuego.SetActive(false);
        martillo.SetActive(false);
        pala.SetActive(false);
        rastrillo.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("inventario");
            SwitchArmaAtiva();
        }
    }

    public void SwitchArmaAtiva()
    {
        if (player.inventario.Count-1 > pos)
            pos++;
        else
            pos = 0;

        armaActiva = player.inventario[pos];

        //buscar la pos del arma activa
        for (int i = 0; i < imagenesArmas.Count; i++)
        {
            if (imagenesArmas[i].name == armaActiva)
            {
                nombre = imagenesArmas[i].name;
                imagenArma.sprite = imagenesArmas[i];
            }
        }

        guitarra.SetActive(false);
        regadera.SetActive(false);
        hoz.SetActive(false);
        matafuego.SetActive(false);
        martillo.SetActive(false);
        pala.SetActive(false);
        rastrillo.SetActive(false);

        switch (nombre)
        {
            case "Guitarra":
                guitarra.SetActive(true);
                break;
            case "Regadera":
                regadera.SetActive(true);
                break;
            case "Hoz":
                hoz.SetActive(true);
                break;
            case "MataFuego":
                matafuego.SetActive(true);
                break;
            case "Martillo":
                martillo.SetActive(true);
                break;
            case "Pala":
                pala.SetActive(true);
                break;
            case "Rastrillo":
                rastrillo.SetActive(true);
                break;
        }


    }
}
