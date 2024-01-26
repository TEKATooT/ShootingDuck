using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private DeathStar _deathStar;

    [SerializeField] private Transform[] _transforms;

    private void Start()
    {
        GiveEnemy();
    }

    public void GiveEnemy()
    {
        int randomNumber = Random.Range(0, _transforms.Length);

        var star = Instantiate(_deathStar, _transforms[randomNumber].position, Quaternion.identity);

        star._hited.AddListener(GiveEnemy);
    }
}
