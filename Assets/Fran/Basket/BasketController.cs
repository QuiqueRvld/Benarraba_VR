using UnityEngine;

public class BasketController : MonoBehaviour
{
    [SerializeField] private GameObject scoreBasket;
    [SerializeField] private Transform scoreBasketSpawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BasketBall"))
        {
            Destroy(other.gameObject);

            if (scoreBasket)
            {
                GameObject tempFlash = Instantiate(scoreBasket, scoreBasketSpawn.position, scoreBasketSpawn.rotation);
                Destroy(tempFlash, 2f);
            }
        }
    }
}
