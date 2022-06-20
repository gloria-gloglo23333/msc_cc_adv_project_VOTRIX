using UnityEngine;
using UnityEngine.SceneManagement;

public class GMan : MonoBehaviour
{
    bool waterSurface = false;

    public float restartDelay = 0.1f;

    public void BackPosition()
    {
        if (waterSurface == false)
        {
            waterSurface = true;
            Debug.Log("Back To Start Position");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
