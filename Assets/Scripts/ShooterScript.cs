using SWS;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterScript : MonoBehaviour
{
    public Animator animator;

    public GameObject cam0;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;
    public GameObject cam5;
    public GameObject cam6;
    public GameObject cam7;
    public GameObject cam8;
    public GameObject cam9;
    
    public bool inHall0;
    public bool inHall1;
    public bool inHall2;
    public bool inHall3;
    public bool inCafe;
    private Rigidbody rb;

    private GameObject hall0;
    private GameObject hall1;
    private GameObject hall2;
    private GameObject hall3;
    private GameObject cafe;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.position = Vector3.zero;
        hall0 = GameObject.Find("hallway0Floor");
        hall1 = GameObject.Find("hallway1Floor");
        hall2 = GameObject.Find("hallway2Floor");
        hall3 = GameObject.Find("hallway3Floor");
        cafe = GameObject.Find("cafeFloor");

        //System.Console.WriteLine("Hello world");
        //StartCoroutine(Run());
        //StartCoroutine(Stop());

    }

    // Update is called once per frame
    void Update()
    {
        IsInBuilding();
    }

    bool IsInBuilding()
    {
        if(IsInHallway0() || IsInHallway1() || IsInHallway2() || IsInHallway3() || IsInCafe())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    bool IsInHallway0()
    {
        if(rb.position[0] <= 31 && rb.position[0] >= -33.13 && rb.position[2] <= 2.089 && rb.position[2] >= -2.891)
        {
            cam0.SetActive(true);
            cam1.SetActive(true);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(false);
            cam9.SetActive(false);
            inHall0 = true;
            return true;
        }
        else
        {
            inHall0 = false;
            return false;
        }
    }

    bool IsInHallway1()
    {
        if (rb.position[0] <= -33.691 && rb.position[0] >= -38.899 && rb.position[2] <= 2.381 && rb.position[2] >= -61.455)
        {
            cam0.SetActive(false);
            cam1.SetActive(false);
            cam2.SetActive(true);
            cam3.SetActive(true);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(false);
            cam9.SetActive(false);
            inHall1 = true;
            return true;
        }
        else
        {
            inHall1 = false;
            return false;
        }
    }

    bool IsInHallway2()
    {
        if (rb.position[0] <= 30.466 && rb.position[0] >= -33.418 && rb.position[2] <= -56.259 && rb.position[2] >= -61.433)
        {
            cam0.SetActive(false);
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(true);
            cam5.SetActive(true);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(false);
            cam9.SetActive(false); 
            inHall2 = true;
            return true;
        }
        else
        {
            inHall2 = false;
            return false;
        }
    }

    bool IsInHallway3()
    {
        if (rb.position[0] <= -39.162 && rb.position[0] >= -102.937 && rb.position[2] <= -29.6 && rb.position[2] >= -34.8)
        {

            cam0.SetActive(false);
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(true);
            cam7.SetActive(true);
            cam8.SetActive(false);
            cam9.SetActive(false); 
            inHall3 = true;
            return true;
        }
        else
        {
            inHall3 = false;
            return false;
        }
    }

    bool IsInCafe()
    {
        if (rb.position[0] <= -2.758 && rb.position[0] >= -33.441 && rb.position[2] <= -19.394 && rb.position[2] >= -45.969)
        {
            cam0.SetActive(false);
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(true);
            cam9.SetActive(true); 
            inCafe = true;
            return true;
        }
        else
        {

            inCafe = false;
            return false;
        }
    }

    //Needs fixing
    /*
    void IsRunning()
    {
        var speed = rb.velocity.magnitude;
        if(speed == 0)
        {
            animator.SetBool("IsMoving", false);
        }
        else
        {
            animator.SetBool("IsMoving", true);
        }
    }
    */

}
