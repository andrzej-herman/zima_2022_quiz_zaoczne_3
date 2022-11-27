using Quiz;


// tworzymy obiekt typu Game
var game = new Game();

// tworzymy obiekt typu Message
var message = new Message();

// wyświetlamy ekran powitalny
message.DisplayWelcomeScreen();

// losujemy pytanie z aktualnej kategorii
game.GetRandomQuestionFromCurrentCategory();

// wyświetlanie pytania
game.CurrentQuestion.Display();
















