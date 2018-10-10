using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
    public Transform firePoint;
    public GameObject projectile;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.S)) {
            Instantiate(projectile, firePoint.position, firePoint.rotation);
        }	
	}
}
