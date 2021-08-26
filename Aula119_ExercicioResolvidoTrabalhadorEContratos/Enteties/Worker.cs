using System;
using Aula119_ExercicioResolvidoTrabalhadorEContratos.Enteties.Enums;

namespace Aula119_ExercicioResolvidoTrabalhadorEContratos.Enteties
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
    }
}
