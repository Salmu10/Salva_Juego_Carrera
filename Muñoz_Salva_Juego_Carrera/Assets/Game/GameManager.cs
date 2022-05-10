using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int vueltas = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (vueltas == 0)
        {
            SceneManager.LoadScene("Final");
        }
    }

    /*
    public void Restart()
    {
        SceneManager.LoadScene("Inicio");
    }
    */
}
