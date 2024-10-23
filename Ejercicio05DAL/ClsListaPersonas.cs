using Ejercicio05ENT;


namespace Ejercicio05DAL
{
    public class ClsListaPersonas
    {

        /// <summary>
        /// Funcion que devuelve una lista con 10 objetos de tipo persona
        /// </summary>
        /// <returns>Listado de personas</returns>
        static public List<ClsPersona> listaPersonas()
        {
            List<ClsPersona> lista = new List<ClsPersona>();

            ClsPersona p1 = new ClsPersona("Auri", "Ruiz Castaño", 19);
            ClsPersona p2 = new ClsPersona("Lorenzo Jesús", "Bellido Ballena", 19);
            ClsPersona p3 = new ClsPersona("Jenri", "Muñoz Galloso", 19);
            ClsPersona p4 = new ClsPersona("Angelica", "Ruíz Pito", 23);
            ClsPersona p5 = new ClsPersona("Marco", "Holguín Cascajado", 19);
            ClsPersona p6 = new ClsPersona("Hector", "Arias Campana", 12);
            ClsPersona p7 = new ClsPersona("Raúl", "Romera Romerap", 20);
            ClsPersona p8 = new ClsPersona("Carlos", "Gómez Martínez", 30);
            ClsPersona p9 = new ClsPersona("Ana", "Lopez Pérez", 25);
            ClsPersona p10 = new ClsPersona("Lucía", "Fernández García", 22);
            ClsPersona p12 = new ClsPersona("Diego", "Sánchez Romero", 28);
            ClsPersona p22 = new ClsPersona("María", "Torres Blanco", 19);
            ClsPersona p32 = new ClsPersona("Fernando", "Martín Díaz", 35);
            ClsPersona p42 = new ClsPersona("Clara", "Vásquez Ríos", 27);
            ClsPersona p52 = new ClsPersona("Andrés", "Ramírez Molina", 18);
            ClsPersona p62 = new ClsPersona("Sofía", "Castillo Torres", 15);
            ClsPersona p72 = new ClsPersona("Luis", "Alonso Cordero", 40);
            ClsPersona p82 = new ClsPersona("Sara", "Díaz Romero", 33);
            ClsPersona p95 = new ClsPersona("Isabel", "Suárez Pérez", 29);
            ClsPersona p210 = new ClsPersona("Ángel", "Jiménez Bravo", 31);

            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);
            lista.Add(p4);
            lista.Add(p5);
            lista.Add(p6);
            lista.Add(p7);
            lista.Add(p8);
            lista.Add(p9);
            lista.Add(p10);
            lista.Add(p1);
            lista.Add(p22);
            lista.Add(p32);
            lista.Add(p42);
            lista.Add(p52);
            lista.Add(p62);
            lista.Add(p72);
            lista.Add(p82);
            lista.Add(p95);
            lista.Add(p210);

            return lista;
        }
    }
}