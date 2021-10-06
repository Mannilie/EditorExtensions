using UnityEditor;
namespace ComputationLabs.Common
{
    [InitializeOnLoad]
    public static class EditorTime
    {
        public static float deltaTime = 0f;
        private static float lastTimeSinceStartup = 0f;
        static EditorTime()
        {
            EditorApplication.update -= Update;
            EditorApplication.update += Update;
        }
        public static void Update()
        {
            if (lastTimeSinceStartup == 0f)
                lastTimeSinceStartup = (float)EditorApplication.timeSinceStartup;
            deltaTime = (float)EditorApplication.timeSinceStartup - lastTimeSinceStartup;
            lastTimeSinceStartup = (float)EditorApplication.timeSinceStartup;
        }
    }
}