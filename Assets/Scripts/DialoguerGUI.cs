using UnityEngine;
using System.Collections;

public class DialoguerGUI : MonoBehaviour {

	private bool _showing;

	private string _text;
	private string[] _choices;

	// Use this for initialization
	void Start () {
		Dialoguer.events.onStarted += onStarted;
		Dialoguer.events.onEnded += onEnded;
		Dialoguer.events.onTextPhase += onTextPhase;

	}

	void OnGUI() {
		if (!_showing) {
			return;
		}

		GUI.Box (new Rect(0,Screen.height-150,Screen.width,150), _text);

		if (_choices == null) {
			if (GUI.Button (new Rect ((Screen.width/2)-100, (Screen.height-40), 200, 30), "Continue")) {
				Dialoguer.ContinueDialogue ();
			}
		} else {
			for (int i=0; i <_choices.Length; i++) {
				if (GUI.Button (new Rect ((Screen.width/2)-(250*i), (Screen.height-40), 200, 30), _choices[i])) {
					Dialoguer.ContinueDialogue (i);
				}
			}
		}
	}

	private void onStarted() {
		_showing = true;
	}

	private void onEnded() {
		_showing = false;
	}

	private void onTextPhase(DialoguerTextData data) {
		_text = data.text;
		_choices = data.choices;
	}
}
