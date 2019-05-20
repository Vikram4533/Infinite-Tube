using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tubesinfinity : MonoBehaviour {

	public Transform othertube;
	public float halflength = 12f;
	private Transform player;
	private float endoffset=3f;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
	}

	void Update () {
		moveground ();
	}

	void moveground(){
		if (player) {
			if (transform.position.z + halflength < player.transform.position.z - endoffset) {
				transform.position = new Vector3 (othertube.position.x, othertube.position.y, othertube.position.z + halflength);
	
			}
		}
	}


}//class
