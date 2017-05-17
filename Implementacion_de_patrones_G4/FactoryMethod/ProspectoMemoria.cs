 namespace Implementacion_de_patrones_G4.FactoryMethod
    {
        class ProspectoMemoria
        {
            private Recuerdo _recuerdo;
            // Propiedad
            public Recuerdo Recuerdo
            {
                set { _recuerdo = value; }
                get { return _recuerdo; }
            }
        }
    }
