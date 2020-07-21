using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [HideInInspector] public bool watchTarget;
    [HideInInspector] public bool stayTarget;

    public Transform referencePoint;

    public GameObject cloneFireBall;

    private Animator animator;

    public float timeToDelay;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        watchTarget = false;
    }

    // Update is called once per frame
    void Update()
    {
        //print("Enemigo visto: " + watchTarget); 

        if (watchTarget && stayTarget)
        {
            StartCoroutine(Attack());
            //StartCoroutine("Attack");
            watchTarget = false;
        }

        if (stayTarget)
        {

            StartCoroutine(Delay(timeToDelay));
        }
    }


    IEnumerator Delay(float timeToDelay)
    {
        GetComponentInChildren<Collider2D>().enabled = false;
        yield return new WaitForSeconds(timeToDelay);
        print("Atacando");
        StartCoroutine(Attack());
        GetComponentInChildren<Collider2D>().enabled = true;
    }

    IEnumerator Attack()
    {
        animator.SetBool("Attack", true);
        yield return new WaitForSeconds(0.83f);

        Instantiate(cloneFireBall, referencePoint.position, referencePoint.rotation);

        animator.SetBool("Attack", false);
    }
}
