using UnityEngine;
using UnityEngine.Events;

public class DeathStar : AbstractWarrior
{
    [SerializeField] public UnityEvent _hited;

    private void Start()
    {
        Shooting();
    }

    protected override void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent(out Bullet bullet))
        {
            _hited?.Invoke();

            _hited.RemoveAllListeners();

            Destroy(gameObject);
        }
    }
}
