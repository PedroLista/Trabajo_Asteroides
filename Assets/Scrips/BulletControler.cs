using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControler : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 10;

    public GameObject explosion;
    public int vida_enemigo = 2;
    public int puntuacion = 500;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up*speed);

    }

    
    void Update()
    {
        
    }

  public void OnTriggerEnter2D(Collider2D collision)
  {
        if(collision.tag == "Asteroid")
        {
            collision.gameObject.GetComponent<AsteroideControler>().Muerte();
            Destroy(gameObject);
        }
        
        
  }
}
