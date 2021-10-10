using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControll : MonoBehaviour
{

    public GameObject Coin;
    public float spawnRate = 0f;
    public float nextSpawn = 0f;

    private float[] linepos = { 3.57f, 2.23f, -0.83f, -3.29f, - 4.08f};
    float randomX;
    int randomY;

    Vector2 whereToSpawn;
    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            randomX = Random.Range(-3f, 8f);
            randomY = Random.Range(0, linepos.Length);
            whereToSpawn = new Vector2(randomX, linepos[randomY]);
            Instantiate(Coin, whereToSpawn, Quaternion.identity);

            nextSpawn = Time.time + spawnRate;
            Debug.Log(Time.time + spawnRate);
        }
    }
}
