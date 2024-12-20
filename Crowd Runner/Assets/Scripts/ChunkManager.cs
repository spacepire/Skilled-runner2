using UnityEngine;

public class ChunkManager : SingletonMonoBehaviour<ChunkManager>
{
    [Header("Elements")]
    [SerializeField] LevelSO[] levels;
    [SerializeField] BossSO[] Bosses;

    GameObject finishLine;

    protected override void Awake()
    {
        base.Awake();
    }

    void Start()
    {
        GenerateLevel();

        finishLine = GameObject.FindGameObjectWithTag("Finish");
    }


    private void GenerateLevel()
    {
        int currentLevel = GetLevel();

        currentLevel = currentLevel % levels.Length;

        LevelSO level = levels[currentLevel];

        CreateOrderedLevel(level.chunks);
    }

    private void GenerateBossArea()
    {
        int currentBoss = GetBoss();

        currentBoss = currentBoss % Bosses.Length;

        BossSO boss = Bosses[currentBoss];

        CreateOrderedLevel(boss.chunks);
    }




    private void CreateOrderedLevel(Chunk[] chunks)
    {
        Vector3 chunkPosition = Vector3.zero;
        for (int i = 0; i < chunks.Length; i++)
        {
            Chunk chunkToCreate = chunks[i];

            if (i > 0)
            {
                chunkPosition.z += chunkToCreate.GetLength() / 2;
            }

            Chunk chunkInstantiate = Instantiate(chunkToCreate, chunkPosition, Quaternion.identity, transform);

            chunkPosition.z += chunkInstantiate.GetLength() / 2;

        }
    }

    public float GetFinishZ()
    {
        return finishLine.transform.position.z;
    }

    private int GetBoss()
    {
        return PlayerPrefs.GetInt("Boss", 0);
    }

    public int GetLevel()
    {
        return PlayerPrefs.GetInt("Level", 0);
    }
}
