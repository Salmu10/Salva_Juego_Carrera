﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ruta : MonoBehaviour
{
    public Transform[] ruta;

    private NavMeshAgent agent;

    private int contadorPosicion = 0;

    // Start is called before the first frame update
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance == 0)
        {
            contadorPosicion++;
            if (contadorPosicion == ruta.Length) contadorPosicion = 0;
            agent.SetDestination(ruta[contadorPosicion].position);
        }
    }

    private void OnEnable()
    {
        agent.SetDestination(ruta[contadorPosicion].position);
    }
}
