﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            this.transform.Translate(1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            this.transform.Translate(-1, 0, 0);
        }
    }
}
