using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float _stepLength = 0.005f;

    private void Update()
    {
        var nextPostion = transform.position;
        nextPostion.x += _stepLength;
        transform.position = nextPostion;
    }
}
