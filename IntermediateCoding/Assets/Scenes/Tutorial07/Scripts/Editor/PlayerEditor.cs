using UnityEditor;

namespace Scenes.Tutorial07.Scripts.Editor {
    [CustomEditor(typeof(Player))]
    public class PlayerEditor : UnityEditor.Editor {
        public override void OnInspectorGUI() {

            //base.OnInspectorGUI();
            var player = (Player) target;
            player.speed = EditorGUILayout.Slider("player speed" , player.speed, 0 , 10f);
        }
    }
}