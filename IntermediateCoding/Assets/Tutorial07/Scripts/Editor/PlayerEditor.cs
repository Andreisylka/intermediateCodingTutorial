using UnityEditor;
using Tutorial07;

namespace Tutorial07.Editor {
    [CustomEditor(typeof(Player))]
    public class PlayerEditor : UnityEditor.Editor {
        public override void OnInspectorGUI() {

            //base.OnInspectorGUI();
            var player = (Player) target;
            player.speed = EditorGUILayout.FloatField("player speed" , player.speed);
        }
    }
}