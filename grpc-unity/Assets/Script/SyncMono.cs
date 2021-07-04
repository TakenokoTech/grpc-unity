using System.Linq;
using UnityEngine;
using Random = System.Random;

namespace Script
{
    public class SyncMono : MonoBehaviour
    {
        [SerializeField] private GameObject botObj;
        [SerializeField] private GameObject syncObj;
        [SerializeField] private string botName;
        [SerializeField] private string syncName;
        [SerializeField] private int count;
        [SerializeField] private Vector3 offset;

        private void Start()
        {
            foreach (var index in Enumerable.Range(1, count))
            {
                var a = Instantiate(botObj);
                a.transform.parent = transform;
                a.transform.localPosition = new Vector3(
                    (float) (new Random().NextDouble() - 0.5F) * 3,
                    0,
                    (float) (new Random().NextDouble() - 0.5F) * 3
                );
                a.GetComponent<PlayerMoveService>().objUuid = botName + index;
                a.GetComponent<AccMono>().accX = (float) new Random().NextDouble();
                a.GetComponent<AccMono>().accZ = (float) new Random().NextDouble();
            }
            
            foreach (var index in Enumerable.Range(1, count))
            {
                var a = Instantiate(syncObj);
                a.transform.parent = transform;
                a.transform.localPosition = new Vector3(
                    (float) (new Random().NextDouble() - 0.5F) * 3,
                    0,
                    (float) (new Random().NextDouble() - 0.5F) * 3
                );
                a.GetComponent<PlayerChangedService>().objUuid = syncName + index;
                a.GetComponent<PlayerChangedService>().offset = offset;
            }
        }
    }
}
