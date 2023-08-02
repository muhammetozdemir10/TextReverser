namespace TextReverser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Burada yaziya renk veriyoruz
            Console.ForegroundColor = ConsoleColor.DarkRed;

            // Burada ekrana yazilacak kelimeyi yazdiririz
            Console.WriteLine("Text Reverser");

            // Burada renki reset'liyoruz
            Console.ResetColor();

            // Ekrana yazilmak istenen yaziyi yaziyoruz
            Console.WriteLine("Cevirmek istediginiz yaziyi yaziniz:");

            // Burda ekrandan aliyoruz
            string? text = Console.ReadLine();

            // Burada textReversed degiskenini tanimliyoruz
            string textReversed = "";

            // Burada bos olup olmadigina kontrol ediyoruz
            if (text != null)
            {
                // Ters dongu yaparak text.Length'ten baslayip 0'a kadar donuyor
                for (int i = text.Length - 1; 0 <= i; i--)
                {
                    // text'teki harflerin birini "i"nin degeri ile harfi alip
                    // textReversed degiskeninin uzerine ekliyoruz.
                    textReversed += text[i];
                }
            }

            // burada yazinin rengini mavi yapiyoruz
            Console.ForegroundColor = ConsoleColor.Blue;

            // buradaki yaziyi ekrana yaziyoruz
            Console.WriteLine($"Cevirilen yazi:");

            // burada rengi resetliyoruz
            Console.ResetColor();

            // burada ekrana textReversed degiskenin icindeki degeri yazdiriyoruz
            Console.WriteLine(textReversed);
        }
    }
}