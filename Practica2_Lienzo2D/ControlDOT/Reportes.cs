using Practica2_Lienzo2D.Interprete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_Lienzo2D.ControlDOT
{
    public class Reportes
    {
        public void TablaErrores(List<ErrorEjecucion> lista)
        {
            String html = "";

            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;

            html += "<!DOCTYPE html>\n" +
                    "<html lang=\"es\">\n" +
                    "<head>\n" +
                        "\t<meta charset=\"UTF-8\">" + 
                        "\t<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">" + 
                        "\t<meta http-equiv=\"X-UA-Compatible\" content=>" + 
                        "\t<link rel=\"stylesheet\" href=\"Estilo.css\">" + 
                        "\t<title>Repoertes</title>" + 
                    "</head>" + 
                    "<body>" + 
                        "\t<h1>Tabla de errores encontrados</h1>" + 
                        "\t<div class=\"hora\">" +
                            "\t\t<p>" + day + "</p>" +
                            "\t\t<p> - </p>" +
                            "\t\t<p>" + month + "</p>" +
                            "\t\t<p> - </p>" +
                            "\t\t<p>" + year + "</p>" +
                        "\t</div>" +
                        "\t<div class=\"fecha\">" +
                            "\t\t<p>" + hour + "</p>" +
                            "\t\t<p> : </p>" +
                            "\t\t<p>" + minute + "</p>" +
                            "\t\t<p> : </p>" +
                            "\t\t<p>" + second + "</p>" +
                        "\t</div>" +
                        "\t<div class=\"reporte\">" +
                            "\t\t<table class=\"tabla\">" +
                                "\t\t\t<tr>" +
                                    "\t\t\t\t<th>Tipo</th>" +
                                    "\t\t\t\t<th>Error</th>" +
                                    "\t\t\t\t<th>Columna</th>" +
                                    "\t\t\t\t<th>Fila</th>" +
                                "\t\t\t</tr>";
            
            foreach (ErrorEjecucion item in lista)
            {
                html += "\t\t\t<tr>" +
                            "\t\t\t\t<td>" + item.Tipo + "</td>" +
                            "\t\t\t\t<td>" + item.Error + "</td>" +
                            "\t\t\t\t<td>" + item.Columna + "</td>" +
                            "\t\t\t\t<td>" + item.Fila + "</td>" +
                        "\t\t\t</tr>";
            }

            html += "\t\t</table>" +
                    "\t</div>" +
                    "</body>" +
                    "</html>";

            StreamWriter writer = new StreamWriter("reportes.html");
            writer.WriteLine(html);
            writer.Close();
        }
    }
}
