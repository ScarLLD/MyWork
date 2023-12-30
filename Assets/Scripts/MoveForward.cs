using UnityEngine;

public class MoveForward : MonoBehaviour
{  
    private void Update()
    {
        var nextPostion = transform.position;
        nextPostion.x += 0.005f;
        transform.position = nextPostion;
    }
}
