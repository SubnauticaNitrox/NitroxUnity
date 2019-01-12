using System.IO;
using UnityEditor;

namespace Assets.Editor
{
    public class CreateAssetBundles
    {
        [MenuItem("Assets/Build AssetBundles")]
        private static void BuildAllAssetBundles()
        {
            var assetBundleDirectory = "Assets/AssetBundles";
            try
            {
                Directory.Delete(assetBundleDirectory, true);
            }
            catch (IOException)
            {
                //Cleared directory of previous asset build
            }
            Directory.CreateDirectory(assetBundleDirectory);

            BuildPipeline.BuildAssetBundles(assetBundleDirectory, BuildAssetBundleOptions.None,
                BuildTarget.StandaloneWindows);
        }
    }
}