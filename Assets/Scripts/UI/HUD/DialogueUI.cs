using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueUI : MonoBehaviour
{
    [SerializeField]
    private GameObject dialogueUI;

    [SerializeField]
    private Image characterImage;

    [SerializeField]
    private TMP_Text dialogueNameTextField;

    [SerializeField]
    private TMP_Text dialogueSentenceTextField;

    [SerializeField]
    private AudioSource dialogueAudioSource;

    private void Awake()
    {
        DialogueManager.NewDialogueSentenceStarted += ShowDialogue;
        DialogueManager.DialogueEnded += HideDialogue;
        HideDialogue();
    }

    private void ShowDialogue(DialogueManager.DialogueSentence dialogueStatement)
    {
        characterImage.sprite = dialogueStatement.Character.CharacterImage;
        dialogueNameTextField.text = dialogueStatement.Character.CharacterName;
        dialogueSentenceTextField.text = dialogueStatement.Sentence;
        dialogueUI.SetActive(true);

        dialogueAudioSource.clip = dialogueStatement.SentenceAudioClip;
        dialogueAudioSource.Play();
    }

    private void HideDialogue()
    {
        dialogueUI.SetActive(false);
    }
}