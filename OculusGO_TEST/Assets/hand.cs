using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class hand : MonoBehaviour {
	static float fire_delay_time = 0,fire_time = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		fire_delay_time+=Time.deltaTime;
		if(OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger)&&fire_delay_time > fire_time){
			//fire

		}
		if(OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad)){
			//照準器準備
			
		}
		if(OVRInput.GetUp(OVRInput.Button.PrimaryTouchpad)){
			//照準器解除

		}
		
	}
}
