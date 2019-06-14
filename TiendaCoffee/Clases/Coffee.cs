using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCoffee.Clases
{
    public class Coffee
    {
        private string NombreCliente;
        private string TipoCliente;
        private string TipoCafe;
        private string TipoAzucar;
        private string TipoLeche;
        private string Temperatura;

        public Coffee(string NombreCliente, string TipoCliente, string TipoCafe, string TipoAzucar, string TipoLeche, string Temperatura )
        {
            this.NombreCliente = NombreCliente;
            this.TipoCliente = TipoCliente;
            this.TipoCafe = TipoCafe;
            this.TipoAzucar = TipoAzucar;
            this.TipoLeche = TipoLeche;
            this.Temperatura = Temperatura;
        }
        public string nombrecliente
        {
            get
            {
                return NombreCliente;
            }

            set
            {
                NombreCliente = value;
            }
        }
        public string tipocliente
        {
            get
            {
                return TipoCliente;
            }

            set
            {
                TipoCliente = value;
            }
        }
        public string tipocafe
        {
            get
            {
                return TipoCafe;
            }

            set
            {
                TipoCafe = value;
            }
        }
        public string tipoazucar
        {
            get
            {
                return TipoAzucar;
            }

            set
            {
               TipoAzucar = value;
            }
        }
        public string tipoleche
        {
            get
            {
                return TipoLeche;
            }

            set
            {
                TipoLeche = value;
            }
        }
        public string temperatura
        {
            get
            {
                return Temperatura;
            }

            set
            {
                Temperatura = value;
            }
        }
    }
}
