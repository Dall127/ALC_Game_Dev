using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Player_Control Player;
    public bool isFollowing;


    //camera position offset
    public float xOffset;
    public float yOffset;


	// Use this for initialization
	void Start () {
        Player = FindObjectOfType<Player_Control>();
        isFollowing = true;

	}
	
	// Update is called once per frame
	void Update () {
        if(isFollowing) {
            transform.position = new Vector3(Player.transform.position.x + xOffset, Player.transform.position.y + yOffset, transform.position.z);
        }
	}
}
