using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionMeteor : MonoBehaviour
{
    public GameObject gameoverPnl;

    public PlayerMovementMeteor movement;
    void OnCollisionEnter(Collision collisionınfo)
    {
        if (collisionınfo.collider.tag == "Dusman")
        {
            movement.enabled = false;
            Time.timeScale = 0;
            gameoverPnl.SetActive(true);
        }    
    }
}
