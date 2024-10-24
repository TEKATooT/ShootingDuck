using UnityEngine;
using UnityEngine.InputSystem;
//using UnityEngine.InputSystem;
//InputAction.CallbackContext context
//[RequireComponent(typeof(PlayerInput))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]
public class Player : AbstractWarrior
{
    [SerializeField] private float _upForce;
    [SerializeField] private float _maxAngle;
    [SerializeField] private float _minAngle;
    [SerializeField] private float _rotationSpeed;

    private Quaternion _maxAngleZ;
    private Quaternion _minAngleZ;

    private Vector3 _startPosition;
    private Animator _animator;
    private Rigidbody2D _rigidbody2D;

    private int _shooting = Animator.StringToHash("Shoot");

    private void Start()
    {
        _startPosition = transform.position;

        _animator = GetComponent<Animator>();
        _rigidbody2D = GetComponent<Rigidbody2D>();

        _maxAngleZ = Quaternion.Euler(0, 0, _maxAngle);
        _minAngleZ = Quaternion.Euler(0, 0, _minAngle);
    }

    private void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, _minAngleZ, _rotationSpeed * Time.deltaTime);
    }

    protected override void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent(out Fighter fighter))
        {
            Time.timeScale = 0;
        }
    }

    private void OnAttack()
    {
        _animator.Play(_shooting);

        Shooting();
    }

    public void OnMoveUp()
    {
        _rigidbody2D.velocity = new Vector2(0, 0);

        transform.rotation = _maxAngleZ;

        _rigidbody2D.AddForce(Vector2.up * _upForce);
    }
}
