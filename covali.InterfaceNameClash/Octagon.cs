﻿namespace covali.InterfaceNameClash
{
    internal class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing to form...");
        }
        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing to memory...");
        }
        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing to printer...");
        }

        //public void Draw()
        //{
        //    Console.WriteLine("Drawing the Octagon....");
        //}
    }
}
