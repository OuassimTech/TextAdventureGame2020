using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class MyAdvanture : MonoBehaviour
{

    private enum States
    {
        start,
        into1,
        intro2,
        delen,
        deelja,
        deelnee,
        leukgesprek,
        deeltadres,
        nacht,
        checksloten,
        bed,
        glas,
        slapen,
        checkglas,
        wegrennen,
        deur,
        raam,
        vechten,
        vechten2,
        vechten3,
        buren,
        buren2,
        dader,
        dader2,
        volgendedag,
        finish
    }

    private States currentState = States.start;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome bij HorrorNite");
        Terminal.WriteLine("Dit is gebaseerd op een waargebeurd verhaal");
        Terminal.WriteLine("Typ start om te beginnen");
    }

    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Het was een koude, donkere nacht.");
        Terminal.WriteLine("Een goede nacht om Fortnite te spelen.");
        Terminal.WriteLine("Typ verder om verder te gaan.");
    }

    void StartIntro2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je start de game op en joined een duo's game.");
        Terminal.WriteLine("Je begint de game te spelen met een random persoon.");
        Terminal.WriteLine("Typ verder om verder te gaan.");
    }
    void StartDelen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Hij vraagt of die jouw kan toevoegen op discord om vaker samen te spelen.");
        Terminal.WriteLine("Als je je gegevens wilt delen typ je ja en als je dat niet wilt typ je nee.");
    }
    void StartDeelja()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Jij zegt dat je dat wel wilt en hij stuurt je een vriendschaps verzoek op Discord.");
        Terminal.WriteLine("Jij accepteert het.");
        Terminal.WriteLine("Typ verder om verder te gaan.");
    }
    void StartDeelnee()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Jij zegt dat je liever niet accepteerd van iemand die je net hebt ontmoet.");
        Terminal.WriteLine("Je krijgt toch een vriendschaps verzoek van hem binnen.");
        Terminal.WriteLine("Jij accepteerd het omdat je hem niet wilt laten hangen.");
        Terminal.WriteLine("Typ verder om verder te gaan.");
    }
    void StartLeukgesprek()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Jullie hebben een leuk gesprek terwijl jullile aan het spelen zijn.");
        Terminal.WriteLine("Je vindt dat hij een aardig persoon is.");
        Terminal.WriteLine("Typ verder om verder te gaan.");
    }
    void StartDeeltadres()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Hij zegt dat die pizza gaat bestellen en of jij ook wilt.");
        Terminal.WriteLine("Je zegt dat je well zin hebt in pizza.");
        Terminal.WriteLine("Hij vraagt je om je adress en jij deelt het zonder erbij na te denken.");
        Terminal.WriteLine("Typ verder om verder te gaan.");
    }
    void StartNacht()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Het is all een paar uur verder en jillie zitten nogsteeds te spelen.");
        Terminal.WriteLine("De pizza is er nog steeds niet dus jij vraagt hem waar het blijft.");
        Terminal.WriteLine("Hij zegt dat hij het was vergeten te doen.");
        Terminal.WriteLine("Je zegt dat het ok is.");
        Terminal.WriteLine("Je ziet dat het laat, is dus je zegt fijne avond tegen hem en gaat van de computer af.");
        Terminal.WriteLine("Typ check sloten om de sloten te checken en typ bed om naar bed te gaan.");
    }
    void StartChecksloten()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je gaat naar beneden om te checken of de voor en achter deur dicht zijn.");
        Terminal.WriteLine("Je komt erachter dat de achter deur niet op slot is.");
        Terminal.WriteLine("Je doet hem op slot en gaat naar bed.");
        Terminal.WriteLine("Typ verder om verder te gaan.");
    }
    void StartBed()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je kleed je om en gaat naar bed.");
        Terminal.WriteLine("Je gaat in bed liggen en sluit je ogen.");
        Terminal.WriteLine("Typ verder om verder te gaan.");
    }
    void StartGlas()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hoort opeens iets dat klinkt als glas dat breekt.");
        Terminal.WriteLine("Je denkt bij jezelf dat het mischien gewoon wind is die een glas heeft omgegooid.");
        Terminal.WriteLine("Als je wilt kijken wat er is gebeurd typ checken en als je wilt blijven slapen typ je slapen.");
    } 
    void StartSlapen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je blijft in bed ligen en even later ben je aan het slapen.");
        Terminal.WriteLine("AAAAHHHH!");
        Terminal.WriteLine("Je wordt opeens waker met een erge pijn in je buik.");
        Terminal.WriteLine("Waneer je je ogen open doet zie je een man met een mes in zijn hand.");
        Terminal.WriteLine("Het laatste dat je ziet is het mes dat naar je hoofd gaat.");
        Terminal.WriteLine("Typ restart om terug naar het begin te gaan.");
    }
    void StartCheckglas()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je staat op uit bed en gaat naar beneden om te kijken wat er is gebeurd.");
        Terminal.WriteLine("Je gaat eerst naar de keuken, maar ziet niks kapot.");
        Terminal.WriteLine("Opeens zie je door de reflectie van het raam iemand achter je met een mes.");
        Terminal.WriteLine("Typ rennen om weg te rennen of typ vecht om terug te vechten.");
    }
    void StartWegrennen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je rent naar de eet tafel en gooit een stoel naar hem toe.");
        Terminal.WriteLine("Je kunt je alleen twee plekken bedenken om te onsnappen.");
        Terminal.WriteLine("Typ deur om via de deur te onsnappen of typ raam om via het raam te onsnappen.");
    }
    void StartDeur()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je rent naar de deur en pakt de sleutel bos op de kapstok.");
        Terminal.WriteLine("Je probeert snel de goeie sleutel te vinden en waneer je hem eindelijk hebt voel je opeens een erge pijn in je rug.");
        Terminal.WriteLine("Je draait je om en. Hahaha, jij bent zo'n groote sukkel. Je hebt me zo makkelijk je gegevens gegeven.");
        Terminal.WriteLine("Hij haald de mes weg en ik viel op de grond en me ogen sloten een paar seconden later.");
        Terminal.WriteLine("Typ restart om terug te gaan naar het begin.");
    }
    void StartRaam()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je pakte een ander stoel en rende naar de woonkamer.");
        Terminal.WriteLine("*BAM* Je gooit de stoel door de raam en springed er achterna.");
        Terminal.WriteLine("Je krijgt een paar glas scherven in je bloten voeten, maar je blijft door rennen.");
        Terminal.WriteLine("Typ verder om verder te gaan.");
    }
    void StartBuren()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je rent naar de een van je buren die zijn light nog aan heeft.");
        Terminal.WriteLine("Je begint aan te kloppen en bellen.");
        Terminal.WriteLine("Je kijkt achter je en ziet dat de inbreker weg rent.");
        Terminal.WriteLine("Je buurnman opent de deur en je rent naar binnen en doet gelijk de deur dicht.");
        Terminal.WriteLine("Typ verder om verder te gaan.");
    }
    void StartBuren2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je legt uit aan verwarde buurman wat er net is gebeurt.");
        Terminal.WriteLine("Hij pakt zijn telefoon en belt gelijk de politie.");
        Terminal.WriteLine("Een paar minuten later staat de politie bij de deur.");
        Terminal.WriteLine("Je vertelt alles wat er die dag is gebeurd.");
        Terminal.WriteLine("Typ verder om verder te gaan.");
    }
    void StartDader()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Even later krijgen ze een melding dat de dader meschien is opgepakt.");
        Terminal.WriteLine("Na even twijfelen ga jij akoord.");
        Terminal.WriteLine("Je rijdt met de politie mee en even later stoppen jullie vlakbij een ander politie auto.");
        Terminal.WriteLine("Je ziet daar iemand in handboeien.");
        Terminal.WriteLine("Dat is hem! Schreeuw je.");
        Terminal.WriteLine("Typ verder om verder te gaan.");
    }
    void StartDader2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("De dader kijkt jou righting op, maar door de getinte ramen kan hij jou niet zien.");
        Terminal.WriteLine("Ben je honderd procent zeker? Vraagt de politie agent.");
        Terminal.WriteLine("1000 procent. Zeg je.");
        Terminal.WriteLine("Is het ok als we je thuis brengen? vraagt de politie agent.");
        Terminal.WriteLine("Jij knikt ja en de poltie agent brengt je terug naar huis.");
        Terminal.WriteLine("Typ verder om verder te gaan.");
    }
    void StartVolgendedag()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("De dag na de anhouding kwam je erachter dat de inbreker Robert was.");
        Terminal.WriteLine("Robert is de persoon met wie je de hele dag Fortnite zat te spelen.");
        Terminal.WriteLine("Hij bleek dit vaker te hebben gedaan.");
        Terminal.WriteLine("Je moet volgende keer niet weer zomaar je adress aan iemand geven, als niet wilt dat dit weer gebeurt.");
        Terminal.WriteLine("Typ finish om te finishen!");
    }
    void StartFinish()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Gefeliciteerd, je hebt gewonnen!");
        Terminal.WriteLine("Ik hoop dat je genoten hebt van mij Text Adventure Game!");
        Terminal.WriteLine("Als je de andere mogelijkheden wilt proberen, typ dan restart.");
    }
    void StartVechten()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je rent naar de bestek lade en pakt een groot mes.");
        Terminal.WriteLine("Je rent zo ver mogelijk van de inbreker.");
        Terminal.WriteLine("Wie ben jij en wat doe jij hier? vraag jij.");
        Terminal.WriteLine("Hij had een grote glimlach.");
        Terminal.WriteLine("Je weet heel goed wie ik ben. Zij de inbreker.");
        Terminal.WriteLine("Robert!?");
        Terminal.WriteLine("Typ verder om verder te gaan.");
    }
    void StartVechten2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Hij rent naar je toe en probeert je neer te steken.");
        Terminal.WriteLine("Jij ontwijkt de mes en steekt hem in zijn buik.");
        Terminal.WriteLine("Je haalt je mes uit zijn buik en steekt hem nog een keer. En nog een keer. En nog een keer.");
        Terminal.WriteLine("Hij valt op de grond.");
        Terminal.WriteLine("Je laat je mes vallen en je realiseert je wat je hebt gedaan.");
        Terminal.WriteLine("Typ verder om verder te gaan.");
    }
    void StartVechten3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("De inbreker wordt opeens wakker en steekt je in je hart.");
        Terminal.WriteLine("Hahahaha! Dacht je echt dat ik all dood was!");
        Terminal.WriteLine("Jij pakt de mes die je hebt laten vallen en steek hem door zijn keel.");
        Terminal.WriteLine("*THUD* *THUD* Jullie vallen beide dood op de grond.");
        Terminal.WriteLine("Typ restart om opnieuw te beginnen.");
    }



    void OnUserInput(string input)
    {
        if (currentState == States.start)
        {
            if (input == "start")
            {
                currentState = States.into1;
                StartIntro();
            }
            else if (input == "1337")
            {
                Terminal.WriteLine("Jij bent Leet!");
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.into1)
        {
            if (input == "verder")
            {
                currentState = States.intro2;
                StartIntro2();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.intro2)
        {
            if (input == "verder")
            {
                currentState = States.delen;
                StartDelen();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.delen)
        {
            if (input == "ja")
            {
                currentState = States.deelja;
                StartDeelja();
            }
            else if (input == "nee")
            {
                currentState = States.deelnee;
                StartDeelnee();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.deelja)
        {
            if (input == "verder")
            {
                currentState = States.leukgesprek;
                StartLeukgesprek();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.deelnee)
        {
            if (input == "verder")
            {
                currentState = States.leukgesprek;
                StartLeukgesprek();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.leukgesprek)
        {
            if (input == "verder")
            {
                currentState = States.deeltadres;
                StartDeeltadres();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.deeltadres)
        {
            if (input == "verder")
            {
                currentState = States.nacht;
                StartNacht();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.nacht)
        {
            if (input == "check sloten")
            {
                currentState = States.checksloten;
                StartChecksloten();
            }
            else if (input == "bed")
            {
                currentState = States.bed;
                StartBed();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.bed)
        {
            if (input == "verder")
            {
                currentState = States.glas;
                StartGlas();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.checksloten)
        {
            if (input == "verder")
            {
                currentState = States.glas;
                StartGlas();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.glas)
        {
            if (input == "checken")
            {
                currentState = States.checkglas;
                StartCheckglas();
            }
            else if (input == "slapen")
            {
                currentState = States.slapen;
                StartSlapen();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.checkglas)
        {
            if (input == "rennen")
            {
                currentState = States.wegrennen;
                StartWegrennen();
            }
            else if (input == "vecht")
            {
                currentState = States.vechten;
                StartVechten();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.slapen)
        {
            if (input == "restart")
            {
                currentState = States.start;
                ShowMainMenu();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.wegrennen)
        {
            if (input == "deur")
            {
                currentState = States.deur;
                StartDeur();
            }
            else if (input == "raam")
            {
                currentState = States.raam;
                StartRaam();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.deur)
        {
            if (input == "restart")
            {
                currentState = States.start;
                ShowMainMenu();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.raam)
        {
            if (input == "verder")
            {
                currentState = States.buren;
                StartBuren();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.buren)
        {
            if (input == "verder")
            {
                currentState = States.buren2;
                StartBuren2();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.buren2)
        {
            if (input == "verder")
            {
                currentState = States.dader;
                StartDader();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.dader)
        {
            if (input == "verder")
            {
                currentState = States.dader2;
                StartDader2();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.dader2)
        {
            if (input == "verder")
            {
                currentState = States.volgendedag;
                StartVolgendedag();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.volgendedag)
        {
            if (input == "finish")
            {
                currentState = States.finish;
                StartFinish();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.finish)
        {
            if (input == "restart")
            {
                currentState = States.start;
                ShowMainMenu();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.vechten)
        {
            if (input == "verder")
            {
                currentState = States.vechten2;
                StartVechten2();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.vechten2)
        {
            if (input == "verder")
            {
                currentState = States.vechten3;
                StartVechten3();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }
        else if (currentState == States.vechten3)
        {
            if (input == "restart")
            {
                currentState = States.start;
                ShowMainMenu();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer!");
            }
        }




        // Update is called once per frame
        void Update()
        {

        }
    }
}
