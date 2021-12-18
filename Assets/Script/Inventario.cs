using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public Player player;

    public float damageRastrillo = 5;
    public float damageMartillo = 2;
    public float damageHoz = 7;
    public float damagePala = 3;
    public float damageGuitarra = 6;
    public float damageExtintor = 4;
    public float damageRegadera = 1;

    public string armaActiva = "Puño";
    public int pos = 0;

    public List<Sprite> imagenesArmas = new List<Sprite>();
    public Image imagenArma;


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
        {
            pos++;
        }
        else
        {
            pos = 0;
        }

        armaActiva = player.inventario[pos];

        //buscar la pos del arma activa
        for (int i = 0; i < imagenesArmas.Count; i++)
        {
            if (imagenesArmas[i].name == armaActiva)
            {
                imagenArma.sprite = imagenesArmas[i];
            }
        }

        


    }
}
