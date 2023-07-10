# Quiz App

The Quiz App is a simple console application written in C# that allows users to take a quiz on a specific topic. It presents multiple-choice questions and provides immediate feedback on the user's answers. This README file explains how the Quiz App works and how to use it.

## How It Works

1. The quiz questions and answers are stored in a JSON file in the following format:

   ```json
   [
     {
       "QuestionText": "Question 1",
       "Options": ["Option 1", "Option 2", "Option 3", "Option 4"],
       "AnswerIndex": 0
     },
     {
       "QuestionText": "Question 2",
       "Options": ["Option 1", "Option 2", "Option 3", "Option 4"],
       "AnswerIndex": 1
     },
     ...
   ]
   ```

Each question has a question text, an array of options, and the index of the correct answer within the options array.

1. When the Quiz App is executed, it reads the questions from the JSON file and presents them to the user one by one.

2. For each question, the user is prompted with the question text and the available options. They can choose an option by entering the corresponding number.

3. After the user selects an option, the Quiz App checks if it matches the correct answer. It then displays whether the answer was correct or incorrect and updates the user's score.

4. The Quiz App proceeds to the next question and repeats the process until all questions have been answered.

5. Finally, the Quiz App displays the user's final score and provides feedback on their performance.

## Getting Started

To run the Quiz App on your local machine, follow these steps:

1. Clone this repository to your local machine or download the source code.

2. Make sure you have [.NET Core](https://dotnet.microsoft.com/download) installed.

3. Open a terminal or command prompt and navigate to the project directory.

4. Build the project by running the following command:

   ```shell
   dotnet build
   dotnet run
   ```

5. The quiz app will now start, and you can enjoy taking the quiz!

## Customizing the Quiz

You can customize the quiz questions by modifying the JSON file located in the `./questions.json` file. Simply edit the question text, options, and answer index to create your own quiz.

## Contributing

Contributions to the Quiz App are welcome! If you have any suggestions, bug reports, or improvements, please open an issue or submit a pull request. Let's make the Quiz App even better together!

## License

This project is licensed under the [MIT License](LICENSE).
