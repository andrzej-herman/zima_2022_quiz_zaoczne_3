using Quiz;
using System.Security.Cryptography;


// tworzymy obiekt typu Game
var game = new Game();

// tworzymy obiekt typu Message
var message = new Message();

// wyświetlamy ekran powitalny
message.DisplayWelcomeScreen();

// gra się toczy w pętli, którą przerywamy w dwóch przypadkach
// jak się skonczą kategorię
// i kiedy gracz odpowie źle

while(true)
{
    // losujemy pytanie z aktualnej kategorii
    game.GetRandomQuestionFromCurrentCategory();

    // wyświetlanie pytania i pobranie odpowiedzi gracza
    var playerAnswer = game.CurrentQuestion.Display();

    // sprawdzamy poprawność odpowiedzi gracza
    var correct = game.CheckPlayerAnswer(playerAnswer);

    // budujemy logikę aplikacji w zalezności od poprawności odpowiedzi
    if (correct)
    {
        if (game.IsLastQuestion())
        {
            message.FinalScreen();
            break;
        }
        else
        {
            message.GoodAnswer();
        }
    }
    else
    {
        message.DisplayLooseAndGameOver();
        break;
    }
}






















