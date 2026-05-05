using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    public DayNIght time;    

    public float mapWidth, mapHeight;

    public List<EnemyEntry> enemiesDay;
    public List<EnemyEntry> enemiesNight;

    void Update()
    {    
        if (Random.Range(0, 800/(1+(time.round/100)))+1==1)
        {
            if (time.day)
            {
                int enemyIndex = Random.Range(0, enemiesDay.Count);
                Instantiate(enemiesDay[enemyIndex].obj, new Vector3(Random.Range(17.4f+-mapWidth/2, 17.4f+mapWidth/2), enemiesDay[enemyIndex].startHeight, Random.Range(63.7f-mapHeight/2, 63.7f+mapHeight/2)), transform.rotation);
            } else
            {
                int enemyIndex = Random.Range(0, enemiesNight.Count);
                Instantiate(enemiesNight[enemyIndex].obj, new Vector3(Random.Range(17.4f+-mapWidth/2, 17.4f+mapWidth/2), enemiesDay[enemyIndex].startHeight, Random.Range(63.7f-mapHeight/2, 63.7f+mapHeight/2)), transform.rotation);
            }
        }
    }


[System.Serializable]
    public class EnemyEntry
    {
        public GameObject obj;
        public float startHeight;
        public EnemyEntry(GameObject obj, float startHeight, float startingHealth)
        {
            this.obj = obj;
            this.startHeight = startHeight;
        }
    }
}
