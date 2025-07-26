# 🎯 Guess the Number – C# Console Game

A simple and fun number guessing game written in **C#**. The computer randomly selects a number between 1 and 100, and your task is to guess it in as few attempts as possible!

## 🕹️ How to Play

1. The computer picks a random number between 1 and 100.
2. You guess a number.
3. The program tells you if your guess is too low, too high, or correct.
4. Keep guessing until you find the number!
5. At the end, the game tells you how many attempts you made.

---

## 💻 Requirements

- [.NET SDK](https://dotnet.microsoft.com/en-us/download) (**.NET Core 8** or any version supporting `System.Random`)
- A terminal or command prompt

---

## 🚀 Running the Game

1. **Clone the Repository:**

```bash
git clone https://github.com/ebrahim-saber/Guess.git
cd Guess

📂 Project Structure

Guess/
├── Program.cs       // Main game logic
├── Guess.csproj     // Project file
└── README.md        // This file

🧠 Code Summary
The game logic includes:
Random.Next(1, 101) for generating a random number
int.TryParse() for safe input handling
A while loop to keep the game running until the correct guess
An attempt counter to track how many tries you made

🛠️ Example Output
Welcome to the 'Guess the Number' game!
I have selected a number between 1 and 100. Try to guess it!
Enter your guess: 50
Too low! Try again.
Enter your guess: 75
Too high! Try again.
Enter your guess: 68
Congratulations! You guessed the number 68 in 3 attempts.


🙌 Contributions
Feel free to:

Improve the game (add difficulty levels, score tracking, etc.)

Submit issues or suggestions

Fork and extend the project!
