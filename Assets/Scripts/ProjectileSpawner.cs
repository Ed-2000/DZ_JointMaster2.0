using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] private Projectile _projectile;
    [SerializeField] private Transform _spawnTransform;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out SpoonCatapult _))
            Instantiate(_projectile, _spawnTransform.position, _projectile.transform.rotation);
    }
}