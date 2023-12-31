using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float _moveSpeed = 0.005f;

    private void Update()
    {
        var nextPostion = transform.position;
        nextPostion.x += _moveSpeed;
        transform.position = nextPostion;
    }
}
