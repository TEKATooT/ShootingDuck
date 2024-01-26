using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private DeathStar _deathStar;

    [SerializeField] private Transform[] _transforms;

    private void FixedUpdate()
    {
        Spawned();
    }

    private void GiveEnemy()
    {
        int random = Random.Range(0, _transforms.Length);

        Instantiate(_deathStar, _transforms[random].position, Quaternion.identity);
    }

    private void Spawned()
    {
        if (GameObject.Find("DeathStar(Clone)") == false)
        {
            GiveEnemy();
        }
    }
}
