using TMPro;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    //Level Timer
    private int minutes = 0;
    private int seconds = 0;

    //Components
    [Header("HUD Text")]
    [SerializeField] private TMP_Text timeShotgunText;


    private void Update()
    {
        LevelManager.Instance.InternalLevelTime -= Time.deltaTime;
        seconds = (int)LevelManager.Instance.InternalLevelTime % 60;
        minutes = (int)LevelManager.Instance.InternalLevelTime / 60;
    }

    private void OnGUI()
    {
        timeShotgunText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }

}
