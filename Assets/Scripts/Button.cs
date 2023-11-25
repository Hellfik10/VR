using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    private bool _isVisible = true;
    [SerializeField] private GameObject _go;
    public void Click()
    {
        _isVisible = !_isVisible;
        _go.SetActive(_isVisible);
    }
}
