using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
#if UNITY_EDITOR
using UnityEditor;
# endif
namespace QFramework
{
    public class GenerateUnityPackageNameToClipboard : MonoBehaviour
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/3.生成文件名到剪切板")]

        private static void MenuClicked()
        {
            GUIUtility.systemCopyBuffer = "QFramework_" + DateTime.Now.ToString("yyyyMMdd_HH");

        }
#endif
    }
}
