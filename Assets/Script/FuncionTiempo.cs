using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FuncionTiempo : MonoBehaviour
{
    public float horaDia = 6;
    public float minutoDia = 0;
    public string displayMinuto = "";
    public TextMeshProUGUI time;

    public SpawnZombie spawnZombie;

    private void Start()
    {
        //spawnZombie = GetComponent<SpawnZombie>();
    }
    void Update()
    {
        minutoDia += Time.deltaTime;

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
        }

    }
}
