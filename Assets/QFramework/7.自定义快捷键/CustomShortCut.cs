using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
namespace QFramework
{
    public class CustomShortCut
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/7.自定义快捷键 %e")]
        private static void MenuClicked()
        {
            EditorApplication.ExecuteMenuItem("QFramework/6.MenuItem复用");
        }
#endif
    }
}
