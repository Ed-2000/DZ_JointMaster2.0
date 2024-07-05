using UnityEngine;

public class Catapult : MonoBehaviour
{
    [SerializeField] private SpringJoint _joint;
    [SerializeField] private Rigidbody _spoonRigidbody;
    [SerializeField] private Vector3 _anhorShootPosition;

    private Vector3 _anhorPeacePosition;
    private KeyCode _shootCommand = KeyCode.UpArrow;
    private KeyCode _peaceCommand = KeyCode.DownArrow;

    private void Awake()
    {
        _anhorPeacePosition = _joint.anchor;
    }

    private void Update()
    {
        if (Input.anyKey)
        {
            if (_spoonRigidbody.IsSleeping())
                _spoonRigidbody.WakeUp();

            if (Input.GetKeyDown(_shootCommand))
                _joint.anchor = _anhorShootPosition;

            else if (Input.GetKeyDown(_peaceCommand))
                _joint.anchor = _anhorPeacePosition;
        }
    }
}