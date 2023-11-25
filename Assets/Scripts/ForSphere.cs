using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForSphere : MonoBehaviour
{
    [SerializeField] private GameObject _sphere;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnMouseDown()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    private void OnMouseUp()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }
}
