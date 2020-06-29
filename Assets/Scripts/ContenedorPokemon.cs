using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContenedorPokemon : MonoBehaviour
{
    public Image imagenReferencia;
    public Text nombre;
    public Text nivel;
    public Text vidaRestante;
    public Text vidaTotal;

    public Image hpBar;

    public Sprite barra_Verde;
    public Sprite barra_Amarillo;
    public Sprite barra_Rojo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ApretandoBoton(string contenedor)
    {
        print(contenedor);
    }
}
