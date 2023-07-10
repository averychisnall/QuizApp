using QuizApp;
using Newtonsoft.Json;


var filePath = "./questions.json";

var fileJsonRaw = File.ReadAllText(filePath);

Question[]? questions = JsonConvert.DeserializeObject<Question[]>(fileJsonRaw);

if (questions == null)
{
    Environment.Exit(1);
}
Quiz quiz = new Quiz(questions);

for ( int i = 0; i < questions.Length; i++)
{
    quiz.NextQuestion();
}
Console.WriteLine("Number of correct answers: {0}", quiz.CorrectAnswers);
