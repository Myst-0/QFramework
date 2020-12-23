using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
#if UNITY_EDITOR
using UnityEditor;
#endif
namespace QFramework
{
    public class ExportUnityPackage
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/4.导出UnityPackage")]

        private static void MenuClicked()
        {
            string assetPathName = "Assets/QFramework";
            string fileName = "QFramework_" + DateTime.Now.ToString("yyyyMMdd_HH") + ".unitypackage";
            AssetDatabase.ExportPackage(assetPathName,fileName,ExportPackageOptions.Recurse);
        }
#endif
    }

}