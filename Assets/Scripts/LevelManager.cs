using UnityEngine;
using static OVRPlugin;
using UnityEngine.UIElements;
using TMPro;

public class LevelManager : MonoBehaviour
{
    //Singleton
    public static LevelManager Instance;

    //Game Time
    [Header("Shotgun")]
    [SerializeField][Tooltip("Shotgun Level Time in Seconds")] private int shotgunLevelTime;
    [SerializeField][Tooltip("Shotgun Level Timer")] private GameObject shotgunLevelTimer;
    [SerializeField][Tooltip("Shotgun Button")] private GameObject buttonShotgun;
    private bool shotgunActive;

    //[Header("Basket")]
    //[SerializeField][Tooltip("Basket Level Time in Seconds")] private int basketLevelTime;
    //[SerializeField][Tooltip("Basket Level Timer")] private GameObject basketLevelTimer;
    //[SerializeField][Tooltip("Basket Button")] private GameObject buttonBasket;
    //private bool basketActive;

    //[Header("Turron")]
    //[SerializeField][Tooltip("Turron Level Time in Seconds")] private int turronLevelTime;
    //[SerializeField][Tooltip("Turron Level Timer")] private GameObject turronLevelTimer;
    //[SerializeField][Tooltip("Turron Button")] private GameObject buttonTurron;
    //private bool turronActive;


    private float internalLevelTime;
    private bool isActiveMinigame;

    //Points
    [Header("Points")]
    private int points;


    public float InternalLevelTime { get => internalLevelTime; set => internalLevelTime = value; }

    public int Points { get => points; set => points = value; }

    public int ShotgunLevelTime { get => shotgunLevelTime; set => shotgunLevelTime = value; }

    public bool IsActiveMinigame { get => isActiveMinigame; set => isActiveMinigame = value; }
    public bool ShotgunActive { get => shotgunActive; set => shotgunActive = value; }
    //public bool BasketActive { get => basketActive; set => basketActive = value; }
    //public bool TurronActive { get => turronActive; set => turronActive = value; }

    private void Awake()
    {
        //Singletone, reference Instance to this object instance
        Instance = this;

        //Restart time scale
        Time.timeScale = 1;

        
        isActiveMinigame = false;
        shotgunLevelTimer.SetActive(false);
        //basketLevelTimer.SetActive(false);
        //turronLevelTimer.SetActive(false);
        buttonShotgun.SetActive(true);
        //buttonBasket.SetActive(true);
        //buttonTurron.SetActive(true);
        shotgunActive = false;

    }

    private void Update()
    {
        CheckTimerGames();
    }

    private void CheckTimerGames()
    {
        if(isActiveMinigame && internalLevelTime <= 0)
        {
            isActiveMinigame = false;
            shotgunLevelTimer.SetActive(false);
            //basketLevelTimer.SetActive(false);
            //turronLevelTimer.SetActive(false);
            buttonShotgun.SetActive(true);
            //buttonBasket.SetActive(true);
            //buttonTurron.SetActive(true);
            shotgunActive = false;
        }
    }

    

}
