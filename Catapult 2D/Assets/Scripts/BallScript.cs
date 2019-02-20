using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour {

    TargetsScript ts;
    CatapultScript cs;
    public float ballSpeed;
    public TMPro.TextMeshProUGUI textOnLowSpeed;    

    private void Start()
    {
        cs = GetComponentInParent<CatapultScript>();
        ballSpeed = cs.startSpeed;
        if (ballSpeed < 0)
            ballSpeed = -ballSpeed;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        ts = collision.gameObject.GetComponent<TargetsScript>();
        if (ballSpeed >= ts.speedRequired)
        {
            Destroy(collision.gameObject);
        } else
        {
            Instantiate(textOnLowSpeed, gameObject.transform.GetChild(0));
        }
        
    }
}
