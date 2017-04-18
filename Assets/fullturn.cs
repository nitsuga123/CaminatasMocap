using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fullturn : MonoBehaviour {


	private bool turn;
	private float timetodothisloop;
	// Use this for initialization
	void Start () {
		
	}
	void Awake(){
		turn = true;
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("w") && turn == true){ //rotate script here 
			turn = false; 
			for (var i = 0; i < timetodothisloop; i++){

				transform.Rotate(0,180/timetodothisloop,0);
			}
			turn = true;
		}
	}
}
