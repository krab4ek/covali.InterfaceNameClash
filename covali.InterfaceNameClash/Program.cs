using covali.InterfaceNameClash;

Console.WriteLine("***** Fun with Interface Name Clashes *****\n");

Octagon oct = new();
IDrawToForm itfForm = (IDrawToForm)oct;
itfForm.Draw();

//IDrawToMemory itfMemory = (IDrawToMemory)oct;
//itfMemory.Draw();
((IDrawToMemory)oct).Draw();

//IDrawToPrinter itfPrinter = (IDrawToPrinter)oct;
//itfPrinter.Draw();
if (oct is IDrawToPrinter dtm)
    dtm.Draw();






Console.ReadLine();