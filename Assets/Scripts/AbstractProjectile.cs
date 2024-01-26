using UnityEngine;

public abstract class AbstractProjectile : MonoBehaviour
{
    [SerializeField] protected float _bulletSpeed = 10;
    [SerializeField] protected float _timeToDestroy = 3;

    private void Update()
    {
        Shoot();
    }

    protected abstract void OnTriggerEnter2D(Collider2D collider);

    protected virtual void Shoot()
    {
        transform.Translate(Vector2.right * _bulletSpeed * Time.deltaTime);

        Destroy(gameObject, _timeToDestroy);
    }
}
