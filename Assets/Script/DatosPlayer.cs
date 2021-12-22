using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DatosPlayer : MonoBehaviour
{
    public string nombrePlayer;
    public int diasPlayer = 0;
    public int zombiesPlayer = 0;

    public InputField imputNombre;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void GuardarDatos()
    {
        nombrePlayer = imputNombre.text;
        SceneManager.LoadScene(2);
    }
}
