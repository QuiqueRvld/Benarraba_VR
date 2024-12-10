using UnityEngine;

public class ActiveMinigame : MonoBehaviour
{

    public static ActiveMinigame instance;

    [SerializeField] private GameObject shotgun;
    [SerializeField] private GameObject[] jars;
    [SerializeField] private GameObject shotgunTimer;
    public void ActiveShotgunMinigame()
    {
        shotgun.SetActive(true);
        shotgunTimer.SetActive(true);
        gameObject.SetActive(false);
        foreach (GameObject jar in jars)
        {
            jar.GetComponent<JarronController>().RespawnStart();
        }


        LevelManager.Instance.InternalLevelTime = LevelManager.Instance.ShotgunLevelTime;
        LevelManager.Instance.IsActiveMinigame = true;
        LevelManager.Instance.ShotgunActive = true;
    }

    private void Awake()
    {
        instance = this;
    }


}
