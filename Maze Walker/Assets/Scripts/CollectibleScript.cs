using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour {

    public void CollectibleCoin()
    {
        Debug.Log("Coin Collected");
        Destroy(this.gameObject.transform.parent.gameObject);
    }

    private void OnDestroy()
    {
        
    }
}
