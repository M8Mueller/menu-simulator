using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {
    public GameObject cube;
    public bool active;
    public float smooth;

	// Use this for initialization
	void Start () {
        cube = GameObject.Find("Cube");
        smooth = 90;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (active) {
            cube.transform.RotateAround(cube.transform.position, cube.transform.up, Time.deltaTime * smooth);
        }
    }

    public void ClickStartButton ()
    {
        active = true;
        print("Start button clicked");
    }
}
