using UnityEngine;

public class EnergyCell : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.instance.AddScore();
            Destroy(gameObject);
        }
    }
}