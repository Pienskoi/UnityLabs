using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Player")) return;
        if (SceneManager.GetActiveScene().name == "PrimitiveScene")
        {
            SceneManager.LoadScene("AssetsPackScene");
        } else if (SceneManager.GetActiveScene().name == "AssetsPackScene")
        {
            SceneManager.LoadScene("PrimitiveScene");
        }
    }
}
