using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHole : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // If ball touches Death holes collider
    // then isDead variable of BallControlScript is set to true
    void OnTriggerEnter2D(Collider2D col)
    {
        BallControlScript.setIsDeadTrue();
    }
}
