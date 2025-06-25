using UnityEngine;

public class Meteorite : MonoBehaviour
{
    [SerializeField]
    private GameObject      explosionPrefab;     // 폭발 이펙트 프리팹
    private GameController  gameController;

    public void Setup(GameController gameController)
    {
        this.gameController = gameController;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // 폭발 이펙트 생성
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            // 운석 삭제
            Destroy(gameObject);

            gameController.GameOver();
        }
    }
}

