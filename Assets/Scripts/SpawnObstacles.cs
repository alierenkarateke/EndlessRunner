using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{

    // Obstacle objesi
    [SerializeField] GameObject Obstacle;

    // min - max X ve Y değerleri
    [SerializeField] float maxX;
    [SerializeField] float minX;
    [SerializeField] float maxY;
    [SerializeField] float minY;

    // İki nesne oluşumu arasındaki süre değişkenleri
    [SerializeField] float timeBetweenSpawn;
    private float spawnTime;


    // Update is called once per frame
    void Update()
    {
        // Time.time = oyun başladığından beridir geçen süre
        // Time.time > spawnTime obje oluşturulur
        if(Time.time > spawnTime)
        {
            Spawn();

            // Her nesne sonrası istediğimiz süreye göre spawnTime güncellenir ve nesne oluşur
            spawnTime = Time.time + timeBetweenSpawn;   
        }
    }

    void Spawn()
    {

        // Nesnelerin rastgele biçimde pozisyonlarının oluşumu
        float randomX = UnityEngine.Random.Range(minX,maxX);
        float randomY = UnityEngine.Random.Range(minY,maxY);

        // Nesne oluşturma metodu
        // Instantiate(obje,pozisyon,rotasyon)
        Instantiate(Obstacle, transform.position + new Vector3(randomX,randomY,0), transform.rotation);
    }
}
