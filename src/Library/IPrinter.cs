using System;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Basandonos en los Principios Polimorfismo y LSP.
    /// En vez de un condicional, creamos una interfaz con la operacion PrintRecipe, la cual va a ser implementada por las clases
    /// ConsolePrinter y FilePrinter.
    /// </summary>
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);
    }
    
}