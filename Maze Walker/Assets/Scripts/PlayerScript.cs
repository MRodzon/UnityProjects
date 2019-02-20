using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PlayerScript : MonoBehaviour {

    private NavMeshAgent nma;
    InteractablesScript interacts;
    CollectibleScript collectibles;
//    private bool running = false;

    void Start () {
        nma = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                nma.destination = hit.point;
            }
        }
//        if (nma.remainingDistance <= nma.stoppingDistance)
//            running = false;
//        else
//            running = true;
	}

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Interaction")
        {
            interacts = col.GetComponent<InteractablesScript>();
            interacts.ButtonOpeningDoors();
            col.isTrigger = false;
        }
        if (col.gameObject.tag == "Collectible")
        {
            collectibles = col.GetComponent<CollectibleScript>();
            collectibles.CollectibleCoin();
        }
        if (col.gameObject.tag == "HidingPlace")
        {
            Debug.Log("You're Safe");
        }
    }
}
