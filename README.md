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

Game Systems
- Data Handler class
> The base class for all data handlers. Data handlers methods receive or send information to the current saveData class, using that data and setting values at runtime.

- GamePause
> Controls the pausing of the game and handles the active state of the canvases. 

- KeyDataHandler class
> A singleton handling key information in a game where you collect keys in levels to open a door in a hub scene.

- LevelSelectionUnlock class 
> Iterate through the collected keys and makes the equivalent button interactable.

- MainMenu class
> Entails functionality for the Main Menu. 
> Changes the Start game button onClick event depending on the values in the keyDataHandler singleton.

- SaveAndLoad class
> Saves and Loads information from and to a JSON file. 