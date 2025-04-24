namespace PracticaParcial_Listas_Enlazadas.Server
{
    public class LES
    {
        public Nodo? PrimerNodo { get; set; }
        public Nodo? UltimoNodo { get; set; }

        public LES()
        {
            PrimerNodo = null;
            UltimoNodo = null;
        }

        bool EstaVacia()
        {
            return  UltimoNodo == null;
        }

        public string InsetarNodoAlInicio(Nodo nuevoNodo)
        {
            if (EstaVacia()) 
            {
                PrimerNodo = nuevoNodo;
                UltimoNodo = nuevoNodo;
            }
            else 
            { 
            nuevoNodo = PrimerNodo.Referencia;
            PrimerNodo = nuevoNodo;
			}
			return $"Se creo el nodo {nuevoNodo.Informacion}";
            
        }

        public string InsetarNodoAlFinal(Nodo nuevoNodo)
        {
            if (EstaVacia())
            {
                PrimerNodo = nuevoNodo;
                UltimoNodo = nuevoNodo;
            }
            else
            {
                UltimoNodo.Referencia = nuevoNodo;
                UltimoNodo = nuevoNodo;

            }
            return $"Se insertor nodo {nuevoNodo.Informacion}";
        }

    }
}
