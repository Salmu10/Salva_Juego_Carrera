using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{
    public GameObject meta;

    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        gameManager.vueltas--;
        meta.SetActive(false);
    }
}
