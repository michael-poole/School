using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool isLocked;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(isLocked == false)
        {
            anim.SetTrigger("OpenDoor");
        }
    }

    void OnTriggerExit(Collider other)
    {
        anim.enabled = true;
    }

    void PauseAnimationEvent()
    {
        anim.enabled = false;
    }
}
