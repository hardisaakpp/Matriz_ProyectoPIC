using Matriz.Logic;

var vacanteOne = new VacantesModalidad()
{
    Name = "Ingenieria de Software",
    Experiencia = TipoExperiencia.Senior,
    Salario = 3100.00m,
    Modalidad = TipoModalidad.Remoto,
};

//Este es un objeto
var vacanteTwo = new VacantesModalidad()
{
    Name = "Ingenieria Civil",
    Experiencia = TipoExperiencia.Intermedio,
    Salario = 3100.00m,
    Modalidad = TipoModalidad.Presencial,
};

var vacanteTre = new VacantesModalidad()
{
    Name = "Ingenieria Mecanica",
    Experiencia = TipoExperiencia.Junior,
    Salario = 3100.00m,
    Modalidad = TipoModalidad.Presencial,
};

var vacanteFor = new VacantesModalidad()
{
    Name = "Ingenieria de Electrónica",
    Experiencia = TipoExperiencia.Trainee,
    Salario = 3100.00m,
    Modalidad = TipoModalidad.Hibrido,
};

//Este es un arreglo (array)
List<Vacantes> vacantes = new List<Vacantes>() { vacanteOne};
vacantes.Add(vacanteTwo);
vacantes.Add(vacanteTre);
vacantes.Add(vacanteFor);


//el método FindAll se utiliza para buscar y devolver todos los elementos en la lista vacantes. Find= 1º elemento
var vac_presen = vacantes.FindAll(vac => vac.Modalidad == TipoModalidad.Hibrido);

foreach (var item in vac_presen)
{
    Console.WriteLine(item);
}





//para borrar o no mostrar un objeto, es una funcion, funciones lambda (flecha=> Javascript)
//carreras.RemoveAll(carr => carr.Name == "<Ingenieria de Software");

//espacio de memoria
//Console.WriteLine(vacanteTwo.GetHashCode);