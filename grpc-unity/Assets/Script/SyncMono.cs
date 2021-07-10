using System;
using System.Collections.Generic;
using System.Linq;
using Script.utils;
using UnityEngine;
using Random = System.Random;

namespace Script
{
    public class SyncMono : MonoBehaviour
    {
        [SerializeField] private GameObject botObj = null;
        [SerializeField] private GameObject syncObj = null;
        [SerializeField] private string botName = "";
        [SerializeField] private string syncName = "";
        [SerializeField] private int count = 0;
        [SerializeField] private Vector3 offset = Vector3.zero;

        private List<GameObject> botList = new List<GameObject>();
        private List<GameObject> syncList = new List<GameObject>();

        private void Start()
        {
            foreach (var index in Enumerable.Range(1, count)) botList.Add(CreateBot(index));
            foreach (var index in Enumerable.Range(1, count)) syncList.Add(CreateSync(index));
        }

        private void Update()
        {
            while (botList.Count < count) botList.Add(CreateBot(botList.Count+1));
            while (botList.Count > count)
            {
                this.RunCatching(it => Destroy(botList[botList.Count - 1].gameObject));
                botList.RemoveAt(botList.Count-1);
            }
            
            while (syncList.Count < count) syncList.Add(CreateSync(syncList.Count+1));
            while (syncList.Count > count) {
                this.RunCatching(it => Destroy(syncList[syncList.Count-1].gameObject));
                syncList.RemoveAt(syncList.Count-1);
            }
            
            botList.Foreach(it =>
            {
                var outX = Math.Abs(it.transform.position.x) > 100;
                var outY = Math.Abs(it.transform.position.y) > 100;
                var outZ = Math.Abs(it.transform.position.z) > 100;
                if (outX || outY || outZ)
                {
                    it.transform.localPosition = new Vector3(Rand(), 0, Rand());
                    it.GetComponent<AccMono>().limitSpeed -= 0.5F;
                    Debug.LogFormat("Fixed limitSpeed: {0}", it.GetComponent<AccMono>().limitSpeed);
                }
            });
        }

        private GameObject CreateBot(int index)
        {
            var obj = Instantiate(botObj);
            obj.transform.parent = transform;
            obj.transform.localPosition = new Vector3(Rand(), 0, Rand());
            obj.name = "[BOT]" + botName + index;
            obj.GetComponent<PlayerMoveService>().objUuid = botName + index;
            obj.GetComponent<AccMono>().acc = (float) new Random().NextDouble();
            return obj;
        }

        private GameObject CreateSync(int index)
        {
            var obj = Instantiate(syncObj);
            obj.transform.parent = transform;
            obj.transform.localPosition = new Vector3(0, 0, 0);
            obj.name = "[SYNC]" + syncName + index;
            obj.GetComponent<PlayerChangedService>().objUuid = syncName + index;
            obj.GetComponent<PlayerChangedService>().offset = offset;
            return obj;
        }

        private static float Rand() => (float) (new Random().NextDouble() - 0.5F) * 5;
    }
}