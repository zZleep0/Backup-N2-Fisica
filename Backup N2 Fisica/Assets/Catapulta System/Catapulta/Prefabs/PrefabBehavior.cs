using System.Collections;
using UnityEngine;

public class PrefabBehavior : MonoBehaviour
{
    public GameController game;

    public GameObject explosaoPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        game = GameObject.Find("Game").GetComponent<GameController>();

        Destroy(gameObject, 15f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer != LayerMask.NameToLayer("Catapulta"))
            Instantiate(explosaoPrefab, gameObject.transform.position, Quaternion.identity);

        if (collision.collider.CompareTag("Mago"))
        {
            Debug.Log("colidiu com o mago");
            game.pontos += 50;
        }
    }
}
