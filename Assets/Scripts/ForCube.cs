using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ForCube : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private int _hp;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        _hp--;
        _text.text = _hp.ToString();
    }
}
