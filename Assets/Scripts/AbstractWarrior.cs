using UnityEngine;

public abstract class AbstractWarrior : MonoBehaviour
{
    [SerializeField] protected AbstractProjectile _projectile;
    [SerializeField] protected Transform _gunPosition;

    protected abstract void OnTriggerEnter2D(Collider2D collider);

    protected virtual void Shooting()
    {
        Instantiate(_projectile, _gunPosition.position, transform.rotation);
    }
}
