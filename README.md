# Prototype
The kart racing game was built into a .exe for easy viewing. This version uses a pre-trained AI as training in real-time can be time consuming. To run it, open `Karts.exe`.

After opening the application, these keybinds can be used:
```
W – Forward 
A – Left 
D – Right 
C – Change camera perspective
Alt + F4 – Close application
```

# Setting up Development Environment
In order to view the machine-learning/training process, the project must be opened in the Unity editor. Before doing this, a few pre-requisites must be completed:

### Step 1: Downloading MLAgents
This project was created using [MLAgents version 8](https://github.com/Unity-Technologies/ml-agents/releases/tag/release_8).
After downloading MLAgents, extract the folder `ml-agents-release_8` to any location, remember the path for later.

### Step 2: Python Environment Setup
Firstly, Python must be installed. To do this, download [Conda](https://docs.conda.io/en/latest/).
After Conda is installed, open Anaconda Navigator and find the `Create` button.

![img1](https://raw.githubusercontent.com/aarengibson/FYP-ML-AGENTS/refs/heads/main/Pics/1.png)

![img2](https://raw.githubusercontent.com/aarengibson/FYP-ML-AGENTS/refs/heads/main/Pics/2.png)

The window above will be displayed, select `Python 3.7.13` and give the environment a name.

![img3](https://raw.githubusercontent.com/aarengibson/FYP-ML-AGENTS/refs/heads/main/Pics/3.png)

After that, open the environment in the Terminal and, use the following commands to install the required libraries. Replace `<path to downloaded ml-agents-release_8 folder>` with the path to the folder from in step 1.
```cmd
cd <path to downloaded ml-agents-release_8 folder>
pip install -e ml-agents
pip install -e ml-agents-envs
pip3 install torch~=1.7.1 -f https://download.pytorch.org/whl/torch_stable.html
pip3 install --upgrade protobuf==3.20.0
```

### Step 3: Unity Project Setup
Download the [Unity Hub](https://unity3d.com/get-unity/download). After that open it and navigate to the projects pane.
 
![img4](https://raw.githubusercontent.com/aarengibson/FYP-ML-AGENTS/refs/heads/main/Pics/4.png)

Once on this page, select `Open` and then select the included `Karts` project folder. Unity Hub may then prompt you to install `Unity 2019.4..40f1`, follow the on screen instructions to install this version of the engine. After that, open the project by clicking on it.

### Step 4: Start Training Process
In order to start the machine learning training process, go back to the Conda terminal and run this command: 

```mlagents-learn <path to karts project folder>\KartAgent.yaml --force```

(Replace `<path to karts project folder>` with the path to the Karts project folder)
 
### Step 5: Start the Simulation
Open Unity and select the World scene by clicking on it, once the World scene is open, run the scenario by pressing the `play` button.

![img5](https://raw.githubusercontent.com/aarengibson/FYP-ML-AGENTS/refs/heads/main/Pics/5.png)
 
The AI are now learning using machine learning. In order to stop the scenario, click on the `play` button again. 

![img6](https://raw.githubusercontent.com/aarengibson/FYP-ML-AGENTS/refs/heads/main/Pics/6.png)

Once the learning has been stopped, a Neural Network File will be produced at this directory:

```<path to downloaded ml-agents-release_8 folder>\results\ppo\KartAgent```

Using the `.NN` file, a completed simulation can be built by attaching it to the agent.