using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Button StartButton = GetComponent<Button>();
		StartButton.animator.SetTrigger("Highlighted");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) {
			SceneManager.LoadScene("GameScene");
		}
	}
}
