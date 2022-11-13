using Quiz;


// tworzymy obiekt typu Game
var game = new Game();

// tworzymy obiekt typu Message
var message = new Message();

// wyświetlamy ekran powitalny
message.DisplayWelcomeScreen();

// losujemy pytanie z aktualnej kategorii
game.GetRandomQuestionFromCurrentCategory();


Console.WriteLine(game.CurrentQuestion.Content);















