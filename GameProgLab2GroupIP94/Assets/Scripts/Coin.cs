using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int value = 1;

    private Score _score;
    
    private void Awake()
    {
        _score = FindObjectOfType<Score>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Player")) return;
        _score.AddPoints(value);
        Destroy(gameObject);
    }
}
