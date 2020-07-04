using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PokemonManager : MonoBehaviour
{
    public enum Tipo { FUEGO, AGUA, PLANTA, FANTASMA};

    Pokemon charmander;
    public TemplatePokemon[] misPokemon;
    private TemplatePokemon mainPokemon;
    public SpriteRenderer backImageSprite;
    private int iterador;

    public StatusPokemon statusPlayer;

    public GameObject[] contenedorPokemon;
    // Start is called before the first frame update
    void Start()
    {
        InitScreenSelection();
        iterador = 0;
        backImageSprite.sprite = misPokemon[iterador].backImage;
         
        statusPlayer.nombre.text = misPokemon[iterador].name;
        statusPlayer.nombre.text = misPokemon[iterador].name;
        statusPlayer.SetHPBar(misPokemon[iterador].vidaMax, misPokemon[iterador].vidaRestante);

        print("Largo del arreglo: " + misPokemon.Length);

        for (int i = 0; i < misPokemon.Length; i++)
        {
            print("El nombre del pokemon es: " + misPokemon[i].name);
        }

    }

    void InitScreenSelection()
    {
        for (int i = 0; i < contenedorPokemon.Length; i++)
        {
            if (i < misPokemon.Length)
            {
                contenedorPokemon[i].SetActive(true);
                contenedorPokemon[i].GetComponent<ContenedorPokemon>().imagenReferencia.sprite = misPokemon[i].frontImage;
                contenedorPokemon[i].GetComponent<ContenedorPokemon>().nombre.text = misPokemon[i].name;


            }
            else
            {
                contenedorPokemon[i].SetActive(false);

            }
        }
    }

    public void ApretandoBoton(int contenedor)
    {
        backImageSprite.sprite = contenedorPokemon[contenedor].GetComponent<ContenedorPokemon>().imagenReferencia.sprite;
        print(contenedor);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            iterador--;
            backImageSprite.sprite = misPokemon[iterador].backImage;
            statusPlayer.nombre.text = misPokemon[iterador].name;
            statusPlayer.SetHPBar(misPokemon[iterador].vidaMax, misPokemon[iterador].vidaRestante);
            print("Aprentando tecla");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            iterador++;
            backImageSprite.sprite = misPokemon[iterador].backImage;
            statusPlayer.nombre.text = misPokemon[iterador].name;
            statusPlayer.SetHPBar(misPokemon[iterador].vidaMax, misPokemon[iterador].vidaRestante);
            print("Aprentando tecla");
        }

    }


}

