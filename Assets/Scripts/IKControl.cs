using UnityEngine;
[RequireComponent(typeof(Animator))]
public class IKControl : MonoBehaviour
{

    [SerializeField]
    private bool _isActive;

    [SerializeField]
    private Transform _lookObject;

    [SerializeField]
    private Transform _rightHandObject;

    [SerializeField]
    private Transform _leftHandObject;

    [SerializeField]
    private float _valueWeight;


    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex)
    {
        
        if (_isActive)
        {
            
            _animator.SetLookAtWeight(_valueWeight);
            _animator.SetLookAtPosition(_lookObject.position);

            ChangeWeightHand(_valueWeight);
            _animator.SetIKPosition(AvatarIKGoal.RightHand, _rightHandObject.position);
            _animator.SetIKRotation(AvatarIKGoal.RightHand, _rightHandObject.rotation);
            
            _animator.SetIKPosition(AvatarIKGoal.LeftHand, _leftHandObject.position);
            _animator.SetIKRotation(AvatarIKGoal.LeftHand, _leftHandObject.rotation);
            
        }
        else
        {
            ChangeWeightHand(0);
            _animator.SetLookAtWeight(0);
        }
    }
    private void ChangeWeightHand(float value)
    {
        _animator.SetIKPositionWeight(AvatarIKGoal.RightHand, value);
        _animator.SetIKRotationWeight(AvatarIKGoal.RightHand, value);

        _animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, value);
        _animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, value);
    }
}
