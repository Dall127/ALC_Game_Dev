using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    public float Speed;
    public Rigidbody2D Player;
    public GameObject EnemyDeath;
    public GameObject ProjectileParticle;
    public int PointsForKill;
    public Player_Control Player_Control;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
        

	}
	private void OnTriggerEnter(Collider theObject) 
	{
        if(theObject.tag == "Enemy") {
            Instantiate(EnemyDeath, theObject.transform.position, theObject.transform.rotation);
            Destroy(theObject.gameObject);
            ScoreManager.AddPoints(PointsForKill);

        }

        Instantiate(ProjectileParticle, transform.position, transform.rotation);
        if(Player_Control.GetDirection() == -1) {
            Speed = -Speed;
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
        Destroy(gameObject);
	}
}
