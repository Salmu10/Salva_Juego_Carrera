using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint_2 : MonoBehaviour
{

    public GameObject meta;

    private void OnTriggerEnter(Collider other)
    {
        meta.SetActive(true);
    }
}
