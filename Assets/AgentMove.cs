﻿using UnityEngine;
using UnityEngine.AI;

public class AgentMove : MonoBehaviour
{
    public Camera cam;

    public NavMeshAgent agent;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("True");
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
            else
            {
                print("Nothing hit");
            }

        }
    }
}
