using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public GameObject boquilla;
    Rigidbody2D rb;
    Animator anim;
    CircleCollider2D collider;
    SpriteRenderer sprite;
    public float rotationSpeed=10;
    public float speed = 10;
    public GameObject bala;
    public GameObject ParticleMuerte;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        collider = GetComponent<CircleCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        if (vertical > 0)
        {
            rb.AddForce(transform.up * vertical * speed * Time.deltaTime);
            anim.SetBool("impulsing", true);
        }
        else
        {
            anim.SetBool("impulsing", false);
        }
        float horizontal = Input.GetAxis("Horizontal");
        transform.eulerAngles += new Vector3(0, 0, horizontal * rotationSpeed*Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
        {
           GameObject temp =Instantiate(bala, boquilla.transform.position, boquilla.transform.rotation);

            Destroy(temp, 2.5f);
        }
        
    }
    public void Muerte()
    {
        GameObject temp = Instantiate(ParticleMuerte, transform.position, transform.rotation);
        Destroy(temp, 2.5f);

        if (GameManager.instance.vidas <= 0)
        {
            Time.timeScale = 0;
            Destroy(gameObject);
            
        }
        else
        {
            StartCoroutine(Respawn_Coroutine());
        }

        
        IEnumerator Respawn_Coroutine()
        {
            collider.enabled = false;
            sprite.enabled = false;
            yield return new WaitForSeconds(2);
            collider.enabled = true;
            sprite.enabled = true; 

            GameManager.instance.vidas -= 1;
            transform.position = new Vector3(0, 0, 0);
            rb.velocity = new Vector2(0, 0);
           

        }
      
    } 
}
