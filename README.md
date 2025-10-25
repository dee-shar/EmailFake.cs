# EmailFake.cs
Web-API for [emailfake.com](https://emailfake.com) an website where you can get an unlimited number of email accounts that you can use for your own needs

## Example
```cs
using System;
using EmailFakeApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new EmailFake();
            string generatedEmail = await api.GenerateEmail();
            Console.WriteLine(generatedEmail);
        }
    }
}
```
