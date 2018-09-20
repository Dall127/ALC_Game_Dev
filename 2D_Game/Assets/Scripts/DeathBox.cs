using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox : MonoBehaviour {

	// Use this for initialization
    private void OnTriggerEnter2D(Collider2D theObject) {
        if (theObject.name == "PC") {
            Debug.Log("Player Enters Death Zone");
            Destroy(theObject);
        }
    }
	
}
