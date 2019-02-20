using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractablesScript : MonoBehaviour {

    public GameObject door;

    public void ButtonOpeningDoors()
    {
        this.transform.Translate(0, 0, 0.25f);
        door.gameObject.SetActive(false);
    }
}
