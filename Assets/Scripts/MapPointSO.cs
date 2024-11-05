using UnityEngine;

[CreateAssetMenu(fileName = "MapPointSO", menuName = "Scriptable Objects/MapPointSO")]
public class MapPointSO : ScriptableObject
{
    public Transform prefab;
    public Sprite sprite;
    public int possibleRepeating;
    public string pointName;
}
