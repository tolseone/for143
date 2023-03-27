Console.WriteLine();
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
////
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
////
//
//
//
//



























































































































































































































































































































































































































string ReadText(string msgToYou)
{
    Console.WriteLine(msgToYou);
    string value = Console.ReadLine();
    return value;
}

string first_ask = ReadText("Приветствую. Мой создатель воплотил меня в жизнь только для 1 человека на этой Земле, чтобы приступить к работе со мной представься :). Для того, чтобы идентифицировать тебя, мне нужно задать тебе несколько вопросов. Напиши Своё полное имя (Только имя, ничего более): ");
string second_ask = ReadText("Напиши свою дату рождения (в формате DD.MM.YYYY): ");
string third_ask = ReadText("Твой любимый цвет: ");
Result();
string ask_4 = ReadText("Мой создатель попросил передать тебе кое-что. Чтобы получить доступ к этой информации, назови своё любимое число: ");
Console.WriteLine(answer_4(ask_4));
string ask_5 = ReadText("ALARM!!! ALARM!!! ALARM!!! ВНЕЗАПНАЯ ПРОВЕРКА. Сколько лет шла 100-летняя война (отвечай быстро, либо же доступ будет потерян): ");
Console.WriteLine(answer_5(ask_5));

for (int i = 1; i < 47; i++)
{
    Console.WriteLine($"{i} попытка авторизации !@#$%^&* {Fibonacci(i)}");
}

Console.WriteLine("Авторизация пройдена успешно. Открываю текст...");
Console.WriteLine("Привет, Киса, это я - Толя. Я создал эту программу, чтобы кое-что тебе сказать.");
Console.WriteLine("Ты самая прекрасная девушка на всем белом свете. Ты самая красивая, умная, привлекательная, ласковая, искренняя. Проще говоря самая лучшая!");
Console.WriteLine("Мы с тобой уже 1 235 дней вместе. Это 29 640 часов, 1 778 400 минут, 106 704 000 секунд, кстати говоря, пока ты доходила до этого текста, прошло ещё около 420 секунд. Я всё это время буду находиться за твоей спиной, и я хотел бы задать тебе только 1 вопрос, повернись пожалуйста ко мне, моё солнышко ");

bool first_answer(string firstAsk)
{
    if (firstAsk == "анастасия" || firstAsk == "настя" || firstAsk == "настюша" || firstAsk == "киса" || firstAsk == "настенька")
    {
        return true;
    }
    return false;
}

bool second_answer(string SecondAsk)
{
    if (SecondAsk == "08.11.1998" || SecondAsk == "8.11.1998" || SecondAsk == "08.11.1998" || SecondAsk == "08.11.98")
    {
        return true;
    }
    return false;
}

bool third_answer(string ThirdAsk)
{
    if (ThirdAsk == "розовый" || ThirdAsk == "фиолетовый" || ThirdAsk == "красный")
    {
        return true;
    }
    return false;
}

string answer_4(string ask4)
{
    string res = string.Empty;
    if(ask4 == "8" || ask4 == "18" || ask4 == "6")
    {
        res += "Ответ правильный. Открываю доступ к засекреченным файлам...";
        return res;
    }
    else
    {
        res += "Ответ неправильный. Перезапусти программу (Комбинация CTRL + C)";
        return res;
    }
}

string answer_5(string ask5)
{
    string res = string.Empty;
    if (ask5 == "116" || ask5 == "116 лет")
    {
        res += "Проверка пройдена успешно. Прошу немного подождать, происходит авторизация";
        return res;
    }
    else
    {
        res += "Проверка непройдена. Перезапустите программу и попробуйте снова (Комбинация CTRL + C)";
        return res;
    }
}

void Result()
{
    if (first_answer(first_ask.ToLower()) == true && second_answer(second_ask) == true && third_answer(third_ask.ToLower()) == true)
    {
        Console.ForegroundColor = ConsoleColor.Red; 
        int height = 30, width = 150;
        char[,] buffer = new char[height, width];
        Console.SetWindowSize(width, height);
        Console.SetBufferSize(width, height);
        for(int i = 0; i < height; i++)
        {
            for(int j = 0; j < width; j++)
            {
                int x = j - width / 2;
                int y = -1 * (i - height / 2);
                int firstPart = (x * x) / 3;
                int secondPart = (int)((y - Math.Sqrt(Math.Abs(x))) * (y - Math.Abs(x)));
                int heartSize = 50;
                if (firstPart + secondPart <= heartSize)
                {
                    buffer[i, j] = '♥';
                }
                else
                {
                    buffer[i, j] = ' ';
                }
            }        
        }
        for(int i = 0; i < height; i++)
        {
            for(int j = 0; j < width; j++)
            {
                Console.Write(buffer[i, j]);
            }
        Console.WriteLine();
        }
        Console.WriteLine("Приветствую тот самый единственный Человекчек на Земле. Это сердечко для тебя :-) (его оставил мой создатель)");
    }
    else
    {
        Console.WriteLine("Либо ты ошиблась, либо ты за меня кого держишь?) Жулик!");
    }
}

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}



