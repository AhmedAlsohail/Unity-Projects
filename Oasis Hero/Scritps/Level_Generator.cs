using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Generator : MonoBehaviour
{
    private const float PLAYER_DISTANCE_SPAWN_LEVEL_PART = 200f;
    [SerializeField] private Transform levelpartStart;
    [SerializeField] private List<Transform> levelPartList;
    [SerializeField] private GameObject player;

    private Vector3 lastEndPos;
    private void Awake()
    {
        lastEndPos = levelpartStart.Find("EndPos").position;
        int startingSpawnLevelParts = 5;
        for(int i = 0; i < startingSpawnLevelParts; i++)
        {
            spawnLevelPart();
        }
    }

    private void Update()
    {
            if (Vector3.Distance(player.transform.position, lastEndPos) < PLAYER_DISTANCE_SPAWN_LEVEL_PART)
           {

                spawnLevelPart();

            }
    }

    private void spawnLevelPart()
    {
        Transform choosenLevelPart = levelPartList[Random.RandomRange(0,levelPartList.Count)];
        Transform lastLevelPartTransform = spawnLevelPart(choosenLevelPart, lastEndPos);
        lastEndPos = lastLevelPartTransform.Find("EndPos").position;
    }
    private Transform spawnLevelPart(Transform levelPart,Vector3 spawnPos)
    {
        Transform levelPartTransform = Instantiate(levelPart, spawnPos, Quaternion.identity);
        return levelPartTransform;
    }
}
