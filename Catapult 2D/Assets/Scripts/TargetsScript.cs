using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetsScript : MonoBehaviour {

    public int speedRequired;
    public Color speed1, speed2, speed3;

    private void Start()
    {
        SpriteRenderer rend = GetComponent<SpriteRenderer>();
        if (speedRequired == 10)
            rend.color = speed1;
        if (speedRequired == 20)
            rend.color = speed2;
        if (speedRequired == 30)
            rend.color = speed3;
    }
}
