using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class des : MonoBehaviour {

	public GameObject player;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(player){
		if (player.transform.position.z -6> gameObject.transform.position.z) {
			Destroy (gameObject);
		}
	}
}
}
