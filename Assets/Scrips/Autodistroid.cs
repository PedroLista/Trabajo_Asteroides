using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodistroid : MonoBehaviour
{
    public float destroyTime = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
