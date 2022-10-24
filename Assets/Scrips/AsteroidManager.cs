using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour
{
    public int asteroides_min= 1;
    public int asteroides_max = 2;
    public int asteroides;
    public GameObject asteroide;
    public float limity=6;
    public float limitx=10;
        
    void Start()
    {
        CrearAsteroides();

    }

    
    void Update()
    {
        if (asteroides <= 0)
        {
            
            CrearAsteroides();
        }
    }

    void CrearAsteroides()
    {
        int asteroides = Random.Range(asteroides_max, asteroides_min);

        for (int i = 0; i < asteroides; i++)
        {
            Vector3 posicion = new Vector3(Random.Range(-limity, limity), Random.Range(-limity, limity));
            while (Vector3.Distance(posicion, new Vector3(0, 0))<4){
                posicion = new Vector3(Random.Range(-limity, limity), Random.Range(-limity, limity));
            }
            
            Vector3 rotacion = new Vector3(0, 0, Random.Range(0f, 360f));
            GameObject temp = Instantiate(asteroide, posicion, Quaternion.Euler(rotacion));
            temp.GetComponent<AsteroideControler>().manager = this;
        }

    }
}
