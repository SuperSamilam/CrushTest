Console.ForegroundColor = ConsoleColor.White;


Console.WriteLine("Vad Heter Du?");
string name = Console.ReadLine();

Console.WriteLine("Hur Gammal är Du?");
int your_age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vad heter din Crush?");
string crush = Console.ReadLine();

Console.WriteLine("Hur Gammal är din crush?");
int crush_age = Convert.ToInt32(Console.ReadLine());

if (name.ToCharArray().Length <= 3){
    Console.WriteLine("Ni kommer gifta er");
    if (your_age >= crush_age + 5){
        Console.WriteLine("Fast du är ett pedo");
    }
    else if (your_age + 5 <= crush_age){
        Console.WriteLine("Din crush är ett pedo");
    }
}
else if (name.ToUpper() == "MAXI" || name.ToUpper() == "MAXIMILIAN"){
    Console.WriteLine(name + " hatar dig, och du kommer att dö ensam för evigt. dessutom kommer du dö på förtid. " + name.ToUpper() + " DETTA ÄR PERSONLIGT");
}
else{
    Console.WriteLine(crush + " hatar dig " + name.ToUpper());
}
    Thread.Sleep(10000);
