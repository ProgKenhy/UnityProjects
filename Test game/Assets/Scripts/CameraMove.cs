using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform _target; 

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = _target.position;
    }
}
