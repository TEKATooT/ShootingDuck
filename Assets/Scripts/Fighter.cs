using UnityEngine;

public class Fighter : AbstractProjectile
{
    protected override void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent<Player>(out Player player))
        {
            Destroy(gameObject);
        }
    }

    protected override void Shoot()
    {
        transform.Translate(Vector2.left * _bulletSpeed * Time.deltaTime);

        Destroy(gameObject, _timeToDestroy);
    }
}
