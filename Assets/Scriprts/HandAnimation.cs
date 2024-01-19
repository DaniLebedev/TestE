using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimation : MonoBehaviour
{
    public InputActionProperty pinchanimation;
    public InputActionProperty gripanimation;
    public Animator animator;   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float pich = pinchanimation.action.ReadValue<float>();
        animator.SetFloat("Trigger", pich);
        float grip = gripanimation.action.ReadValue<float>();
        animator.SetFloat("Grip", grip);

    }
}
