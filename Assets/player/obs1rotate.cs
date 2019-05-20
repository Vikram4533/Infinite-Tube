using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obs1rotate : MonoBehaviour {

	// Use this for initialization\
	public float ror;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Rotate (0, 0, ror);
	}
}
