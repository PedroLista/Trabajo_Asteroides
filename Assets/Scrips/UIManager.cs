using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI tiempo;
    public TextMeshProUGUI puntuacion;
    public TextMeshProUGUI vidas;
    void Start()
    {
        
    }

    
    void Update()
    {
        tiempo.text = Time.time.ToString("00.00");
        vidas.text = GameManager.instance.vidas.ToString();
        puntuacion.text = GameManager.instance.puntuacion.ToString();

    }
}
