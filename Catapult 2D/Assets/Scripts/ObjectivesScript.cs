using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectivesScript : MonoBehaviour {

    private int objectivesNumber;
    public GameObject currentLvl;
    public GameObject nextLvl;


	void Start () {
        currentLvl.SetActive(true);
        if (nextLvl != null)
            nextLvl.SetActive(false);
    }
	
	void Update () {
        objectivesNumber = gameObject.transform.childCount;
        if (objectivesNumber == 0)
        {
            StartCoroutine(MapChange(2.0f));
        }
	}

    IEnumerator MapChange(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        currentLvl.SetActive(false);
        if (nextLvl != null)
            nextLvl.SetActive(true);
    }
}
