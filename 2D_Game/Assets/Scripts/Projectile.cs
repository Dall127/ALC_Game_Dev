using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    public float Speed;
    public Rigidbody2D Player;
    public GameObject EnemyDeath;
    public GameObject ProjectileParticle;
    public int PointsForKill;

	// Use this for initialization
	void Start () {
        //Player = FindObjectOfType<Rigidbody2D>();
        if(Player.transform.localScale.x < 0) {
            Speed = -Speed;    
        }
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);

	}
	private void OnTriggerEnter(Collider theObject) 
	{
        if(theObject.tag == "Enemy") {
            Instantiate(EnemyDeath, theObject.transform.position, theObject.transform.rotation);
            Destroy(theObject.gameObject);
            ScoreManager.AddPoints(PointsForKill);

        }
        Instantiate(ProjectileParticle, transform.position, transform.rotation);
        Destroy(gameObject);
	}
}
