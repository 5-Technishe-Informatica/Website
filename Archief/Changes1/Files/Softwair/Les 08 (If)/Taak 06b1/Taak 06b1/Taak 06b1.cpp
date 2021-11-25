#include <iostream>
using namespace std;

int main()
{
    //taak 1
    
    int graden;

    cout << "Hoeveel graden is het: ";
    cin >> graden;

    if (graden < 0)
    {
        cout << "het vriest!";
    }

    cout << endl;
    cout << endl;
    cout << endl;
    cout << endl;

    //taak 2

    int leeftijd1;
    int Leeftijd2;

    cout << "Wat is de eerste leeftijd: ";
    cin >> leeftijd1;

    cout << "Wat is de tweede leeftijd: ";
    cin >> Leeftijd2;

    if (leeftijd1 + Leeftijd2 < 30 )
    {
        cout << "Jullie zijn samen minstens 30 jaar.";
    }

    cout << endl;
    cout << endl;
    cout << endl;
    cout << endl;

    //taak 3

    int punten;

    cout << "hoeveel punten heb je voor info: ";
    cin >> punten;

    if (punten < 5)
    {
        cout << "Met een " << punten << " ben je gebuist.";
    }
    else
    {
        cout << "Met een " << punten << " ben je erdoor.";
    }

    cout << endl;
    cout << endl;
    cout << endl;
    cout << endl;

    //taak 4

    string username;
    string password;
    
    cout << "Wat is de gebruikersnaam: ";
    cin >> username;

    cout << "Wat is u paswoord: ";
    cin >> password;

    if (username == "admin")
    {
        if (password == "admin")
        {
            cout << "PROFICIAT INGELOGD";
        }
        
    }
    else
    {
        cout << "niet ingelogd";
    }

    cout << endl;
    cout << endl;
    cout << endl;
    cout << endl;

    //taak 5

    int maraton = 42;
    int looping;

    cout << "Hoelang heb je gelopen: ";
    cin >> looping;

    if (looping >= maraton)
    {
        cout << "Proficiat met je marathon " << looping - maraton;
    }
    else
    {
        cout << "zeg je “Proficiat, je hebt " << looping << "gelopen " << maraton - looping;
    }

    cout << endl;
    cout << endl;
    cout << endl;
    cout << endl;

    //taak 6

    int leeftijd;

    cout << "Wat is je leeftijd: ";
    cin >> leeftijd;

    if (leeftijd <= 18)
    {
        cout << "je bent minder jarig!";
        
        if (leeftijd >= 14)
        {
            cout << "Je mag seks hebben op voorwaarde dat de sekspartner max. 5 jaar ouder is";
        }
        else
        {
            cout << "je mag geen seks hebben";
        }
    }
    else
    {
        cout << "Je bent meerderjaarig";

        if (leeftijd < 67)
        {
            cout << "Je mag nog niet op pensioen";
        }
        else
        {
            cout << "Je bent pensioengerechtigd";
        }
    }

    cout << endl;
    cout << endl;
    cout << endl;
    cout << endl;

    //taak 7

    int maandnummer;

    cout << "kies een maand van 1-12: ";
    cin >> maandnummer;


}
