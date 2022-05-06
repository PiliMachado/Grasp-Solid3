using System;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Basandome en los Principios Polimorfismo y LSP.
    /// En vez de un condicional, creo una interfaz con la operacion PrintRecipe,
    /// la cual va a ser implementada por las clase ConsolePrinter y FilePrinter. 
    /// De querer añadirse una nueva forma de impresion se crea una
    /// clase y se utiliza esta interfaz en dicha clase
    /// </summary>
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);
    }
    
}