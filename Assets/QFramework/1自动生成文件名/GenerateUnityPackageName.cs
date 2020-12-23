using System;
#if UNITY_EDITOR
using UnityEditor;
# endif
using UnityEngine;
namespace QFramework
{
    public class GenerateUnityPackageName 
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/1.生成 UnityPackage 名字")]
#endif
        private static void MenuClicked()
        {
            Debug.Log("QFramework_" + DateTime.Now.ToString("yyyyMMdd_HH"));
        }
    } 
}
