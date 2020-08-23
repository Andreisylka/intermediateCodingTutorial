using UnityEditor;

namespace Scenes.Tutorial07.Scripts.Editor {
    [CustomEditor(typeof(Enemy))]
    public class EnemyEditor : UnityEditor.Editor {
        public override void OnInspectorGUI() {
            
            //base.OnInspectorGUI();
            var enemy = (Enemy) target;
             enemy.enemySpeed = EditorGUILayout.Slider("Enemy speed", enemy.enemySpeed, 0, 100);

        }
    }
}