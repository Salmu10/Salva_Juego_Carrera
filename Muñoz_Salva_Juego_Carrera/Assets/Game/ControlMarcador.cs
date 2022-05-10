using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlMarcador : MonoBehaviour
{

    public GameManager gameManager;

    public Text Marcador_vueltas;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Marcador_vueltas.text = "Laps remaining: " + gameManager.vueltas + "/3";
    }
}
