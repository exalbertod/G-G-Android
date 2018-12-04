using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class Movement : MonoBehaviour {

    Rigidbody2D rb;
    float dirX;
    float dirY;

    [SerializeField]
    float moveSpeed = 8f, jumpForce = 600f, bulletSpeed = 700f, moveSpid = 0.03f;

    bool facingRight = true;
    Vector3 localScale;

    public Transform barrel;
    public Rigidbody2D bullet;

    public Animator anim;

    //SCORE
    public static int contador;
    public Text puntos;

    public float fireRate = 1.5f;
    private float nextFireTime = 0.0f;

    // Use this for initialization
    void Start () {

        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
       

	}
	
	// Update is called once per frame
	void Update () {

        if (CrossPlatformInputManager.GetAxis("Horizontal") != 0)
        {
            //Play your sideways animation
            anim.SetBool("Walk", true);
        }
        //If the player is moving vertically (forward and backward) or diagonally
        else
        {
            //Play your forward/backward animation
            anim.SetBool("Walk", false);
        }



        dirX = CrossPlatformInputManager.GetAxis("Horizontal");
        dirY = CrossPlatformInputManager.GetAxis("Vertical");

        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            anim.SetBool("Jump", true);
          
          //  anim.SetBool("Walk", false);
            Jump();
        }
        else
        {
            anim.SetBool("Jump", false);
         
        }

        if (CrossPlatformInputManager.GetButtonDown("Fire1") && Time.time > nextFireTime)
        {
            anim.SetBool("Attack", true);
            nextFireTime = Time.time + fireRate;
            Fire();
        }
    
        else
        {
            anim.SetBool("Attack", false);
            
        }

        if (Input.GetAxis("Horizontal") < 0)

        {
            transform.Translate(Vector2.left * moveSpid, Space.World);
            transform.eulerAngles = new Vector3(0, 180, 0);
            anim.SetBool("Walk", true);
        }
        if (Input.GetAxis("Horizontal") > 0)

        {
            transform.Translate(Vector2.right * moveSpid, Space.World);
            transform.eulerAngles = new Vector3(0, 0, 0);
            anim.SetBool("Walk", true);
        }
        if (Input.GetButtonDown("Jump"))
        {
            anim.SetBool("Jump", true);
            Jump();
        }
        if (Input.GetButtonDown("Fire1") && Time.time > nextFireTime)
        {
            anim.SetBool("Attack", true);
            nextFireTime = Time.time + fireRate;
            Fire();
        }

    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
    }

    void LateUpdate()
    {
        CheckWhereToFace();
    }

    void CheckWhereToFace()
    {
        if (dirX > 0)
            facingRight = true;
        else
            if (dirX < 0)
            facingRight = false;
        if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
            localScale.x *= -1;
        transform.localScale = localScale;
    }

    void Jump()
    {
        if (rb.velocity.y == 0)
            rb.AddForce(Vector2.up * jumpForce);
    }

    void Fire()
    {
        Rigidbody2D firedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
        if (facingRight == true)
        {
            firedBullet.AddForce(barrel.right * bulletSpeed);
        }
        else
        {
            firedBullet.AddForce(-barrel.right * bulletSpeed);
        }
    }


    //SCORE
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Score")
        {
            Destroy(other.gameObject);
            contador = contador + 100;
            puntos.text = "SCORE: " + contador;

        }

        if (other.gameObject.tag == "Enemy")
        {
            lives.vida = lives.vida ;
        }
    }

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        contador = 0;
        puntos.text = "SCORE: " + contador;
    }

  

}
