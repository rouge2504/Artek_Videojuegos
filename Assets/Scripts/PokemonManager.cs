using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PokemonManager : MonoBehaviour
{
    public enum Tipo { FUEGO, AGUA, PLANTA, FANTASMA};

    Pokemon charmander;
    public TemplatePokemon[] misPokemon;
    public SpriteRenderer backImageSprite;
    private int iterador;

    public StatusPokemon statusPlayer;
    // Start is called before the first frame update
    void Start()
    {
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

