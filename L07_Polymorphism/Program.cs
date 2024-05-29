//navrhnete vhodnou strukturu trid, ktera umozni v programu (v Mainu) vytvorit seznam zviratek v zoo koutku (List), 
//ktery pak muzeme jednoduse projit cyklem (foreach) a zadat kazdemu z nich prikaz VydavejZvuk
//pritom kazde zviratko bude vydavat jiny zvuk (vypise na konzoli Haf, haf nebo Mnau, mnau)
//v ramci cyklu nechci resit, jake konkretni zviratko to je
//vytvorte alespon 3 ruzna zviratka
//hint: budete potrebovat vhodnou bazovou tridu a virtual/abstract a override

using L07_Polymorphism;

List<AnimalBase> animals =
    new()
    {
        new Wolf(),
        new Lion(),
        new Zebra(),
    };
    
animals
    .ForEach(animal => animal.MakeSound());

Console.ReadLine();