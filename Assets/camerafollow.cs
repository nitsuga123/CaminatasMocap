using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour {

	private const float Y_ANGLE_MIN = -10.0f;
	private const float Y_ANGLE_MAX = 50.0f;
	public Transform target;
	public Transform camTransform;

	private Camera cam;

	private float distance =2.0f;
	private float currentX = 0.0f;
	private float currentY = 0.0f;
	private float sensivityX = 4.0f;
	private float sensivityY = 1.0f;

	private Vector3 finalpos;
	private void Start(){
		camTransform = transform;
		cam = Camera.main;
		finalpos = new Vector3 (-9.9f, 1.37f, -39.32f);
		transform.position = finalpos;
	}
	private void Update(){
		currentX += Input.GetAxis ("Mouse Y");
		currentY += Input.GetAxis ("Mouse X");

		currentX = Mathf.Clamp (currentX, Y_ANGLE_MIN, Y_ANGLE_MAX);

		if(Input.GetAxis("Mouse ScrollWheel")< 0){
			Camera.main.fieldOfView++;
		}
		if(Input.GetAxis("Mouse ScrollWheel")> 0){
			Camera.main.fieldOfView--;
		}
	}

	private void LateUpdate(){
		Vector3 dir = new Vector3 (0, 0, -distance);
		Quaternion rotation = Quaternion.Euler (currentX, currentY, 0);
		camTransform.position = target.position + rotation * dir;
		camTransform.LookAt (target.position);

	}
}
