﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        float rnd = Random.Range(0, 100);
        print(rnd);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}