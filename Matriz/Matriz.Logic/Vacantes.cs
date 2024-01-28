using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz.Logic
{
    public abstract class Vacantes
    {
        public Vacantes()
        {
            UIdvacante = Guid.NewGuid().ToString();
        }
        public string? UIdvacante { get; }
        public string? Name { get; set; }
        public TipoExperiencia Experiencia { get; set; }
        public decimal Salario { get; set; }
        public TipoModalidad Modalidad { get; set; }
        public abstract decimal GetValueSalaryTraineeToPay();
        public abstract decimal GetValueSalaryJuniorToPay();
        public abstract decimal GetValueSalaryInterToPay();
        public override string ToString()
        {
            return $"ID:\t{UIdvacante}\n\t" +
                   $"Nombre de la Vacante:...{Name,20}\n\t" +
                   $"Experiencia:............{Experiencia,20}\n\t" +
                   $"Modalidad Vacante:......{Modalidad,20}\n\t" +
                   "======SALARIO SEGÚN EXPERIENCIA LABORAL======\n\t" +
                   $"Salario Senior......{Salario,20:C2}\n\t";
        }
    }

    public enum TipoExperiencia
    {
        Trainee,
        Junior,
        Intermedio,
        Senior,
        Lead,
        Gerente
    }

    public enum TipoModalidad 
    {
        Hibrido,
        Presencial,
        Remoto
    }
}