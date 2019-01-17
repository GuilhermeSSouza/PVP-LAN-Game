using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrestroyOverTime : MonoBehaviour {


    public float lifTime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        lifTime -= Time.deltaTime;
        if (lifTime<0) {
            Destroy(gameObject);
        }

	}
}
