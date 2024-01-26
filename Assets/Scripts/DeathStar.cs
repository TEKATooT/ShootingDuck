using UnityEngine;

public class DeathStar : AbstractWarrior
{
    private void Start()
    {
        Shooting();
    }

    protected override void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent<Bullet>(out Bullet bullet))
        {
            Destroy(gameObject);
        }
    }
}
