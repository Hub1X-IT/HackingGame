using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Script for testing whatever is needed
  
    private void Awake()
    {

    }

    private void Update()
    {

    }

    private void TestTextCompressor()
    {
        // TextCompressor.InitializeTextCompressor();
        string uncompressedText = "123487917209 90812374908 172389064612740980 580921384 11";
        string compressedText = TextCompressor.GetCompressedText(uncompressedText);
        TextCompressor.TryGetDecompressedText(compressedText, out string decompressedText);
        Debug.Log(uncompressedText);
        Debug.Log(compressedText);
        Debug.Log(decompressedText);

        string compressedText2 = TextCompressor.GetCompressedText(uncompressedText);
        Debug.Log(compressedText2);
    }
}
