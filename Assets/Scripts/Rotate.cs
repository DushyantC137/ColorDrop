using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public float RotateSpeed;
    // Use this for initialization
    void Start () {
	}	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0f, 0f, RotateSpeed * Time.deltaTime);
    }
 
}
