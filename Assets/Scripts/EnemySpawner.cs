using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private int _numberEnemies;
    [SerializeField] private EnemyBehavior _enemy;
    [SerializeField] private Transform _target;
    
    [SerializeField] private int StartPosition;
    [SerializeField] private int FinishPosition;
    
    private const float EnemyYPosition = 1f;

    private void Start()
    {
        for (var i = 0; i < _numberEnemies; i++)
        {
            var newEnemy = Instantiate(_enemy);
            newEnemy.Target = _target;
            newEnemy.transform.position = new Vector3(Random.Range(StartPosition, FinishPosition),
                Random.Range(EnemyYPosition, EnemyYPosition), Random.Range(StartPosition, FinishPosition));
        }
    }
}
