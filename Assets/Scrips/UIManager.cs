using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI tiempo;
    public TextMeshProUGUI puntuacion;

    public TextMeshProUGUI vidas;
    public GameObject gameOver;
    public GameObject youwin;
    public int Victoria = 1000;
    public int Menulevel = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
        tiempo.text = Time.time.ToString("00.00");
        vidas.text = GameManager.instance.vidas.ToString();
        puntuacion.text = GameManager.instance.puntuacion.ToString();
        if(gameOver == null)
        {
           SceneManager.LoadScene(Menulevel);
        }
        
        else if(GameManager.instance.vidas <= 0)
        {
            gameOver.SetActive(true);
            //Time.timeScale = 0;
        }
        if (youwin == null)
        {
            SceneManager.LoadScene(Menulevel);
        }
   
        else if (GameManager.instance.puntuacion >= Victoria)
        {
           // Time.timeScale = 0;
            youwin.SetActive(true);
        }
    }
}
