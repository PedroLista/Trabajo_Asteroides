using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroideControler : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed_min;
    public float speed_max;
    public AsteroidManager manager;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 direcction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
       direcction = direcction * Random.Range(speed_max, speed_min);
        Debug.Log(direcction);
        rb.AddForce(direcction);
        manager.asteroides += 1;
        
    }

    
     void Update()
     {

     }

     public void Muerte()
     {
         if (transform.localScale.x >= 0.75f)
         { 
             GameObject temp1 = Instantiate(manager.asteroide, transform.position, transform.rotation);
             temp1.GetComponent<AsteroideControler>().manager = manager;
             temp1.transform.localScale = transform.localScale * 0.5f;

             GameObject temp2 = Instantiate(manager.asteroide, transform.position, transform.rotation);
             temp2.GetComponent<AsteroideControler>().manager = manager;
             temp2.transform.localScale = transform.localScale * 0.5f;

         }
         GameManager.instance.puntuacion += 100;
         manager.asteroides -= 1;
         Destroy(gameObject);
     }
     public void OnTriggerEnter2D(Collider2D collision)
     {
         if (collision.tag == "Player")
         {
             collision.gameObject.GetComponent<PlayerMovement>().Muerte();

         }
     }
}
