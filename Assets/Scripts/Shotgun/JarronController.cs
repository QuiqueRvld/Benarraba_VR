using UnityEngine;

public class JarronController : MonoBehaviour
{
    [SerializeField] private float initTime;


    public void RespawnStart()
    {
        Invoke(nameof(Respawn), initTime);
    }

    private void OnDisable()
    {
        if (LevelManager.Instance.ShotgunActive)
        {
            float i = (Random.value * 6) + 5;
            Invoke(nameof(Respawn), i);
        }
        
    }

    private void Respawn()
    {
        gameObject.SetActive(true);
    }
}
