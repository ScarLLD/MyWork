using UnityEngine;

public class Sizing : MonoBehaviour
{
    [SerializeField] private float _changeSizeSpeed;

    private void Update()
    {
        transform.localScale *= _changeSizeSpeed;
    }
}

