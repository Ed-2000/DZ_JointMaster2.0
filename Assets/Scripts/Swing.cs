using UnityEngine;

public class Swing : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private Rigidbody _rigidbody;

    private Vector3 _lastVelosity;
    private KeyCode RunCommand = KeyCode.Space;

    private void Awake()
    {
        _lastVelosity = Vector3.right;
    }

    private void Update()
    {
        if (Input.GetKeyDown(RunCommand))
        {
            if (_rigidbody.velocity != Vector3.zero)
                _lastVelosity = _rigidbody.velocity;

            _rigidbody.AddForce(_lastVelosity.normalized * _force);
        }
    }
}