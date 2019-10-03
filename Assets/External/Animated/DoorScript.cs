using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool silverLocked;
    public bool goldLocked;
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
        if(silverLocked == false && goldLocked == false)
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

    public void UnlockSilverDoor()
    {
        print("Door unlocked...");
        silverLocked = false;
    }

    public void UnlockGoldDoor()
    {
        goldLocked = false;
    }
}
