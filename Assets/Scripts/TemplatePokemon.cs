using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Pokemon", menuName = "Pokemons/Pokemon")]

public class TemplatePokemon : ScriptableObject
{
    public string name;
    public int vidaMax;
    public int vidaRestante;
    public int nivel;
    public int ataque;
    public int defensa;
    public string[] ataques;
    public Sprite frontImage;
    public Sprite backImage;

    public PokemonManager.Tipo type;
}
