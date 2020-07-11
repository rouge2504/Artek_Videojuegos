using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    public GameObject cinemaMachine;

    public Animator animator;
    public Rigidbody2D rg;
    public float speed;
    public float jumpSpeed;

    private int cherryPoints;
    public Text cherryText;

    public int life;
    public Text lifeText;

    public GameObject gameOverLayer;

    private bool inGround;

    private Vector3 scaleSave;

    public float timeToReseScene;
    private float timingToResetScene;
    private bool activeReset;

    private Vector3 initPos;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        gameOverLayer.SetActive(false);
        timingToResetScene = 0;
        activeReset = false;
        initPos = this.transform.position;

        scaleSave = this.gameObject.transform.localScale;
        inGround = true;

        cherryText.text = cherryPoints.ToString();

        lifeText.text = "x " + life.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        Move();

        CheckResetScene();
    }

    void CheckResetScene()
    {
        if (activeReset)
        {
            timingToResetScene += Time.deltaTime;
            print(timingToResetScene);
            if (timeToReseScene < timingToResetScene)
            {
                ResetScene();
                timingToResetScene = 0;
                activeReset = false;
            }
        }
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
            /*rg.velocity = Vector3.zero;
            rg.angularVelocity = 0;*/

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
            /*rg.velocity = Vector3.zero;
            rg.angularVelocity = 0;*/
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

    public void AddPoints()
    {
        cherryPoints++;
        cherryText.text = cherryPoints.ToString();

        if (cherryPoints == 2)
        {
            SceneManager.LoadScene("Escenario2");
        }

    }

    public void RestLife()
    {
        life--;
        lifeText.text = "x " +  life.ToString();
        animator.SetBool("Hurt", true);
        rg.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
        this.GetComponent<CircleCollider2D>().enabled = false;
        cinemaMachine.SetActive(false);
        activeReset = true;


    }

    private void ResetScene()
    {
        cinemaMachine.SetActive(true);
        this.GetComponent<CircleCollider2D>().enabled = true;
        animator.SetBool("Hurt", false);
        this.transform.position = initPos;
        rg.velocity = Vector3.zero;
        rg.angularVelocity = 0;
        if (life < 0)
        {
            gameOverLayer.SetActive(true);
        }
    }
}
