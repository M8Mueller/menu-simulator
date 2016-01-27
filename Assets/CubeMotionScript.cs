using UnityEngine;
using System.Collections;

public class CubeMotionScript : MonoBehaviour {
    public GameObject cube;
    public bool active;
    public float smooth;
    public Vector3 rotationPoint;
    public Vector3 rotationAxis;

	// Use this for initialization
	void Start () {
        cube = GameObject.Find("Cube");
        smooth = 90;
        rotationPoint = cube.transform.position;
        rotationAxis = cube.transform.up;
	}
	
	// Update is called once per frame
	void Update () {
        if (active) {
            cube.transform.RotateAround(rotationPoint, rotationAxis, Time.deltaTime * smooth);
        }
    }

    public void StartButtonClick () {
        active = true;
    }

    public void StopButtonClick () {
        active = false;
    }

    public void UpButtonClick () {
        rotationAxis = cube.transform.forward;
    }

    public void ShiftButtonClick()
    {
        ChangeRotationAxis(new Vector3(0.1f, 0.2f, 0.3f));
    }

    void ChangeRotationAxis (Vector3 deltaAxis) {
        rotationAxis += deltaAxis;
    }

    public void ChangeRotationPoint (Vector3 newPoint) {
        rotationPoint = newPoint;
    }
}
