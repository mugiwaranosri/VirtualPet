# Overview

This is a console application built in C# that simulates caring for a virtual pet. The application demonstrates fundamental programming concepts such as basic program structure, console I/O, data types, type conversion, and control flow elements.

## Features

1. **Pet Creation:**

    - Allow the user to choose a pet type (e.g., cat, dog, rabbit) and give it a name.
    
    - Display a welcome message that includes the pet's type and name.

2. **Pet Care Actions:**

    - **Feeding:** Decreases hunger, slightly increases health.
    
    - **Playing:** Increases happiness, slightly increases hunger.
    
    - **Resting:** Improves health, decreases happiness slightly.
    
    - Each action modifies the pet's stats accordingly and displays a message describing the action's effect.

3. **Pet Status Monitoring:**

    - Track and display pet’s stats: hunger, happiness, and health, each on a scale of 1 to 10.
    
    - Implement a status check that warns the user if any stat is critically low or high.

4. **Time-Based Changes:**

    - Simulating the passage of time, where each action represents the passing of an hour.
    
    - Hunger increases over time, and happiness decreases slightly, prompting regular interaction.

5. **Enhanced Interaction Logic:**

    - Implementing consequences for neglect, such as health deterioration if the pet is too hungry or unhappy.
    
    - Including special messages or events based on the pet's status like the pet refusing to play if too hungry).

6. **User Interface and Experience:**

    - Develop a simple, clear, and user-friendly console interface.
    
    - Include instructions for the user on how to interact with the application

## Getting Started

### Prerequisites

- .NET SDK
- Visual Studio or Visual Studio Code

### Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/yourusername/virtual-pet.git
    ```

2. Navigate to the project directory:
    ```sh
    cd virtual-pet
    ```

### Running the Application

1. Open the project in Visual Studio or Visual Studio Code.

2. Build the project:
    ```sh
    dotnet build
    ```

3. Run the project:
    ```sh
    dotnet run
    ```

## Usage

1. On starting the application, you will be prompted to choose a pet type and name your pet.

2. You can perform actions like feeding, playing, and resting to care for your pet.

3. Check the pet's status to see its hunger, happiness, and health levels.

4. The passage of time is simulated with each action, affecting the pet's stats over time.

5. Dont let health or happiness to reduce too much so that some of the pet actions are restricted 

## Example
```
Welcome to the Virtual Pet game!
Choose a pet type (e.g., cat, dog, rabbit): dog
Enter your pet's name: Buddy
Welcome, Buddy the dog!
Choose an action: feed, play, rest, status, exit
> feed
Buddy has been fed. Hunger: 3, Health: 6
Hours passed: 1
Buddy's health remains stable. Health: 6
Status of Buddy: Hunger: 3, Happiness: 4, Health: 6
Choose an action: feed, play, rest, status, exit
> exit
Thank you for playing!
```

### Commits

Initial commit

Create Pet.cs

Additional functions given to pet class

Program class is created and error in pet class is solved

Update Pet.cs

Update Pet.cs

Update Program.cs

Update Program.cs

Update Program.cs

Update Pet.cs

Update Program.cs

Final VirtualPet Console

Play restricted when too hungry

Time Passage is simulated

TimePasses modifications

Implementing Final methods and conditions if happiness or hunger has extreme end value

Profile URL:
https://github.com/mugiwaranosri
