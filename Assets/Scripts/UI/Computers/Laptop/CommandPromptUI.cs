using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CommandPromptUI : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField inputTextField;

    [SerializeField]
    private TMP_Text outputTextField;

    [SerializeField]
    private RectTransform outputField;

    [SerializeField]
    private TextAsset cmdStartText;

    [SerializeField]
    private AudioSource cmdAudioSource;

    /*
    [SerializeField]
    private ScrollRect outputFieldScrollRect;
    */

    private string outputText;

    private const string CommandPromptStartText = ">>> ";
    private const string CommandPromptEndText = "\n";

    private void Awake()
    {
        outputText = string.Empty;
        outputTextField.text = string.Empty;
        inputTextField.text = CommandPromptStartText;

        GameInput.OnCommandSubmitAction += () =>
        {
            string command = inputTextField.text.Remove(0, CommandPromptStartText.Length);
            SubmitCommand(command);
            CommandPromptManager.SubmitCommand(command);
        };

        CommandPromptManager.CommandResponse += (responseString) =>
        {
            SubmitCommand(responseString);
        };

        inputTextField.onSelect.AddListener((_) =>
        {
            inputTextField.caretPosition = inputTextField.text.Length;
        });


        inputTextField.onValueChanged.AddListener((text) =>
        {
            if (text.Length < CommandPromptStartText.Length)
            {
                inputTextField.text = CommandPromptStartText;
                inputTextField.caretPosition = inputTextField.text.Length;
            }

            cmdAudioSource.Play();

            /*
            for (int i = 0; i < CommandPromptStartText.Length; i++)
            {
                if (text[i] != CommandPromptStartText[i])
                {
                    
                }
            }
            */
        });

        //SetStartupText(cmdStartText.text + "\n");
    }

    private void SubmitCommand(string command)
    {
        inputTextField.text = CommandPromptStartText;
        FocusOnInputField();

        //outputText += CommandPromptStartText + command + CommandPromptEndText;
        outputTextField.text = CommandPromptStartText + command;
        //outputTextField.text = outputText;

        Instantiate(outputTextField, outputField);
    }

    private void SetStartupText(string text)
    {
        outputText = text;
        outputTextField.text = outputText;
    }

    public void FocusOnInputField()
    {
        inputTextField.ActivateInputField();
    }
}
