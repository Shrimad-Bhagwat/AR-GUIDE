using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class SetNavigationTarget : MonoBehaviour
{
    [SerializeField]
    private TMP_Dropdown navigationTargetDropDown;
    [SerializeField]
    private List<Target> navigationTargetObjects = new List<Target>();
    [SerializeField]
    private Camera topDownCamera;
    [SerializeField]
    private GameObject navTargetObject;
    // current calculated path
    private NavMeshPath path;
    // line renderer to display path
    private LineRenderer line;
    // current target position
    private Vector3 targetPosition = Vector3.zero;
    // toggle to show/hide path
    private bool lineToggle = false;

    private void Start() {
        path = new NavMeshPath();
        line = transform.GetComponent<LineRenderer>();
        line.enabled = lineToggle;
    }
    private void Update() {
        // if ((Input.touchCount >0) && (Input.GetTouch(0).phase == TouchPhase.Began)) {
        //     lineToggle = !lineToggle;
        // }
        if (lineToggle && (targetPosition != Vector3.zero)) {
            // navTargetObject.transform.position = targetPosition;
            NavMesh.CalculatePath(transform.position, navTargetObject.transform.position, NavMesh.AllAreas, path);
            line.positionCount = path.corners.Length;
            line.SetPositions(path.corners);
            // line.enabled = true;
        }
    }
    
    public void SetCurrentNavigationTarget(int selectedValue) {
        Debug.Log(selectedValue);
        targetPosition = Vector3.zero;
        string selectedText = navigationTargetDropDown.options[selectedValue].text;
        Debug.Log(selectedText);
        Target currentTarget = navigationTargetObjects.Find(x => x.Name.ToLower().Equals(selectedText.ToLower()));
        if (currentTarget != null) {
            targetPosition = currentTarget.PositionObject.transform.position;
        }
        navTargetObject = currentTarget.PositionObject;
    }

    public void ToggleVisibility(){
        lineToggle = !lineToggle;
        line.enabled = lineToggle;
        Debug.Log("ToggleVisibility");
    }
}
