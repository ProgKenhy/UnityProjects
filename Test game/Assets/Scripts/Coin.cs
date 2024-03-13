using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] float _rotationSpeed;


    void Update()
    {
        transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<CoinManager>().AddOne();
        Destroy(gameObject);
    }
}
