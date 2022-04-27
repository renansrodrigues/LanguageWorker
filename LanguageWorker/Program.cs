using Azure;
using Azure.AI.TextAnalytics;
using System;

namespace LanguageWorker
{
    class Program
    {

        private static readonly AzureKeyCredential credentials = new AzureKeyCredential("chave api");
        private static readonly Uri endpoint = new Uri("url recurso");
        
        static void LanguageDetection(TextAnalyticsClient client)
        {
            Console.Write("Digite uma frase para reconhecimento de idioma:");
            Console.ReadKey();
            
            string text;
            text = Console.ReadLine();
            DetectedLanguage detectedLanguage = client.DetectLanguage(text);            
            Console.WriteLine("O texto digitado é do idioma:");
            Console.WriteLine($"\t{detectedLanguage.Name}\n");
        }

        static void Main(string[] args)
        {
            var client = new TextAnalyticsClient(endpoint, credentials);
            LanguageDetection(client);

            Console.Write("Pressione uma tecla para fechar");
            Console.ReadKey();
        }
    }
}
