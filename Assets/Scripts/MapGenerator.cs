using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] private List<GameObject> availableOptionsList;
    [SerializeField] private List<MapPointSO> availablePointList;
    [SerializeField] private readonly int numberOfMapLines = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GenerateMap();
    }

    // Generates a certain number of lines with points creating a map
    public void GenerateMap()
    {
        for (int x = 0; x < numberOfMapLines; x++)
        {
            GenerateMapLinePoints();

        }
    }

    // It checks all possible points and randomly chooses if it is active or not.
    public void GenerateMapLinePoints()
    {

        for (int i = 0; i < availableOptionsList.Count; i++)
        {
            bool noPointsExist = true;
            MapPointSO currentPoint = GeneratePoint();
            int pointExist = Random.Range(0, 2);
            Debug.Log(pointExist);
            if (pointExist == 1)
            {
                availableOptionsList[i].GetComponent<SpriteRenderer>().sprite = currentPoint.sprite;
                noPointsExist = false;
            }
            if (i == availableOptionsList.Count && noPointsExist)
            {
                availableOptionsList[0].GetComponent<SpriteRenderer>().sprite = currentPoint.sprite;
            }
        }

    }

    // Ggenerating a random point from the list
    public MapPointSO GeneratePoint()
    {
        int currentPoint = Random.Range(0, availablePointList.Count);

        return availablePointList[currentPoint];
    }








}
