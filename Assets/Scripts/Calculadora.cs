using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculadora : MonoBehaviour
{
    public int contador;
    float soyUnDecimal;
    bool estado;

    char teclado;
    public string cadena;

    Pokemon charmander;

    // Start is called before the first frame update
    void Start()
    {
        //charmander = new Pokemon("Juanito", 10);

        //charmander.name = "Panchito";

       // print("Nombre del pokemon: " + charmander.name);

        //contador = 0;
        soyUnDecimal = 5.2f;
        estado = true;
        teclado = 'a';
        //cadena = "Calderon";

        Debug.Log(cadena);
        int adicion = Sumar(contador, 1000);
        print(adicion);
        adicion = Sumar(5, 20);
        print(adicion);
    }

    // Update is called once per frame
    void Update()
    {
    }

    int Sumar(int a, int b)
    {
        int sum = a + b;
        return sum;
    }
}
