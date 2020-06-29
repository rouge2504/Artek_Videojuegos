using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusPokemon : MonoBehaviour
{
    public Text nombre;
    public Text nivel;

    public Image hpBar;

    public Sprite barra_Verde;
    public Sprite barra_Amarillo;
    public Sprite barra_Rojo;

    public void SetHPBar(int hpMax, int hpRestante)
    {

        float status = 0;
        status = (float)hpRestante / (float)hpMax;
        hpBar.fillAmount = status;
        if (status < 0.5f)
        {
            hpBar.sprite = barra_Amarillo;
        }
        print(status);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            hpBar.fillAmount -= 0.1f;
            if (hpBar.fillAmount < 0.5f)
            {
                hpBar.sprite = barra_Amarillo;
            }
        }
    }
    

}
