# my_portfolio
 This repository entails projects and code examples I developed that showcase my abilities in games programming.

This is a list of the C# files that can be found here:

Audio Implementation 
- AudioTransitioner class
> Transitions between two audioClips by changing the volumes of audioSources in a duration.

- GameMusic class
> A base class for music gameObjects. Destroys itself once the scene changes to a scene where it should not exist in.

- SoundDataHandler class
> A singleton handling sound. Deriving from the DataHandler class allows communication with the games save system. 
> Uses a Audio Mixer to manage volumes and save/load volumes at runtime.

- OptionsMenu class
> Funtionality for the options menu.
> Functionality for audio management.
> Receives and sends data from and to sliders, regulating volumes of audio mixer groups and setting the values on the sliders. 