using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon
{
    private string _name;
    public int ataque;
    public int defensa;
    public int vida;
    public int velocidad;
    public int evasion;
    public bool shiny;

    public PokemonManager.Tipo type;

    public Pokemon(string nombre, int ataque, PokemonManager.Tipo tipo)
    {
        _name = nombre;
        this.ataque = ataque;
        type = tipo;
    }

    public string name
    {
        get
        {
            return _name;
        }

        set
        {
            _name = value;
        }
    }
}
