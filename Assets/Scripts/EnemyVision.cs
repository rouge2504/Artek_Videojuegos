using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVision: MonoBehaviour
{
    //public Collider2D collider;
    // Start is called before the first frame update

    EnemyController controller;
    void Start()
    {
        controller = GetComponentInParent<EnemyController>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            controller.watchTarget = true;
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            controller.stayTarget = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            controller.watchTarget = false;
            controller.stayTarget = false;
        }
    }


}
