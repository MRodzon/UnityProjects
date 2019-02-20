using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    GameObject player;

    private void Update()
    {
        player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            this.gameObject.transform.position = player.transform.position;
        }
        else
        {
            this.gameObject.transform.position = this.gameObject.transform.position;
        }
    }
}
