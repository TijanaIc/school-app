namespace SchoolApp;

public class PinCode
{
    #region Parameters

    //parameters
    int maxCount = 0;
    int tryCount = 3;
    int i = 0;
    const int pin = 1111;

    #endregion

    #region Text Messages

    //Text Messages
    string badPin = "Pin nije ipravan";
    string goodPin = "Pin je ispravan";
    string blockedPin = "Pin Blokiran, Vas telefon je zakljucan";
    string infoPin = "Unesite Pin za otkuljacanje telefona";
    string blankPin = "Morate uneti pin";
    private string retryMessage = "Preostali broj pokusaja";

    #endregion

    public void TryPin()
    {
        do
        {
            Console.WriteLine("");
            Console.WriteLine(infoPin);

            if (int.TryParse(Console.ReadLine(), out i))
            {
                while (pin != i)
                {
                    Console.WriteLine(badPin + $": {retryMessage} {tryCount - maxCount}");
                    break;
                }
                while (pin == i)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(goodPin);
                    break;
                }
            }
            else
            {
                Console.WriteLine(blankPin);
            }

            if (CheckMaxTry(maxCount) && pin != i)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(blockedPin);
                break;
            }

            maxCount++;
        } while (pin != i && maxCount <= tryCount);

    }

    public bool CheckMaxTry(int maxCount)
    {
        return maxCount >= tryCount;
    }
}
