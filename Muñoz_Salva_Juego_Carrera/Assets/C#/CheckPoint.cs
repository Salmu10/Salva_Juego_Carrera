using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

    public GameObject checkpoint_2;

    private void OnTriggerEnter(Collider other)
    {
        checkpoint_2.SetActive(true);
    }
}
