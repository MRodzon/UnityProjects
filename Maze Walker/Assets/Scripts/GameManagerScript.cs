using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {

    public GameObject player, startingZone;

	void Awake () {
        Instantiate(player, startingZone.transform.position, startingZone.transform.rotation);
	}
}
