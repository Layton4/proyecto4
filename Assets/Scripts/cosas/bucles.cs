using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucles: MonoBehaviour
{
    //FOR
    public GameObject[] enemyPrefabs;
    public Vector3[] positions;

    //FOREACH
    public Vector3 spawnPos;
    public List<GameObject> enemyPrefabslist;

    //WHILE
    private int startNum = 20;

    private float colorAlpha = 0;
    private MeshRenderer meshRenderer;

    void Start()

    {
        StartCoroutine(Fade());
        /*int initialNum = Random.Range(0, 20);
        for (int i = initialNum; i >= 0; i = i-1)
           {
               Debug.Log($"{i} seconds");
           }
         */
        //FOR
        /*
        for (int i = 0; i<enemyPrefabs.Length; i++)
        {
          for(int e = 0; e<positions.Length; e++)
            {
                Instantiate(enemyPrefabs[i], positions[e], enemyPrefabs[i].transform.rotation);
            }
          
       

        for (int i = 0; i<positions.Length; i++)
        {
            Instantiate(enemyPrefabs[i], positions[i], enemyPrefabs[i].transform.rotation);
        }
         

        //FOREACH
        foreach (Vector3 pos in positions)
        {
            foreach(GameObject enemy in enemyPrefabs)
            {
                Instantiate(enemy, pos, enemy.transform.rotation);
            }
            
        }
        
        foreach (Vector3 pos in positions)
        {
           
          Instantiate(enemyPrefabs[1], pos, enemyPrefabs[1].transform.rotation);

        }
        

        foreach(GameObject Enemy in enemyPrefabslist)
        {
            spawnPos = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5));
            Instantiate(Enemy, spawnPos, Enemy.transform.rotation);
        }
        
        //while
        while(startNum>0)
        {
            Debug.Log($"{startNum} seconds");
            startNum--;
        }
        */

    }
    public IEnumerator Fade()
    {
        float alphaValue = 1f;
        MeshRenderer cubeMeshRenderer = GetComponent<MeshRenderer>();
        Color color = cubeMeshRenderer.material.color;
        while(alphaValue > 0)
        {
            color.a = alphaValue;
            cubeMeshRenderer.material.color = color;
            alphaValue -= 0.1f;
            yield return new WaitForSeconds(0.25f);
            Debug.Log($"{alphaValue}");
        }
    }




    void Update()
    {
        
    }
}
