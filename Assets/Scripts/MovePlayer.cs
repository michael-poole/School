using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class MovePlayer : MonoBehaviour
{
    public float Speed;

    private Camera Camera;

    void Start()
    {
        Camera = transform.GetComponentInChildren<Camera>();
    }

    void Update()
    {
        if (SteamVR_Input.GetAction<SteamVR_Action_Boolean>("Teleport").GetStateDown(SteamVR_Input_Sources.Any))
        {
            transform.Translate(Vector3.Scale(Camera.transform.forward, new Vector3(Speed * Time.deltaTime, 0, Speed * Time.deltaTime)));
            print("Got it");
        }
    }
}
