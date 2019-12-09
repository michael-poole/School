using SWS;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterScript : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
        System.Console.WriteLine("Hello world");
        StartCoroutine(Run());
        StartCoroutine(Stop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Run()
    {
        print(Time.time);
        yield return new WaitForSecondsRealtime(2);
        print(Time.time);
        animator.SetBool("IsMoving", true);
    }
    IEnumerator Stop()
    {
        splineMove mySplineMove = FindObjectOfType<splineMove>();
        print(Time.time);
        yield return new WaitForSecondsRealtime(3);
        print(Time.time);
        animator.SetBool("IsMoving", false);
        mySplineMove.StartMove();
    }
}
