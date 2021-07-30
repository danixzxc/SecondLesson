
using System.Collections;
using UnityEngine;

public class AnimationToRagdoll : MonoBehaviour
{

    private Rigidbody[] _rb;
   //private Animation _anim;

    private void Awake()
    {
        _rb = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rb in _rb)
            rb.isKinematic = true;
       // _anim = GetComponent<Animation>();
    }


    private void Start()
    {
        StartCoroutine(SwitchCoroutine());
    }

    private void RagdollOn()
    {
        foreach (Rigidbody rb in _rb)
            rb.isKinematic = false;
        GetComponent<Animator>().enabled = false;
    }

    IEnumerator SwitchCoroutine()
    {
        yield return new WaitForSeconds(4f);
        RagdollOn();
    }
}
