using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI tiempo;
    public TextMeshProUGUI puntuacion;

    public TextMeshProUGUI vidas;
    public GameObject gameOver;
    public GameObject youwin;
    public int Victoria = 2000;

    void Start()
    {
        
    }

    
    void Update()
    {
        tiempo.text = Time.time.ToString("00.00");
        vidas.text = GameManager.instance.vidas.ToString();
        puntuacion.text = GameManager.instance.puntuacion.ToString();
        if(GameManager.instance.vidas <= 0)
        {
            gameOver.SetActive(true);
        }
        if (GameManager.instance.puntuacion >= Victoria)
        {
            Time.timeScale = 0;
            youwin.SetActive(true);
        }
    }
}
