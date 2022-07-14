using covali.InterfaceNameClash;

Console.WriteLine("***** Fun with Interface Name Clashes *****\n");

Octagon oct = new();
IDrawToForm itfForm = (IDrawToForm)oct;
itfForm.Draw();

IDrawToMemory itfMemory = (IDrawToMemory)oct;
itfMemory.Draw();

IDrawToPrinter itfPrinter = (IDrawToPrinter)oct;
itfPrinter.Draw();






Console.ReadLine();