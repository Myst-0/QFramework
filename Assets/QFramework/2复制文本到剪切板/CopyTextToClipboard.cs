#if UNITY_EDITOR
using UnityEditor;
# endif
using UnityEngine;

namespace QFramework
{
    public class CopyTextToClipboard
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/2.复制文本到剪切板")]

        private static void MenuClicked()
        {
            GUIUtility.systemCopyBuffer = "复制的文本";
        }
#endif
    }
}
