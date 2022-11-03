using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    [SerializeField] private Vector3 _rotationSpeed;
    [SerializeField] private float _movementSpeed;
    

    private void Update()
    {
        var vertical = Input.GetAxis("Vertical") * _movementSpeed;
        var horizontal = Input.GetAxis("Horizontal") * _rotationSpeed;
        
        transform.Translate(Vector3.forward * vertical * Time.deltaTime);
        transform.Rotate(horizontal * Time.deltaTime);
    }
}