using UnityEngine;


[CreateAssetMenu(fileName = "Boss", menuName = "Scriptable Objects/Boss", order = 0)]
public class BossSO : ScriptableObject
{
    public Chunk[] chunks;
}
