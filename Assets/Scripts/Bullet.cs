using UnityEngine;

public class Bullet : AbstractProjectile
{
    protected override void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent(out DeathStar player))
        {
            Destroy(gameObject);
        }
    }
}
