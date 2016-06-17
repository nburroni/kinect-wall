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
		targetPoint.y = transform.position.y;
		transform.LookAt(targetPoint);
		Vector3 temp1 = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
		transform.position = temp1;
	}
}
