using System.Security.Cryptography.X509Certificates;

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
            nuevoNodo.Referencia = PrimerNodo;
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

        public string InsertarAntesDatoX(Nodo nuevoNodo, string valor)
        {
            if (EstaVacia()) return "Lista Vacia";

			if (PrimerNodo.Informacion == valor)
			{
				InsetarNodoAlInicio(nuevoNodo);
			}
			Nodo nodoActual = PrimerNodo;
            

            while (nodoActual.Referencia != null &&  nodoActual.Referencia.Informacion != valor)
            {
                nodoActual = nodoActual.Referencia;
                
            }
            if (nodoActual == null) return "Dato no encontrado"; 
            
            nuevoNodo.Referencia = nodoActual.Referencia;
            nodoActual.Referencia = nuevoNodo;
            
            
            return $"Nodo insertado con exito";

		}


        public string InsertarDespuesDatoX(Nodo nuevoNodo, string valor)
        {
            if (EstaVacia()) return "Lista Vacia";
            if(PrimerNodo == UltimoNodo && UltimoNodo.Informacion == valor)
            {
                InsetarNodoAlFinal(nuevoNodo);
            }
            Nodo nodoActual = PrimerNodo;
            while(nodoActual != null && nodoActual.Informacion != valor)
            {
                nodoActual = nodoActual.Referencia;
            }
            if (nodoActual.Referencia == null) return "Dato no encontrado";

            nuevoNodo.Referencia = nodoActual.Referencia;
            nodoActual.Referencia = nuevoNodo;

            return $"Se inserto el nodo con exito";

        }

        public string InsetarEnPosicionEspecifica(Nodo nuevoNodo, int Posicion)
        {
            if (EstaVacia())
            {
                if (Posicion < 0) return "Posicion invalida";
                if(Posicion == 0)
                {
                    InsetarNodoAlInicio(nuevoNodo);
                }

            }
			Nodo nodoActual = PrimerNodo;
			int Indice = 0;

			while (nodoActual.Referencia != null && Indice != Posicion)
			{
				nodoActual = nodoActual.Referencia;
				Indice++;
			}
			if (nodoActual.Referencia == null) return "Dato no encontra";

			nuevoNodo.Referencia = nodoActual.Referencia;
			nodoActual.Referencia = nuevoNodo;
			return $"Nodo insertado en posicion {Posicion}";
		}

        public string InsertarAnntesPosicionEspecifica(Nodo nuevoNodo,int  Posicion)
        {
            InsertarAnntesPosicionEspecifica(nuevoNodo, Posicion - 1);
            return "Operacion exitosa";
        }
		public string InsertarDespuesPosicionEspecifica(Nodo nuevoNodo, int Posicion)
		{
			InsertarAnntesPosicionEspecifica(nuevoNodo, Posicion + 1);
			return "Operacion exitosa";
		}

        public string Buscar(string valor)
        {
            if (EstaVacia()) return "Lista Vacia";
            Nodo nodoActual = PrimerNodo;
            int Indice = 0;
            while (nodoActual.Referencia != null && nodoActual.Referencia.Informacion != valor)
            {
                nodoActual = nodoActual.Referencia;
                Indice++;
            }
            if (nodoActual == null) return "Dato no encontrar";
            return $"Nodo con infomracion {valor} encontrado en posicion {Indice}";
        }
	}
}
