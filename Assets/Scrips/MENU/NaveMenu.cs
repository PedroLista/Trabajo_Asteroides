using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMenu : MonoBehaviour
{
   
    private bool rightDir;
    public float speed;

    void Start()
    {
        rightDir = true;
    }

    void Update()
    {
        transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        if (rightDir == true)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            if (transform.position.x > 9)
            {
                transform.position = new Vector2(-9, Random.Range(-4f, 4f));
            }
        }
        else
        {
            transform.localScale = new Vector3(-1.5f, 1.5f, 1.5f);
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (transform.position.x < -9)
            {
                transform.position = new Vector2(9, Random.Range(-4f, 4f));
            }

        }

    }
    private void OnMouseDown()
    {
        rightDir = !rightDir;
    }
}

