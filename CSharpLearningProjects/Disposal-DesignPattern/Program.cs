using System.Net.Http;

namespace Disposal_DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (CurrencyService currencyService = new CurrencyService())
            { 
                var result = currencyService.GetCurrencies();
                Console.WriteLine(result);
            }
        }
        class CurrencyService:IDisposable
        {
            private readonly HttpClient httpClient;
            private bool _disposed=false;

            public CurrencyService()
            {
                httpClient= new HttpClient();
            }
            ~CurrencyService()
            {
                
            }
            // disposing : true (dispose managed + unmanaged)      
            // disposing : false (dispose unmanaged + large fields)
            protected void Dispose(bool disposing)
            {
                if (!_disposed)
                    return;
                if(disposing)
                { 
                    httpClient.Dispose();
                }
                // unmanaged object
                // set large fields to null
                _disposed = true;
            }
            public void Dispose()
            {
                // dipose() is called 100%
                Dispose(true);
                GC.SuppressFinalize(this);
            }
            public string GetCurrencies()
            {
                string url = "https://coinbase.com/api/v2/currencies";
                var result = httpClient.GetStringAsync(url).Result;
                return result;
            }   


        }
    }
}
