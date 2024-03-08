using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Move : MonoBehaviour
{
    [SerializeField] float speedVertical = 10;
    [Range(0f, 50f)]
    [SerializeField] float speedHorizontal = 40;
    [SerializeField] private Animator _anim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            transform.Translate(0, 0, v * speedVertical * Time.deltaTime);
            transform.Rotate(0, h * speedHorizontal * Time.deltaTime, 0);
        
        _anim.SetFloat("test", Mathf.Abs(v));
    }
}
