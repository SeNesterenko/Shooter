using UnityEngine;

namespace DefaultNamespace
{
    public class Bullet : MonoBehaviour
    {
        private void OnTriggerEnter(Collider otherCollider)
        {
            var enemy = otherCollider.GetComponent<Renderer>();
            Destroy(enemy);
            Destroy(gameObject);
        }

        private void OnCollisionEnter(Collision collision)
        {
            Destroy(gameObject);
        }
    }
}