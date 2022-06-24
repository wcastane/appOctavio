using System.ComponentModel.DataAnnotations;

namespace libOctavio
{
    public enum TipoCaja
    {
        CajaSeca = 1,
        Plataforma = 2
    };

    public class Carro
    {
        [Key]
        public string SKU { get; set; }
        public int Ruedas { get; set; }
        public int Puertas { get; set; }
        public string NoSerie { get; set; }

        public bool EstaEncendido { get; set; }

        public void Encender()
        {
            this.EstaEncendido = true;
        }

        public void Apagar()
        {
            this.EstaEncendido = false;
        }

    }

    public class Camion : Carro
    {
        public TipoCaja TipoCaja { get; set; }
        public int TamañoCaja { get; set; }
    }

    public class Caja
    {
        public int CajaId { get; set; }
        public int Ruedas { get; set; }
        public int Largo { get; set; }
    }
}