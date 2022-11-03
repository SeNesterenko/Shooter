using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] private float _speed;
    public Transform Target;

    private void Update()
    {
        var travelDistance = _speed * Time.deltaTime;

        var newPosition = Vector3.MoveTowards(transform.position, Target.position, travelDistance);
        transform.position = newPosition;
        transform.LookAt(Target);
    }
}
