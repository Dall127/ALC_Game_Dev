using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {
    public int levelToLoad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D theObject)
    {
        if (theObject.gameObject.name == "PC")
        {

            SceneManager.LoadScene(levelToLoad);

        }
    }

}
