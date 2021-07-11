using System.Collections;
using UnityEngine;

namespace Script.utils
{
    public static class EnumeratorExtension
    {
        public static IEnumerator Execute(this IEnumerator source, MonoBehaviour mono)
        {
            mono.StartCoroutine(source);
            return source;
        }
    }
}

