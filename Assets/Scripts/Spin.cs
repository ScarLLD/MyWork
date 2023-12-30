using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private Vector3 _rotationForce;

    private void Update()
    {
        transform.Rotate(_rotationForce);
    }
}
