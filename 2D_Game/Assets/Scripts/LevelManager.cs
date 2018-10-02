using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public GameObject currentCheckPoint;
    private Rigidbody2D PC;
    //Patricles
    public GameObject deathParticle;
    public GameObject respawnParticle;
    //Respawn Delay
    public float respawnDelay;

    //point penalty on death
    public int pointPenaltyOnDeath;

    //store gravity value
    private float gravityStore;

	// Use this for initialization
	void Start () {
        PC = FindObjectOfType<Rigidbody2D>();

	}


	
	// Update is called once per frame
	public void ReswpawnPlayer () {
        //generate death particle 
        StartCoroutine("ReswpanwPlayerCo");
	}
    public IEnumerator RespawnPlayerCo() {
        //Generate Death Particle
        Instantiate(deathParticle, PC.transform.position, PC.transform.rotation);
        //hide Player 
        //PC.enabled = false;
        PC.GetComponent<Renderer>().enabled = false;
        //Gravtiy Reset
        gravityStore = PC.GetComponent<Rigidbody2D>().gravityScale; 
        PC.GetComponent<Rigidbody2D>().gravityScale = 0f;
        PC.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        //Point Penalty
        ScoreManager.AddPoints(-pointPenaltyOnDeath);
        //Debug Message
        Debug.Log("Player Respawn");
        //Respawn Dely
        yield return new WaitForSeconds(respawnDelay);
        //gravity restore
        PC.GetComponent<Rigidbody2D>().gravityScale = gravityStore;
        //Match Players transform postion
        PC.transform.position = currentCheckPoint.transform.position;
        //showPlayer
        //PC.disabled;
        PC.GetComponent<Renderer>().enabled = true;
        Instantiate(respawnParticle, currentCheckPoint.transform.position, currentCheckPoint.transform.rotation);


    }
	private void Update()
	{
		
	}
}
