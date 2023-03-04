// Written by Kevin Catlett.

using UnityEngine;

/// <summary>
/// Transitions between two audioClips by changing the volumes of audioSources in a duration.
/// The transition is activated by calling the ChangeSound method. 
/// </summary>
public class AudioTransitioner : MonoBehaviour
{
   [Header("Audiosources")]
   
   [Tooltip("The audiosource from which the music is played from.")]
   // The audiosource from which the music is played from.
   [SerializeField] AudioSource musicSource;
   
   [Tooltip("The audiosource from which the dialogue is played from.")]
   // The audiosource from which the dialogue is played from.
   [SerializeField] AudioSource dialogueSource;
   

   [Header("Volume settings")]
   
   [Tooltip("The maximum volume of the music.")]
   // The maximum volume of the music 
   [SerializeField] float maxMusicVolume;
   
   [Tooltip("The maximum volume of the dialogue.")]
   // The maximum volume of the dialogue.
   [SerializeField] float maxDialogue;
   
   [Tooltip("The speed in which the sound files volumes rise and fall.")]
   // The speed in which the sound files volumes rise and fall.
   [SerializeField] float transitionSpeed;
   
   
   [Header("Sound state")]
   
   [Tooltip("Is the music on first or is the dialogue on first.")]
   [SerializeField] bool musicActive;

   #region Methods
   /// <summary>
   /// Gets called when the scene is first loaded.
   /// Sets the volumes of the audioSources.
   /// </summary>
   void Awake()
   {
      if (musicActive)
      {
         musicSource.volume = 1;
         dialogueSource.volume = 0;
      }
      else
      {
         musicSource.volume = 0;
         dialogueSource.volume = 1;
      }
   }

   /// <summary>
   /// Gets called once every frame.
   /// Calls the Transitioning method. 
   /// </summary>
   void Update()
   {
      Transitioning();
   }

   /// <summary>
   /// Handles transitioning from music to dialogue and vice versa when the musicActive boolean changes. 
   /// </summary>
   void Transitioning()
   {
      if (musicActive)
      {
         if (musicSource.volume < maxMusicVolume)
         {
            musicSource.volume += Time.deltaTime * transitionSpeed;
         }

         if (dialogueSource.volume > 0)
         {
            dialogueSource.volume -= Time.deltaTime * transitionSpeed;
         }
      }

      else if (!musicActive)
      {
         if (musicSource.volume > 0)
         {
            musicSource.volume -= Time.deltaTime * transitionSpeed;
         }

         if (dialogueSource.volume < maxDialogue)
         {
            dialogueSource.volume += Time.deltaTime * transitionSpeed;
         }
      }
   }

   /// <summary>
   /// Changes the sound depending on which sound is currently active. Used by the button. 
   /// </summary>
   public void ChangeSound()
   {
      musicActive = !musicActive;
   }
   #endregion
   
}
