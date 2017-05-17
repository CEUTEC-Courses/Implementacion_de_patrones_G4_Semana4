using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacion_de_patrones_G4.AbstractFactory
{
    public class AbstractFactoryPatron
    {
        //Tendremos dos productos abstractos, IDumb y ISmart
        interface IDumb
        {
            string Name();
        }
        interface ISmart
        {
            string Name();
        }

        //Creamos los dos productos concretos para ID
        public class Alfa : IDumb
        {
            public string Name()
            {
                return "Alfa";
            }
        }

        public class Primo : IDumb
        {
            public string Name()
            {
                return "Primo";
            }
        }

        public class Tango : IDumb
        {
            public string Name()
            {
                return "Tango";
            }
        }

        //Y otros para ISmart
        public class iPhone : ISmart
        {
            public string Name()
            {
                return "iPhone";
            }
        }

        public class Galaxy : ISmart
        {
            public string Name()
            {
                return "Galaxy";
            }
        }

        public class HTC : ISmart
        {
            public string Name()
            {
                return "HTC";
            }
        }

        //Ahora se asocian los productos concretos con sus fabricantes 
        interface IPhoneFactory //'I' es de interface
        {
            ISmart GetSmart();
            IDumb GetDumb();
        }

        //Ahora se crean las fabricas concretas para cada fabricante
        class SamsungFactory : IPhoneFactory
        {
            public ISmart GetSmart()
            {
                return new Galaxy();
            }

            public IDumb GetDumb()
            {
                return new Primo();
            }
        }

        class HTCFactory : IPhoneFactory
        {
            public ISmart GetSmart()
            {
                return new HTC();
            }

            public IDumb GetDumb()
            {
                return new Tango();
            }
        }

        class iPhoneFactory : IPhoneFactory
        {
            public ISmart GetSmart()
            {
                return new iPhone();
            }

            public IDumb GetDumb()
            {
                return new Alfa();
            }
        }

        /* Ahora tenemos las clases abstractas de los productos, nuestros productos concretos listos,
        nuestra fabrica abstracta lista y las fabricas concretas. Ahora podemos crear el cliente que 
        usara esta jerarquia de productos relacionados */

        public enum MANUFACTURERS
        {
            SAMSUNG,
            HTC,
            IPHONE
        }

        public class PhoneTypeChecker
        {
            ISmart sam;
            IDumb htc;
            IPhoneFactory factory;
            MANUFACTURERS manu;

            public PhoneTypeChecker(MANUFACTURERS m)
            {
                manu = m;
            }

            public void CheckProducts()
            {
                switch (manu)
                {
                    case MANUFACTURERS.SAMSUNG:
                        factory = new SamsungFactory();
                        break;
                    case MANUFACTURERS.HTC:
                        factory = new HTCFactory();
                        break;
                    case MANUFACTURERS.IPHONE:
                        factory = new iPhoneFactory();
                        break;
                }

                Console.WriteLine(manu.ToString() + ":\nSmart Phone: " +
                factory.GetSmart().Name() + "\nDumb Phone: " + factory.GetDumb().Name());
            }
        }
    }
}
