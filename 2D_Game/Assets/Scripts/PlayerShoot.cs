using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
    public Transform firePointL;
    public Transform firePointR;
    public GameObject projectile;
    public Player_Control Player_Control;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.S)) {
            if (Player_Control.GetDirection() == -1) {
                Instantiate(projectile, firePointL.position, firePointL.rotation);
            }
            else {
                Instantiate(projectile, firePointR.position, firePointR.rotation);

            }
        }	
	}
}
