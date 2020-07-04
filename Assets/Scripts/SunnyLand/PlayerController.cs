using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    public Animator animator;
    public Rigidbody2D rg;
    public float speed;
    public float jumpSpeed;

    [HideInInspector] public int cherryPoints;

    private bool inGround;

    private Vector3 scaleSave;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        scaleSave = this.gameObject.transform.localScale;
        inGround = true;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        //Derecha
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Run", true);
            this.gameObject.transform.localScale = new Vector3(scaleSave.x, scaleSave.y, scaleSave.z);
            rg.AddForce(Vector2.right * speed, ForceMode2D.Impulse);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("Run", false);
        }

        //Izquierda
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("Run", true);
            this.gameObject.transform.localScale = new Vector3(scaleSave.x * -1, scaleSave.y, scaleSave.z);
            rg.AddForce(Vector2.left * speed, ForceMode2D.Impulse);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("Run", false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && inGround)
        {
            inGround = false;
            animator.SetBool("Jump", true);
            rg.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        print(col.gameObject.name);
        if (col.gameObject.name == "Ground")
        {
            animator.SetBool("Jump", false);
            inGround = true;
        }
    }
}
