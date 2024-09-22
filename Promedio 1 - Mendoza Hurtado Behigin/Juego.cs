using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace Promedio_1___Mendoza_Hurtado_Behigin
{
    public class Juego
    {
        private Jugador jugador;
        private List<Pregunta> preguntas;

        public Juego()
        {
            jugador = new Jugador();
            preguntas = new List<Pregunta>
        {
            new Pregunta("¿En qué continente está Australia?",
                          new string[] { "Oceania", "America", "Asia" },
                          "Oceania"),
            new Pregunta("¿Cuántos departamentos tiene el Perú?",
                          new string[] { "24", "25", "23" },
                          "24"),
            new Pregunta("¿Cuántos planetas tiene el sistema solar?",
                          new string[] { "7", "9", "8" },
                          "8"),
        };
        }

        public void Iniciar()
        {
            Console.WriteLine("Bienvenido al Gran Concurso de Sabiduría. ¿Estás listo para el desafío?");
            foreach (var pregunta in preguntas)
            {
                Console.WriteLine(pregunta.Texto);
                for (int i = 0; i < pregunta.Opciones.Length; i++)
                {
                    Console.WriteLine($"{(char)('a' + i)}. {pregunta.Opciones[i]}");
                }

                Console.WriteLine("Ponga la letra correcta:");
                char respuesta = Console.ReadKey().KeyChar; // Lee la letra de la respuesta
                Console.WriteLine(); // Para una nueva línea

                // Verificar si la respuesta es correcta
                bool esCorrecta = pregunta.Opciones[respuesta - 'a'] == pregunta.RespuestaCorrecta;
                jugador.Responder(esCorrecta);

                if (esCorrecta)
                {
                    Console.WriteLine("¡Respuesta correcta! Ganas 1 punto de inteligencia.");
                }
                else
                {
                    Console.WriteLine("Respuesta incorrecta. Ganas 1 punto de ignorancia.");
                }
            }

            MostrarResultado();
            Console.WriteLine("Presiona una tecla para salir...");
            Console.ReadLine(); // Espera que se presione una tecla antes de cerrar
        }

        private void MostrarResultado()
        {
            Console.WriteLine($"Puntos de inteligencia: {jugador.PuntosInteligencia}");
            Console.WriteLine($"Puntos de ignorancia: {jugador.PuntosIgnorancia}");

            if (jugador.PuntosInteligencia > jugador.PuntosIgnorancia)
            {
                Console.WriteLine("¡Ganaste el concurso de inteligencia!");
            }
            else if (jugador.PuntosIgnorancia > jugador.PuntosInteligencia)
            {
                Console.WriteLine("Perdiste el concurso de inteligencia.");
            }
            else
            {
                Console.WriteLine("Empate. Intenta nuevamente.");
            }
        }

    }
}
