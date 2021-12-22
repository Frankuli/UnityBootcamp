using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FuncionTiempo : MonoBehaviour
{
    public float horaDia = 6;
    public float minutoDia = 0;
    public string displayMinuto = "";
    public float velocidad = 10;
    public int dia = 1;

    public TextMeshProUGUI time;
    public TextMeshProUGUI contDia;

    public GameObject panelDia;

    public SpawnZombie spawnZombie;
    public SpawnVida spawnVida;

    private void Start()
    {
        //spawnZombie = GetComponent<SpawnZombie>();
    }
    void Update()
    {
        minutoDia += Time.deltaTime * velocidad;

        if (minutoDia < 10)
            displayMinuto = "0" + (int)minutoDia;
        else
        {
            int temMin = (int)minutoDia;
            displayMinuto = temMin.ToString();
        }
        if (minutoDia  >= 59)
        {
            horaDia ++;
            minutoDia = 0;
        }

        time.text = horaDia + ":" + displayMinuto;

        if (horaDia == 7 && minutoDia == 00)
        {
            spawnZombie.Spawn();
            spawnVida.Spawn();
        }

        if (horaDia > 23)
        {
            horaDia = 0;
            dia++;
            contDia.text = "- Dia " + dia + " -";
            panelDia.GetComponent<Animator>().Play(0);
        }

    }
}
