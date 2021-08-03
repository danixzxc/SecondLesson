
using System.Collections;
using UnityEngine;

public class AnimationToRagdoll : MonoBehaviour
{

    private Rigidbody[] _rb;
    private Animator _anim;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _rb = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rb in _rb)
            rb.isKinematic = true;
    }


    private void Start()
    {
        StartCoroutine(SwitchCoroutine());
    }

    private void RagdollOn()
    {
        foreach (Rigidbody rb in _rb)
            rb.isKinematic = false;
        _anim.enabled = false;
    }

    IEnumerator SwitchCoroutine()
    {
        yield return new WaitForSeconds(4f);
        RagdollOn();
    }
}
