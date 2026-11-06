# Unity Multiplayer Framework

UnityMultiplayerFramework is a Unity project for developing a reusable multiplayer framework.
The repository currently contains the initial Universal Render Pipeline project; multiplayer features have not yet been implemented.

## Requirements

- Unity Editor **6000.6.8f1** (see `ProjectSettings/ProjectVersion.txt`)
- Unity Hub
- Git

## Getting started

1. Clone this repository.
2. In Unity Hub, select **Add > Add project from disk** and choose the repository folder.
3. Open with Unity 6000.6.8f1 and wait for package resolution and asset import.
4. Open `Assets/Scenes/SampleScene.unity` and enter Play mode.

## Version control

Commit `Assets` (including all `.meta` files), `Packages`, and `ProjectSettings`.
Generated caches, IDE solutions, logs, build outputs, and local user settings are ignored.
Unity uses **Visible Meta Files** and **Force Text** serialization.

The default branch is `main`. For changes, create a branch, commit, and push it:

```sh
git switch -c feature/my-change
git add .
git commit -m "Describe the change"
git push -u origin feature/my-change
```
