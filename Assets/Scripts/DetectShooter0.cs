
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectShooter0 : MonoBehaviour
{
    private GameObject shooter;
    public Sprite goSprite;
    public Sprite stopSprite;
    public Sprite goSpriteReverse;
    // Start is called before the first frame update
    void Start()
    {
        shooter = GameObject.FindGameObjectWithTag("shooter");
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 direction = shooter.transform.position - transform.position;
        //Vector3 angle = Vector3.Cross(transform.forward, direction);
        //print(angle);
        var heading = shooter.transform.position - transform.position;
        float dot = Vector3.Dot(heading, -transform.right);

        Canvas[] Canvases = transform.GetComponentsInChildren<Canvas>();
        if(dot > 0) //shooter is in front of the sign
        {
            Canvases[0].transform.GetComponent<Image>().sprite = stopSprite;
            Canvases[1].transform.GetComponent<Image>().sprite = goSpriteReverse;
        }
        else //Shooter is behind the sign
        {
            Canvases[0].transform.GetComponent<Image>().sprite = goSprite;
            Canvases[1].transform.GetComponent<Image>().sprite = stopSprite;
        }
        //= goSprite;
    }
}
