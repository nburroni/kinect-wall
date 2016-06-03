using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	public GameObject target;
	private Vector3 targetPoint;
	private Quaternion targetRotation;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		targetPoint = target.transform.position;
		targetPoint.y = 0;
		transform.LookAt(targetPoint);
		Vector3 temp1 = new Vector3 (transform.position.x, transform.position.y + 0.1F, transform.position.z);
		transform.position = temp1;
	}
}
