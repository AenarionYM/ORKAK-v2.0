using System;
using static O.R.K.A._Project_ver._2._0.Methods;

namespace O.R.K.A._Project_ver._2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables

            //Konstruktory Klas//
            Menu menu = new Menu();
            Eq eq = new Eq();
            
            //Unlocker'y
            bool dyrkaWBramie = true;
            bool loop = false;
            bool zbyszekRatuje = false;
            bool krukRobotics = false;
            bool wygaslRobotics = false;
            bool gruzjanEkonomiczny = true;
            bool dziurwa = false;
            
            //Achivments
            bool niespostrzezony = false;
            bool segregacja = false;
            
            //Inty
            int toiletEvent = 1;

            #endregion
            
            //Wstęp do gry
            #region Intro

            Methods.Clear();
            Console.WriteLine("Witaj w Project O.R.K.A.!");
            Methods.Sleep(350);
            Console.WriteLine("Jest to gra textowa w której wcielasz się w frajera który chodzi do TEB'u");
            Methods.Sleep(100);
            Console.WriteLine("Pomiędzy lekcjami spierdoliłeś do Ropuszki po Gorącego Psa z extra SSSOOOSSS");
            Methods.Sleep(200);
            Console.WriteLine("Reszte dowiesz się(lub nie) podczas gry.");
            Methods.Sleep(200);
            Console.WriteLine("Miłej zabawy! - Zarząd TEB Studio");
            Methods.Ent();
            Methods.Clear();

            #endregion
            
            //Menu
            #region Menu

            menu:
            menu._Menu();
            string menuChoice = Console.ReadLine();

            if (menuChoice == "1")
            {
                Console.WriteLine("Zapraszam!");
                Methods.Ent();
                goto front;
            }
            else if (menuChoice == "2")
            {
                Console.WriteLine("Zapraszam ponownie!");
                Methods.Ent();
                goto menu;
            }
            else if (menuChoice == "3")
            {
                Console.WriteLine("No raczej nie");
                Methods.Ent();
                goto menu;
            }
            else if (menuChoice == "4")
            {
                Console.WriteLine("No xD");
                Methods.Ent();
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Jak ty głupi");
                Methods.Ent();
                goto menu;            
            }

            #endregion
            
            //Przed budynkiem
            #region Front

            front:
            {
                Methods.Clear();
                Console.WriteLine("Stoisz przed głównym budynkiem Technikum TEB Edukacja w Bielsku");
                Methods.Sleep(500);
                Console.WriteLine("Co robisz?");
                Methods.Sleep(500);
                Console.WriteLine("1. Wchodzisz");
                 Methods.Sleep(500);
                Console.WriteLine("2. Odchodzisz");
                string choiseToEnter = Console.ReadLine();

                 if (choiseToEnter == "1")
                {
                    Console.WriteLine("Oł szit hir łi goł agen");
                    if (dyrkaWBramie == true)
                    {
                         dyrkaWBramie = false;
                         Methods.Ent();
                         Methods.Clear();
                        Console.WriteLine("Wchodzisz do szkoły");
                        Methods.Sleep(1000);
                        goto dyrkaGate;
                     }
                    
                    else
                     {
                        Methods.Ent();
                        Methods.Clear();
                        goto gate;
                     }
                }
             
             else if (choiseToEnter == "2")
             {
                Console.WriteLine("Patrzysz na szkołę"); 
                Methods.Sleep(500);
                Console.WriteLine("*A... Pierdole*");
                Methods.Sleep(500);
                Console.WriteLine("Odchodzisz");
                Methods.Sleep(500);
                Console.Write(".");
                Methods.Sleep(500);
                Console.Write(".");
                Methods.Sleep(500);
                Console.Write(".");
                Environment.Exit(1);
             }
             
             else if (choiseToEnter == "1337")
             {
                 eq.Items.Add(Item.Doors);
                 eq.Items.Add(Item.Desk);
                 eq.Items.Add(Item.BatonOfPower);
                 eq.Items.Add(Item.CrispsOfImmortality);
                 eq.Items.Add(Item.Code);
                 Methods.Clear();
                 eq.ItemsDisplay();
                 goto front;
             }

             else
             {
                 Methods.Els();
                 goto front;
             }
            }
            #endregion
            
            //Dyrka w Bramie
            #region Dyrkak

            dyrkaGate:
            {
                Random achivmentDyrkaWBramie = new Random();
                int _achivmentDyrkaWBramie = achivmentDyrkaWBramie.Next(100);
                
                if (_achivmentDyrkaWBramie < 95)
                {
                    Methods.Sleep(500);
                    Console.WriteLine("Dyrka: A co ty tutaj robisz");
                    Methods.Sleep(500);
                    Console.WriteLine("Ty:yyyy...jaa....ni..");
                    Methods.Sleep(500);
                    Console.WriteLine("Dyrka: Byłeś w Ropuszce.");
                    Methods.Sleep(500);
                    Console.WriteLine("Dyrka: To znaczy nagana");
                    Methods.Sleep(500);
                    Console.WriteLine("A teraz WON na lekcje!!!!");
                    Methods.Sleep(500);
                    Console.WriteLine("TIP: Dostałeś naganę, trzy takowe oznaczają koniec gry.");
                    Methods.Sleep(500);
                    Methods.Rep();
                    Methods.Ent();
                }
                else
                {
                    Console.WriteLine("Zostałeś niespostrzeżony");
                    Methods.Sleep(500);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Achievement Get: Niespostrzeżony");
                    Console.ResetColor();
                    Console.WriteLine(" ");
                    Methods.Ent();
                    niespostrzezony = true;
                    Methods.Clear();
                    Methods.Sleep(500);
                }
            }

            #endregion
            
            //Brama
            #region Gate

            gate:
            {
                Methods.Clear();
                Console.WriteLine("Znajdujesz się w przedsionku");
                Methods.Sleep(500);
                Console.WriteLine("Widzisz dwie drogi");
                Methods.Sleep(500);
                Console.WriteLine("1. Schody na lewo");
                Methods.Sleep(500);
                Console.WriteLine("2. Schody na prawo");
                Methods.Sleep(500);
                Console.WriteLine("3. Wyjście");
                Methods.Sleep(500);
                Console.WriteLine("4. Ekwipunek");

                string choiseGate = Console.ReadLine();
                
                if (choiseGate == "1")
                {
                    Console.WriteLine("Postanawisz wejść po schodach na lewo");
                    Methods.Ent();
                    Methods.Clear();
                    Methods.Sleep(500);
                    goto groundFloor;
                }
                else if (choiseGate == "2" && !eq.Items.Contains(Item.Code))
                {
                    Console.WriteLine("*Zamknięte*");
                    Methods.Sleep(500);
                    Console.WriteLine("Kurwa, dalej niewiem jaki jest ten kod to szatni");
                    Methods.Ent();
                    Methods.Clear();
                    Methods.Sleep(500);
                    goto gate;
                }
                else if (choiseGate == "2" && eq.Items.Contains(Item.Code))
                {
                    Console.WriteLine("*beep*");
                    Methods.Sleep(500);
                    Console.WriteLine("Otwierasz drzwi i schodzisz do Lochów");
                    Methods.Ent();
                    Methods.Clear();
                    Methods.Sleep(500);
                    goto basement;
                }
                else if (choiseGate == "3")
                {
                    Console.WriteLine("Wychodzisz na zewnątrz");
                    Methods.Ent();
                    Methods.Clear();
                    Methods.Sleep(500);
                    goto front;
                }
                else if (choiseGate == "4")
                { 
                    eq.ItemsDisplay();
                    goto gate;
                }
                else
                {
                    Methods.Els();
                    goto gate;
                }
            }

            #endregion
            
            //Korytarz parter
            #region GroundFloor

            groundFloor:
            {
                Methods.Clear();
                Methods.Sleep(500);
                Console.WriteLine("1. Sala 1");
                Methods.Sleep(500);
                Console.WriteLine("2. Siadacze");
                Methods.Sleep(500);
                Console.WriteLine("3. Pokój nauczycielski");
                Methods.Sleep(500);
                Console.WriteLine("4. Kible");
                Methods.Sleep(500);
                Console.WriteLine("5. Sala Fryzjerska");
                Methods.Sleep(500);
                Console.WriteLine("6. Sekretariat");
                Methods.Sleep(500);
                Console.WriteLine("7. Sala Dentystyczna");
                Methods.Sleep(500);
                Console.WriteLine("8. Automat z Kawą");
                Methods.Sleep(500);
                Console.WriteLine("9. Dispenser z wodą");
                Methods.Sleep(500);
                Console.WriteLine("10. Zinwestyguj gaśnice");
                Methods.Sleep(500);
                Console.WriteLine("11. Zawróć");
                Methods.Sleep(500);
                Console.WriteLine("12. Schody na górę");
                Methods.Sleep(500);
                Console.WriteLine("13. Ekwipunek");

                string choiceGround = Console.ReadLine();
                
                //Sala 1
                if (choiceGround == "1")
                {
                    if (!eq.Items.Contains(Item.Jacket))
                    {
                        Methods.Clear();
                        Console.WriteLine("Wchodzisz do Sali 1");
                        Methods.Sleep(500);
                        Console.WriteLine("Przez przypadek wpadasz na Apel");
                        Methods.Sleep(500);
                        Console.WriteLine("Dyrka zauważa cię");
                        Methods.Sleep(500);
                        Console.WriteLine("a kolejno rzecze:");
                        Methods.Sleep(500);
                        Console.WriteLine("Dyrka: Ooo, Akurat miałam ci dać naganę");
                        Methods.Sleep(500);
                        Methods.Rep();
                        goto groundFloor;
                    }
                    
                    else if (eq.Items.Contains(Item.Jacket))
                    {
                        Methods.Clear();
                        Console.WriteLine("Otwierasz drzwi, w środku jest apel");
                        Methods.Sleep(500);
                        Console.WriteLine("Dyrka zauważa cię,");
                        Methods.Sleep(500);
                        Console.WriteLine("ale dzięki kurtce twego 2 metrowego kolegi nie jest w stanie cię rozpoznać");
                        Methods.Sleep(500);
                        Console.WriteLine("korzystając z okazji szybko wychodzisz");
                        Methods.Ent();
                        goto groundFloor;
                    }
                }                
                //Siadacze
                else if (choiceGround == "2")
                {
                        if (!loop)
                        {
                            Console.WriteLine("Wszystkie  siadacze są zajęte");
                            Methods.Ent();
                            goto groundFloor;
                        }
                        else
                        {
                            Console.WriteLine("Siadasz na siadaczu i się regenerujesz");
                            Methods.Sleep(500);
                            Console.WriteLine("*Odnawiasz 25hp*");
                            //display_HP += 25;
                            Methods.Ent();
                            goto groundFloor;
                        }
                }          
                //Pokój nauczycielski
                else if (choiceGround == "3")
                {
                    Methods.Clear();
                    Console.WriteLine("Przez uchylone drzwi widzisz panią Marzenę Brat Zakonny");
                    Methods.Sleep(500);
                    Console.WriteLine("Gdyby tylko dało się ją wywabić");
                    Methods.Sleep(500);
                    Methods.Ent();
                    goto groundFloor;
                }                
                //Kible
                else if (choiceGround == "4")
                {
                    if (toiletEvent == 1)
                    {
                        Methods.Clear();
                        Console.WriteLine("Wkraczasz do toalet prawdziwych męszczyzn");
                        Methods.Sleep(500);
                        Console.WriteLine("Wchodzisz do kabiny by zastanowić się nad sensem swego żałosnego istnienia");
                        Methods.Sleep(500);
                        Console.WriteLine("Nagle słyszysz: *fap**fap**fap*");
                        Methods.Sleep(500);
                        Console.WriteLine("Zaglądzasz przez góre kabiny i widzisz");
                        Methods.Sleep(500);
                        Methods.Sleep(500);
                        Methods.Sleep(500);
                        Console.WriteLine("Pana Kruka");
                        Methods.Sleep(500);
                        Console.WriteLine("Szybko uciekasz by cię nie zauważył");
                        Methods.Sleep(500);
                        Methods.Ent();
                        toiletEvent++;
                        Methods.Clear();
                        goto groundFloor;
                    }
                    
                    else if (toiletEvent == 2 && zbyszekRatuje == false)
                    {
                        Methods.Clear();
                        Console.WriteLine("Wchodzisz do toalet i widzisz Horacego i Bonifacego wciągających Tobake");
                        Methods.Sleep(500);
                        Console.WriteLine("Witasz się z nimi, gdy do toalet wparowuje pan doktor reformowany Bielmar i rzecze:");
                        Methods.Sleep(500);
                        Console.WriteLine("RAZ...DWA...TRZY... kto wciąga tabake ma się przyznać bo inaczej wszyscy dostają po naganie");
                        Methods.Sleep(500);
                        Console.WriteLine("Twoi znajomi wspólnie oskarżyli o to ciebie");
                        Methods.Sleep(500);
                        Methods.Rep();
                        Methods.Ent();
                        toiletEvent++;
                        Methods.Clear();
                        goto groundFloor; 
                        ////////////toiletEvent dalszy nie jest jeszcze zrobiony z powodu niechęci do zrobienia jego////////////////
                    }
                    
                    else if (toiletEvent == 2 && zbyszekRatuje == true)
                    {
                        Console.WriteLine("Wchodzisz do toalet i widzisz Horacego i Bonifacego wciągających Tobake");
                        Methods.Sleep(500);
                        Console.WriteLine("Witasz się z nimi, gdy do toalet wparowuje pan doktor reformowany Bielmar i rzecze:");
                        Methods.Sleep(500);
                        Console.WriteLine("RAZ...DWA...TRZY... kto wciąga tabake ma się przyznać bo inaczej wszyscy dostają po naganie");
                        Methods.Sleep(500);
                        Console.WriteLine("Twoi znajomi wspólnie oskarżyli o to ciebie");
                        Methods.Sleep(500);
                        Console.WriteLine("W tym momencie słysząc co się dzieje, wchodzi ZBYSZEK himself");
                        Methods.Sleep(500);
                        Console.WriteLine("Zbyszek strzela Bielmarowi w PYSK wyciaga go za fraki i kulturalnie wrzuca do kontenera z odpadami naturalnymi #segragacja ");
                        Methods.Sleep(500);
                        Console.WriteLine("Horacy i Bonifacy dostają w PYSK od Zbyszka");
                        Methods.Sleep(500);
                        Console.WriteLine("Wychodzisz ze Zbyszkiem na korytarz");
                        Methods.Sleep(500);
                        Console.WriteLine("Achivment get: #segregacja");
                        segregacja = true;
                        Methods.Ent();
                        toiletEvent++;
                        Methods.Clear();
                        goto groundFloor;
                    }
                    
                    else if (toiletEvent == 3)
                    {
                        Methods.Clear();
                        Console.WriteLine("Idziesz się odlać do pisuaru");
                        Methods.Sleep(500);
                        Console.WriteLine("Szczając widzisz TAJEMNICZE GÓWNO na podłodze");
                        Methods.Sleep(500);
                        Console.WriteLine("Podchodzisz by zbadać sprawę, gdy do kibli wchodzi nagle po swej mistyczniej 'nieobecności'");
                        Methods.Sleep(1000);
                        Console.WriteLine("Świerszcz w Czynie");
                        Methods.Sleep(500);
                        Console.WriteLine("Wita się z tobą z daleka, próbując podać ci ręke poślizguje się na tym ów tajemniczym gównie");
                        Methods.Sleep(500);
                        Console.WriteLine("Rozbija se swój głupi ryj poczym odchodzi w strone drzwi");
                        Methods.Sleep(500);
                        Console.WriteLine("Wykrzykując przy tym: 'Kurwa', 'japierdole', 'to jest pojebane'");
                        Methods.Ent();
                        toiletEvent++;
                        Methods.Clear();
                        goto groundFloor;
                    }
                    
                    else if (toiletEvent > 3)

                    {
                        Methods.Clear();
                        Console.WriteLine("Po co tu przyszedłem");
                        Methods.Sleep(500);
                        Console.WriteLine("A... Zmierzam w tył...");
                        Methods.Sleep(500);
                        Methods.Ent();
                        Methods.Clear();
                        goto groundFloor;
                    }
                }                
                //Sala Fryzjerska
                else if (choiceGround == "5")
                {
                    Clear();
                    Console.WriteLine("Zaglądzasz do sali gdzie fryzjerki mają lekcje");
                    Sleep(500);
                    Console.WriteLine("Gdy wszystkie grzecznie cię proszą o wyjście:");
                    Sleep(500);
                    Console.WriteLine("Wypierdalaj!!!!!!");
                    Sleep(500);
                    Console.WriteLine("Przed ucieczką w obawie o swoje życie udaje ci się zabrać bezprawnie nożyczki");
                    Sleep(500);
                    eq.Items.Add(Item.Secator);
                    Ent();
                    Clear();
                    goto groundFloor;
                }                
                //Sekretariat
                else if (choiceGround == "6")
                {
                     sekretariacik:

                            Clear();
                            Console.WriteLine("Wchodzisz do sekretariatu, gdzie znajdują się miłe panie sekretarki");
                            Sleep(500);
                            Console.WriteLine("Co robisz?");
                            Sleep(500);
                            Console.WriteLine("");
                            Console.WriteLine("1. Kod do drzwi");
                            Sleep(500);
                            Console.WriteLine("2. Zapisz grę");
                            Sleep(500);
                            Console.WriteLine("3. Wczytaj grę");
                            Sleep(500);
                            Console.WriteLine("4. Wyjście");
                            if (eq.Items.Contains(Item.ThermosWater))
                            {
                                Console.WriteLine("5. Herbatka");
                                Sleep(500);
                            }
                            if (!krukRobotics && !wygaslRobotics)
                            {
                                Sleep(500);
                                Console.WriteLine("6. Zapisz się na robotykę");
                            }

                            String sekretarka = Console.ReadLine();

                            if (sekretarka == "5")
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Pani z sekretariatu oferuje ci herbatke");
                                Sleep(500);
                                if (eq.Items.Contains(Item.ThermosWater))
                                {
                                    Console.WriteLine("Proszę to twoja herbatka");
                                    Sleep(500);
                                    Console.WriteLine("*Zdobywasz przedmiot: herbatka*");
                                    Sleep(500);
                                    eq.Items.Add(Item.ThermosWater);
                                    eq.Items.Add(Item.ThermosTea); 
                                    Ent();
                                    Clear();
                                    goto sekretariacik;
                                }
                            }

                            else if (sekretarka == "1")
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Uprzjmie prosisz panią sekretarkę o kod do szatni");
                                Sleep(500);
                                Console.WriteLine("Od pani sekretarki dowiadujesz się że, kod to 2354#");
                                eq.Items.Add(Item.Code);
                                Sleep(500);
                                Console.WriteLine("Zdobywasz przedmiot: Kod do drzwi");
                                Ent();
                                Clear();
                                goto sekretariacik;
                            }

                            else if (sekretarka == "2")
                            {
                                Clear();
                                //save();
                                Sleep(500);
                                Clear();
                                goto sekretariacik;
                            }

                            else if (sekretarka == "3")
                            {
                                Clear();
                                //load();
                                Sleep(500);
                                Clear();
                                goto sekretariacik;
                            }

                            else if (sekretarka == "4")
                            {
                                Console.WriteLine("orkizmajorki");
                                Ent();
                                Clear();
                                goto groundFloor;
                            }

                            else if (sekretarka == "5" && !krukRobotics && !wygaslRobotics)
                            {
                            Jobot:
                                Clear();
                                Console.WriteLine("Choose your side");
                                Sleep(250);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("1. Pan Kruk                   ");
                                Sleep(250);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("||");
                                Sleep(250);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("                      2. Pan Wygasł");
                                Console.ResetColor();

                                string czussajd = Console.ReadLine();

                                if (czussajd == "1")
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Wybrałeś Pana Kruka");
                                    krukRobotics = true;
                                    Sleep(500);
                                    Console.WriteLine("Po dalsze instrukcje zgłoś się do sali 21");
                                    Ent();
                                    goto sekretariacik;
                                }

                                else if (czussajd == "2")
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Słusznie wybrałeś Pana Wygasła");
                                    wygaslRobotics = true;
                                    Sleep(500);
                                    Console.WriteLine("Legenda głosi że można go spotkać w sali 13");
                                    Ent();
                                    goto sekretariacik;
                                }

                                else
                                {
                                    Clear();
                                    goto Jobot;
                                }
                            }

                            else
                            {
                                Clear();
                                goto sekretariacik;
                            }

                }                
                //Sala Dentystyczna
                else if (choiceGround == "7")
                {
                    Clear();
                    if (gruzjanEkonomiczny)
                    {
                        Console.WriteLine("Wchodzisz do sali dentystycznej");
                        Sleep(500);
                        Console.WriteLine("Tam zaskakuje cię Stomatolog Gruzjan");
                        Sleep(500);
                        Console.WriteLine("Rzuca cie na krzesło stomatologiczne i zaczyna operacje");
                        Sleep(500);
                        Console.WriteLine("Po godzine męczarni Gruzjan wyrzuca cię z sali");
                        Sleep(500);
                        Console.WriteLine("Czujesz niezwykły ból w jamie ustnej");
                        Sleep(500);
                        Ent();
                        Clear();
                        Sleep(500);
                        Console.WriteLine("Achievement Get: Zaliczony");
                        Ent();
                        Clear();
                        gruzjanEkonomiczny = false;
                        goto groundFloor;
                    }
                    if (!gruzjanEkonomiczny)
                    {
                        Console.WriteLine("Nie ide tam, nadal boli mnie ryj");
                        Sleep(1000);
                        goto groundFloor;
                    }
                }   
                //Automat z Kawą
                else if (choiceGround == "8")
                {
                    Console.WriteLine("Zamawiasz kawe z mlekiem");

                    if (eq.Items.Contains(Item.Milk))
                    {
                        Sleep(500);
                        Console.WriteLine("*Zyskujesz kawe z mlekiem*");
                        Ent();
                        eq.Items.Add(Item.CoffeMilk);
                        Clear();
                        goto groundFloor;
                    }
                }                
                //Dispenser z wodą
                else if (choiceGround == "9")
                {
                    if (eq.Items.Contains(Item.Thermos))
                    {
                        Console.WriteLine("Napełniasz Termos wodą");
                        Sleep(500);
                        Console.WriteLine("*Zyskujesz termos z wodą*");
                        Ent();
                        eq.Items.Add(Item.ThermosWater);
                        eq.Items.Remove(Item.Thermos);
                        Clear();
                        goto groundFloor;
                    }

                    else if (eq.Items.Contains(Item.ThermosWater))
                    {
                        Console.WriteLine("Termos jest pełny");
                        Clear();
                        goto groundFloor;
                    }

                    else if (!eq.Items.Contains(Item.Thermos))
                    {
                        Console.WriteLine("'Przydałoby się mieć jakiś pojemnik na wodę'");
                        Ent();
                        Clear();
                        goto groundFloor;
                    }
                }                
                //Zinwestyguj gaśnice
                else if (choiceGround == "10")
                {
                    Methods.Clear();
                    eq.Items.Add(Item.Extingusher);
                    Console.WriteLine("Zauważasz gaśnice");
                    Methods.Sleep(500);
                    Console.WriteLine("Uważając że, jest przydatna zabierasz ją");
                    Methods.Sleep(500);
                    Console.WriteLine("*Zdobywasz gaśnice*");
                    Methods.Ent();
                    goto groundFloor;
                }                
                //Zawróć
                else if (choiceGround == "11")
                {
                    Sleep(500);
                    Clear();
                    goto gate;
                }                
                //Schody na górę
                else if (choiceGround == "12")
                {
                    Clear();
                    Sleep(500);
                    Console.WriteLine("Wchodzisz po schodach");
                    Ent();
                    Clear();
                    goto halfFloor;
                }                
                //Ekwipunek
                else if (choiceGround == "13")
                {
                    Methods.Clear();
                    eq.ItemsDisplay();
                    goto groundFloor;
                }
                //Else
                else
                {
                    Clear();
                    goto groundFloor;
                }
            }

            #endregion
            
            //Piwnica
            #region Basement

            basement:
            {
                Console.WriteLine("Jest tu trochę szafek i wieszaków");
                Sleep(250);
                Console.WriteLine("Ciekawo co innego tu znajdę");
                Sleep(250);
                Console.WriteLine("1. Przeszukaj");
                Sleep(250);
                Console.WriteLine("2. Idź dalej");
                Sleep(250);
                Console.WriteLine("3. Cofnij się");
                Sleep(250);
                Console.WriteLine("4. Ekwipunek");
                Sleep(250);
                Console.WriteLine("5. Gaśnica");
                Sleep(250);
                if (dziurwa)
                {
                    Console.WriteLine("6. Ziwestyguj dziure");
                }
                
                String corobic = Console.ReadLine();
                {
                        if (corobic == "1")
                        {
                            if (szukak == 1)
                            {
                                cls();
                                Console.WriteLine("Na wieszaku wisi wiele kurtek");
                                sleep();
                                Console.WriteLine("Jedną z nich rozpoznajesz kurtkę twojego 240cm kolegi");
                                sleep();
                                Console.WriteLine("Po założeniu jej kurtka przykrywa ciebie całego");
                                sleep();
                                Console.WriteLine("*Zyskujesz przdmiot: Kurtka*");
                                kurtka = true;
                                ++szukak;
                                ent();
                                cls();
                                goto Szatnia;


                            }

                            else if (szukak == 2)
                            {
                                cls();
                                Console.WriteLine("Znalazłeś dziure w ścianie");
                                sleep();
                                Console.WriteLine("Ciekawo co kryje w ścrodku");
                                dziura = true;
                                ++szukak;
                                ent();
                                cls();
                                goto Szatnia;


                            }

                            else if (szukak == 3)
                            {
                                cls();
                                Console.WriteLine("*potykasz się*");
                                sleep();
                                Console.WriteLine("Spoglądasz w dół i widzisz naderwaną kafelkę");
                                sleep();
                                Console.WriteLine("Przyglądając się dostrzegasz światełko");
                                ent();
                                cls();
                                goto dziura1;

                            }
                        }

                        else if (corobic == "2")
                        {
                            cls();
                            Console.WriteLine("*widzisz uchylone drzwi*");
                            ent();
                            goto kotlownia1;

                        }

                        else if (corobic == "3")
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("A spierdalam");
                            ent();
                            cls();
                            goto brama;

                        }

                        else if (corobic == "4")
                        {
                            cls();
                            eq();
                            cls();
                            goto Szatnia;

                        }

                        else if (corobic == "5")
                        {
                            cls();
                            Console.WriteLine("Zauważasz gaśnice");
                            sleep();
                            Console.WriteLine("Uważając że, jest przydatna zabierasz ją");
                            sleep();
                            Console.WriteLine("*Zdobywasz gaśnice*");
                            ent();
                            gasnica = true;
                            cls();
                            goto Szatnia;
                        }

                        else if (corobic == "6" && dziura == true)
                        {
                            Console.WriteLine("Oooo Mlekooo");
                            sleep();
                            Console.WriteLine("*Zdobywasz przdmiot: Mlekooo*");
                            mlekooo = true;
                            ent();
                            cls();
                            goto Szatnia;


                        }

                        else
                        {
                            cls();
                            goto Szatnia;
                        }
                }
            }

            #endregion
            
            //HalfFloor
            #region HalfFloor
            
            halfFloor:
            {
                Console.WriteLine("Na pół piętrze stoi automat z przekąskami");
                Console.WriteLine("");
                Console.WriteLine("1. Zbadaj automat");
                Console.WriteLine("2. Idź wyżej");
                Console.WriteLine("3. Gaśnica");
                Console.WriteLine("4. Zejdź na parter");

                String polowa = Console.ReadLine();
                
                if (polowa == "1")
                {
                        automotivv:
                            Console.WriteLine("Co chcesz wybrać z automatu");
                            Console.WriteLine("");
                            Console.WriteLine("1. Baton of Power");
                            Console.WriteLine("2. Napój of Youth");
                            Console.WriteLine("3. Chipsy of Immortality");
                            Console.WriteLine("4. Cofnij się");

                            String automotiv = Console.ReadLine();
                            
                                if (automotiv == "1")
                                {
                                    var rand = new Random();
                                    int randomnuberr = rand.Next(100);
                                    
                                    if (randomnuberr > 65)
                                    {
                                        Console.WriteLine("Zapłaciłeś a przedmiot wypada");
                                        Sleep(500);
                                        Console.WriteLine("*Zyskujesz Baton of Power*");
                                        eq.Items.Add(Item.BatonOfPower);
                                        Ent();
                                        Clear();
                                        goto automotivv;

                                    }
                                    
                                    else if (randomnuberr <= 65)
                                    {
                                        Console.WriteLine("Zapłaciłeś a przedmiot się klinuje");
                                        Sleep(500);
                                        Console.WriteLine("xD... Wal się frajerze");
                                        Ent();
                                        Clear();
                                        goto halfFloor;
                                    }
                                }
                                
                                else if (automotiv == "2")
                                {
                                    var rand = new Random();
                                    int randomnuberr = rand.Next(100);

                                    if (randomnuberr > 65)
                                    {
                                        Console.WriteLine("Zapłaciłeś a przedmiot wypada");
                                        Sleep(500);
                                        Console.WriteLine("*Zyskujesz Napój of Youth*");
                                        eq.Items.Add(Item.DrinkOfYouth);
                                        Ent();
                                        Clear();
                                        goto automotivv;
                                    }

                                    else if (randomnuberr <= 65)
                                    {
                                        Console.WriteLine("Zapłaciłeś a przedmiot się klinuje");
                                        Sleep(500);
                                        Console.WriteLine("xD... Wal się frajerze");
                                        Ent();
                                        Clear();
                                        goto halfFloor;
                                    }
                                }
                                
                                else if (automotiv == "3")
                                {
                                    var rand = new Random();
                                    int randomnuberr = rand.Next(100);

                                    if (randomnuberr > 65)
                                    {
                                        Console.WriteLine("Zapłaciłeś a przedmiot wypada");
                                        Sleep(500);
                                        Console.WriteLine("*Chipsy of Immortality*");
                                        eq.Items.Add(Item.CrispsOfImmortality);
                                        Ent();
                                        Clear();
                                        goto automotivv;
                                    }

                                    else if (randomnuberr <= 65)
                                    {
                                        Console.WriteLine("Zapłaciłeś a przedmiot się klinuje");
                                        Sleep(500);
                                        Console.WriteLine("xD... Wal się frajerze");
                                        Ent();
                                        Clear();
                                        goto halfFloor;

                                    }
                                }
                                
                                else if (automotiv == "4")
                                {
                                    Clear();
                                    goto automotivv;
                                }
                }

                else if (polowa == "2")
                        {
                            Console.WriteLine("Wchodzisz na piętro");
                            Ent();
                            Clear();
                            goto secondFloor;
                        }

                else if (polowa == "3")
                        {
                            Clear();
                            Console.WriteLine("Zauważasz gaśnice");
                            Sleep(500);
                            Console.WriteLine("Uważając że, jest przydatna zabierasz ją");
                            Sleep(500);
                            Console.WriteLine("*Zdobywasz gaśnice*");
                            Ent();
                            if (!eq.Items.Contains(Item.Extingusher))
                            {
                                eq.Items.Add(Item.Extingusher);
                            }
                            Clear();
                            goto halfFloor;
                        }

                else if (polowa == "4")
                {
                    Console.WriteLine("A... zmierzam spowrotem");
                    Sleep(500);
                    goto groundFloor;
                }

                else
                        {
                            goto halfFloor;
                        }
            }
            #endregion
            
            //SecondFloor
            #region SecondFloor

            secondFloor:
            {
                
            }
            #endregion

        }
    }
}