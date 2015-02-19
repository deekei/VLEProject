using UnityEngine;
using System.Collections;

public class NPCScript : MonoBehaviour {




	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown() {
		Dialoguer.StartDialogue(0, dialoguerCallback);
		this.enabled = false;
	}

	private void dialoguerCallback() {
		this.enabled = true;
	}

	
}
