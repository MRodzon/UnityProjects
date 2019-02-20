using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveScript : MonoBehaviour {

    GameObject canvas;
    InterfaceScript interfaceScript;

    private void Start()
    {
        canvas = GameObject.Find("Canvas");
        interfaceScript = canvas.GetComponent<InterfaceScript>();
    }

    public void OnTriggerEnter()
    {
        interfaceScript.OnObjectiveAchieved();
    }
}
