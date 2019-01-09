using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour {

	private Transform point1Trans;
	private Transform point2Trans;
	private LineRenderer line;
	// Use this for initialization
	void Start () {
		point1Trans = GameObject.Find("Poin1").transform;
		point2Trans = GameObject.Find("Poin2").transform;

		line = GetComponent<LineRenderer>();
		line.SetVertexCount(2);

		Debug.Log(point1Trans);
	}
	
	// Update is called once per frame
	void Update () {
		line.SetPosition(0, point1Trans.position);
		line.SetPosition(1, point2Trans.position);
	}
}
