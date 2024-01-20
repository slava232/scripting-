using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardMotion : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("velX", Input.GetAxis("Horizontal"), 0.1f, Time.deltaTime);
        animator.SetFloat("velY", Input.GetAxis("Vertical"), 0.1f, Time.deltaTime);
    }
}
