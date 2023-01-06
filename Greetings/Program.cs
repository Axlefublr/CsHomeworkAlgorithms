namespace Greetings;

internal class Program
{
   private static void Main(string[] args)
   {
   }

   static void ShowAds()
   {
      string[] ads = {
         "Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com",
         "Купите подписку на МыКомбо и слушайте музыку везде и всегда.",
         "Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу."
      };

      foreach (string ad in ads) {
         Console.WriteLine(ad);
         Thread.Sleep(1000);
      }
   }
}