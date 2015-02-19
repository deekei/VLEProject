using UnityEngine;
using System.Collections;

public class AreaScript : MonoBehaviour {

	public float timer;
	bool isNear = false;
	bool hasTalked = false;
	
	// Use this for initialization
	void Start () {
		timer = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!isNear ) {
			if (timer > 0) {
				timer -= Time.deltaTime;
			} else if (timer < 0) {
				timer = 0;
			}
		}
	}

	
	void OnTriggerStay(Collider collide) {
		
		
		if (collide.gameObject.tag == "Player") {
			isNear = true;
			if (timer < 9 && !hasTalked) {
				timer += Time.deltaTime;
			}
		} 
		
		if (timer > 9) {
			Dialoguer.StartDialogue(1, dialoguerCallback);
			timer = 0;
			hasTalked = true;
		}
	}

	private void dialoguerCallback() {
		this.enabled = true;
	}
	
	
	void OnTriggerExit (Collider collide) {
		
		isNear = false;
		
	}
}
