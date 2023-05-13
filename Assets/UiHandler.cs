using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiHandler : MonoBehaviour
{
    [SerializeField]
    private Sprite panel;
    
    private void Start() {
        panel = gameObject.GetComponent<Sprite>();
    }
    private void Update() {
        
    }


}
