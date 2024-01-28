using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz.Logic
{
    public class VacantesModalidad : Vacantes
    {

        public override decimal GetValueSalaryInterToPay()
        {
            return Salario * 0.70m;
        }

        public override decimal GetValueSalaryJuniorToPay()
        {
            return Salario * 0.20m;
        }

        public override decimal GetValueSalaryTraineeToPay()
        {
            return Salario * 0.150m;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"Salario Intermedio........{GetValueSalaryInterToPay(),20:C2}\n\t" +
                   $"Salario Junior.......{GetValueSalaryJuniorToPay(),20:C2}\n\t" +
                   $"Salario Trainee.....{GetValueSalaryTraineeToPay(),20:C2}\n\t";
                   
        }
    }
}
