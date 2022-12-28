using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SetNavigationTarget : MonoBehaviour
{
    [SerializeField]
    private Camera topDownCamera;
    [SerializeField]
    private GameObject navTargetObject;
    private NavMeshPath path;
    // current calculated path
    private LineRenderer line;
    // linerenderer to display path
    private bool lineTogg1e = false;


    private void Start() {
        path = new NavMeshPath();
        line = transform.GetComponent<LineRenderer>();
    }
    private void Update() {
        if ((Input.touchCount >0) && (Input.GetTouch(0).phase == TouchPhase.Began)) {
            lineTogg1e = !lineTogg1e;
        }
        if (lineTogg1e) {
            NavMesh.CalculatePath(transform.position, navTargetObject.transform.position, NavMesh.AllAreas, path);
            line.positionCount = path.corners.Length;
            line.SetPositions(path.corners);
            line.enabled = true;
        }
    }
}
