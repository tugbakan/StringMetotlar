using System;

public class Program
{
    public static void Main(string[] args)
    {
        string degisken= "Dersimiz C# Hoşgeldiniz";
        string degisken2 = "C#";


        //Length (Karakter Sayısı);
        Console.WriteLine(degisken.Length);

        //ToUpper , ToLower;
        Console.WriteLine(degisken.ToUpper()); //Karakterlerin hepsini büyütür.
        Console.WriteLine(degisken.ToLower()); //Karakterlerin hepsini küçültür.

        //Concat
        Console.WriteLine(string.Concat(degisken, "Merhaba!")); //Tanımladığımız stringe yeni bir kelime ekler.

        //Compare & CompareTo
        Console.WriteLine(degisken.CompareTo(degisken2)); /*degisken1 degisken2 ye eşit olursa 0 döner, 
                                                            degisken1 degisken2den daha büyük bir karakter sayısına sahip olursa 1 döner,  
                                                            degisken1 degisken2den daha küçük bir karakter sayısına sahip olursa -1 döner. */ 

        Console.WriteLine(string.Compare(degisken,degisken2, true)); // true olursa büyük küçük harf duyarsız hale gelir. false dersek büyük küçük harf duyarlı olur.
        Console.WriteLine(string.Compare(degisken,degisken2, false)); 

        //Contains & EndsWith & StartWith
        Console.WriteLine(degisken.Contains(degisken2)); //degisken in içinde degisken 2 var mı?
        Console.WriteLine(degisken.EndsWith("Hoşgeldiniz")); // degisken Hoşgeldiniz ile bitiyor mu?
        Console.WriteLine(degisken.StartsWith("Merhaba")); // degisken Hoşgeldiniz ile başlıyor mu?

        //IndexOff
        Console.WriteLine(degisken.IndexOf("C#")); //degisken içerisinde ilk bulduğu yerde index i verir. Bulamazsa -1 verir
        Console.WriteLine(degisken.IndexOf("Tugba"));
        Console.WriteLine(degisken.LastIndexOf("i")); // Son i nin indexini getirir.

        //Insert
        Console.WriteLine(degisken.Insert(0,"Merhaba ")); // 0. indexten başlayarak "Merhaba" ekler
        
        //PadLeft, PadRight;
        Console.WriteLine(degisken + degisken2.PadLeft(30)); //degisken2 nin soluna 30 a tamamlayacak kadar boşluk ekler. (karakter sayısı+boşluk=30 olacak şekilde)
        Console.WriteLine(degisken + degisken2.PadLeft(30,'*')); //degisken2 nin soluna 30 a tamamlayacak kadar yıldız ekler.
        Console.WriteLine(degisken.PadRight(50)+ degisken2); 
        Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

        //Remove
        Console.WriteLine(degisken.Remove(10)); // 10. indexten başlayarak sonuna kadar siler.
        Console.WriteLine(degisken.Remove(5,3)); // 5. indexten başlayarak 3 karakter siler.
        Console.WriteLine(degisken.Remove(0,1)); // En baştaki karakteri siler.

        //Replace
        Console.WriteLine(degisken.Replace("C#","CSharp")); //Verilen ilk değeri ikinci değer ile değiştir.
        Console.WriteLine(degisken.Replace(" ","*")); //Boşlukları yıldıza çevirir.

        //Split
        Console.WriteLine(degisken.Split(' ')[1]); //Boşluklara göre parçala ve bir diziye ata. 1. indexteki değeri getir.

        //Substring 
        Console.WriteLine(degisken.Substring(4)); // 4. indexten başlayarak cümlenin sonuna kadar getir.
        Console.WriteLine(degisken.Substring(4,6)); // 4. indexten başlayarak 6 karakter getir.

    }
}
