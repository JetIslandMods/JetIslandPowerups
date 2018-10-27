using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour {

    private float _yOffset = 0f;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        _yOffset = Mathf.Sin(Time.time * 2f) * 0.5f * Time.deltaTime;
        gameObject.transform.Rotate(new Vector3(0f, 90f * Time.deltaTime, 0f));
        gameObject.transform.position += new Vector3(0f, _yOffset, 0f);
    }
}
