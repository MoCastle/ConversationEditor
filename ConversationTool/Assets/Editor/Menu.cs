using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Menu:EditorWindow {
    [MenuItem("EditorTool/ConversationEditor")]
    static public void init()
    {
        GetWindow(typeof(ToolEditorWindow), false, "ToolEditorWindow");
    }
}
