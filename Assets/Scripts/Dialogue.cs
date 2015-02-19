using UnityEngine;
using System.Collections;

public class Dialogue : MonoBehaviour {
	RaycastHit hit = new RaycastHit();
	Ray ray = new Ray();
	void Awake() {
		Dialoguer.Initialize ();
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {


	}

	void OnMouseDown() {
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		
		Debug.DrawRay(ray.origin, ray.direction* 1000, Color.green);
		if (Physics.Raycast(ray,out hit, 100.0f)) {
			if (hit.collider.gameObject.tag == "NPC") {
				Dialoguer.StartDialogue(0, dialoguerCallback);
				this.enabled = false;
			}
		}
	}

	void OnGUI() {
		if(GUI.Button(new Rect(10,10, 100, 20), "Start Dialoguer")) {
			Dialoguer.StartDialogue(0, dialoguerCallback);
			this.enabled = false;
		}
	}
	
	private void dialoguerCallback() {
			this.enabled = true;
	}
}
