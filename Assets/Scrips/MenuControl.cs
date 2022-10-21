using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuControl : MonoBehaviour
{
    public int firstlevel = 1; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Deteccion tecla para inicial
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene(firstlevel);
        }
    }
}
