namespace Implementacion_de_patrones_G4.FactoryMethod
{
    /// <summary>
    /// Clase de Recuerdo
    /// </summary>
    public class Recuerdo
    {
        private string _nombre;
        private string _telefono;
        private double _presupuesto;

        // Constructor
        public Recuerdo(string nombre, string telefono, double presupuesto)
        {
            this._nombre = nombre;
            this._telefono = telefono;
            this._presupuesto = presupuesto;
        }

        // Get y Set de Nombre
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        // Get y Set de Recuerdo
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        // Get y Set de Presupuesto
        public double Presupuesto
        {
            get { return _presupuesto; }
            set { _presupuesto = value; }
        }
    }

}