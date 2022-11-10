using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    #region ���� ���
    public GameObject[] Enemy;
    private GameObject SpawnEnemy;
    public Transform Goalpoint;
    private List<BoxCollider> spawnZone;
    private SetPosition spawnPos;
    private float spawnerTimer;

    static float spawnDelay = 5f;
    static float normalRatio = 0.8f;
    static int normal = 0, elite = 1;
    #endregion

    //���� �غ� **TODO : Init �޼��� ����
    void Start()
    {
        spawnZone = new List<BoxCollider>();
        spawnPos = new SetPosition();

        spawnerTimer = spawnDelay;

        Transform[] children = GetComponentsInChildren<Transform>();
        foreach (Transform child in children)
        {
            if(child != children[0] && child != null)
                spawnZone.Add(child.GetComponent<BoxCollider>());
        }
    }

    //���� �κ� **TODO : �ּ� ���� �߱�
    void Update()
    {
        spawnerTimer -= Time.deltaTime;
        if (spawnerTimer < 0)
        {
            spawnPos.GetRandomPos_FixedY(spawnZone);
            if (Random.Range(0, 1f) > normalRatio)
                SpawnEnemy = Instantiate(Enemy[elite], spawnPos.pos, default);
            else
                SpawnEnemy = Instantiate(Enemy[normal], spawnPos.pos, default);
            SpawnEnemy.transform.LookAt(Goalpoint);
            SpawnEnemy.GetComponent<Rigidbody>().AddForce(SpawnEnemy.transform.forward * 200);

            spawnerTimer = spawnDelay;
        }
    }

    //�������� ������ Ŭ����
    private class SetPosition
    {
        public Vector3 pos;
        private static float relativeZ = -1.20f;

        public SetPosition()
        {
            pos = default;
        }

        public void GetRandomPos_FixedY(List<BoxCollider> spawnZone)
        {
            int zoneNum = Random.Range(0, spawnZone.Count - 1);
            Vector3 basePos = spawnZone[zoneNum].transform.position;
            Vector3 size = spawnZone[zoneNum].size;

            float posY = basePos.y;
            float posX = Random.Range(-size.x / 2f, size.x / 2f);
            float posZ = basePos.z + relativeZ * (posX / size.x);
            posX += basePos.x;

            pos = new Vector3(posX, posY, posZ);
        }
    }
}
