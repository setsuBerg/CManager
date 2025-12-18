namespace CManager.Presentation.consoleApp.Validators;
using System.Linq;

public class EmailValidator
{
    public static bool IsValid(string email) 
    {
        if (string.IsNullOrWhiteSpace(email))  //null, "", " ".
            return false;

        if (email.Any(ch => "åäöÅÄÖ".Contains(ch)))　//Contains: ingår ch i "åäöÅÄÖ".
            return false;

        return true;
    }
}
