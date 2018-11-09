using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    public float Speed;
    public Rigidbody2D Player;
    public GameObject EnemyDeath;
    public GameObject ProjectileParticle;
    public int PointsForKill;
    public Player_Control Player_Controller;
    public LayerMask WhatIsWall;

	// Use this for initialization

	private void Start()
	{
        if (Player_Controller.GetDirection() == -1)
        {
            Speed = -Speed;
        }
	}
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);

	}
	private void OnTriggerEnter2D(Collider2D theObject)
	{
        if (theObject.tag == "Enemy")
        {
            Instantiate(EnemyDeath, theObject.transform.position, theObject.transform.rotation);
            Destroy(theObject.gameObject);
            ScoreManager.AddPoints(PointsForKill);
            Destroy(gameObject);
            Instantiate(ProjectileParticle, transform.position, transform.rotation);

        }
        if (theObject.gameObject.layer.ToString() == "Wall") {
            
            Destroy(gameObject);

        }




    }

}
	
