using UnityEngine;
using System.Collections;

public class CorrectSeatScript : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void OnMouseDown() {
		Dialoguer.StartDialogue(3, dialoguerCallback);
		this.enabled = false;
		
	}
	private void dialoguerCallback() {
		this.enabled = true;
	}
	
}
