using UnityEngine;
using System.Collections;

public class WolfGoWent : MonoBehaviour {
    public GameObject Wolf;
    Vector3 vr;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        vr = Wolf.transform.position;
        //Debug.Log(vr.x + " | " + vr.z);
        if (vr.z < 0.17 || vr.z > 96 || vr.x < -26 || vr.x > 132)
            Wolf.transform.Rotate(new Vector3(0f, 40f, 0f));
    }
    
}
